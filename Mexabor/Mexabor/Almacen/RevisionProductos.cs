using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mexabor.CacheAplicacion;

namespace Mexabor.Almacen
{
    public partial class RevisionProductos : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public RevisionProductos()
        {
            InitializeComponent();
            RestaurarValores();
        }

        public void RestaurarValores()
        {
            // Verifica que la lista tenga suficientes elementos
            if (CacheFormsAlmacen.productosRevisados.Count >= 4)
            {
                // Asignar los valores de la lista a los TextBox correspondientes
                txbProducto.Text = CacheFormsAlmacen.productosRevisados[0].ToString(); // Producto
                txbCalidad.Text = CacheFormsAlmacen.productosRevisados[1].ToString();  // Calidad
                txbEmpacados.Text = CacheFormsAlmacen.productosRevisados[2].ToString(); // Empacados
                txbPesoIdeal.Text = CacheFormsAlmacen.productosRevisados[3].ToString(); // Peso Ideal
            }
            txtObservacion.Text = CacheFormsAlmacen.observaciones;
        }

        public void RevisionDeProductos()
        {
            try
            {
                // Validación combinada
                if (!int.TryParse(txbProducto.Text, out int t) ||
                    !int.TryParse(txbEmpacados.Text, out int p1) ||
                    !int.TryParse(txbCalidad.Text, out int p2) ||
                    !int.TryParse(txbPesoIdeal.Text, out int p3))
                {
                    MessageBox.Show("Todos los campos deben contener números enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Limpiar la lista antes de agregar nuevos valores
                CacheFormsAlmacen.productosRevisados.Clear();
                CacheFormsAlmacen.productosRevisados.Add(t);
                CacheFormsAlmacen.productosRevisados.Add(p1);
                CacheFormsAlmacen.productosRevisados.Add(p2);
                CacheFormsAlmacen.productosRevisados.Add(p3);

                // Asignar observaciones
                CacheFormsAlmacen.observaciones = string.IsNullOrWhiteSpace(txtObservacion.Text) ? "Sin observaciones" : txtObservacion.Text;

                // Calcular productos incorrectos (revisar si esta fórmula es la correcta)
                if (CacheFormsAlmacen.ponderacionProductos != 0)
                {
                    CacheFormsAlmacen.productosIncorrectosProductos = 100 - (3 * t - p1 - p2 - p3) * CacheFormsAlmacen.ponderacionProductos;
                }
                else
                {
                    MessageBox.Show("La ponderación de productos no puede ser cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Navegación a la ventana de Inventario
                RevisionInventario revisionInventario = new RevisionInventario();
                this.Hide();
                revisionInventario.Show();
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
            RevisionDeProductos();
        }
        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            const int maxCaracteres = 500;
            AutoScroll = true;

            if (txtObservacion.Text.Length > maxCaracteres)
            {
                // Si se excede el límite, recortar el texto y notificar al usuario si es necesario
                txtObservacion.Text = txtObservacion.Text.Substring(0, maxCaracteres);
                txtObservacion.SelectionStart = txtObservacion.Text.Length; // Mantener el cursor al final
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Almacen8Personal alma7Cajas = new Almacen8Personal();
            alma7Cajas.Show();
            this.Hide();
        }

        private void RevisionProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Estás seguro que deseas continuar?\n Se perderá el progreso de la auditoría", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (opcion == DialogResult.OK)
            {
                e.Cancel = false;

                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}

