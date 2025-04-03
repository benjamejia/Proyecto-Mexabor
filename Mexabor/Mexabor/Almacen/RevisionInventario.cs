using Mexabor.CacheAplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mexabor.Almacen
{
    public partial class RevisionInventario : Form
    {
        public RevisionInventario()
        {
            InitializeComponent();
            RestaurarValores();
        }

        public void RestaurarValores()
        {
            // Verifica que la lista tenga suficientes elementos
            if (CacheFormsAlmacen.productosRevisadosInventario.Count >= 2)
            {
                // Asignar los valores de la lista a los TextBox correspondientes
                txbProducto.Text = CacheFormsAlmacen.productosRevisadosInventario[0].ToString(); // Producto
                txbEmpacados.Text = CacheFormsAlmacen.productosRevisadosInventario[1].ToString(); // Empacados
            }
            txtObservacion.Text = CacheFormsAlmacen.observacionesInventario;
        }
        public void RevisionDeProductosInventario()
        {
            try
            {
                // Validación combinada
                if (!int.TryParse(txbProducto.Text, out int t) ||
                    !int.TryParse(txbEmpacados.Text, out int p1))
                {
                    MessageBox.Show("Todos los campos deben contener números enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Limpiar la lista antes de agregar nuevos valores
                CacheFormsAlmacen.productosRevisadosInventario.Clear();
                CacheFormsAlmacen.productosRevisadosInventario.Add(t);
                CacheFormsAlmacen.productosRevisadosInventario.Add(p1);

                // Asignar observaciones
                CacheFormsAlmacen.observaciones = string.IsNullOrWhiteSpace(txtObservacion.Text) ? "Sin observaciones" : txtObservacion.Text;

                // Calcular productos incorrectos (revisar si esta fórmula es la correcta)
                if (CacheFormsAlmacen.ponderacionInventario != 0)
                {
                    CacheFormsAlmacen.productosIncorrectosInventario = 100 - (t - p1) * CacheFormsAlmacen.ponderacionInventario;
                }
                else
                {
                    MessageBox.Show("La ponderación de productos no puede ser cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Navegación a la ventana de Inventario
                Responsables responsables = new Responsables();
                this.Hide();
                responsables.Show();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Acceso fuera de rango: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RevisionDeProductosInventario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RevisionProductos revisionProductos = new RevisionProductos();
            revisionProductos.Show();
            this.Hide();
        }
    }
}
