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
        }

        public void RevisionDeProductos()
        {
            try
            {
                // Validación de entradas
                if (string.IsNullOrWhiteSpace(txbProducto.Text) ||
                    string.IsNullOrWhiteSpace(txbCalidad.Text) ||
                    string.IsNullOrWhiteSpace(txbEmpacados.Text) ||
                    string.IsNullOrEmpty(txbPesoIdeal.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que los valores numéricos sean correctos
                if (!int.TryParse(txbProducto.Text, out int t) ||
                    !int.TryParse(txbEmpacados.Text, out int p1) ||
                    !int.TryParse(txbCalidad.Text, out int p2) ||
                    !int.TryParse(txbPesoIdeal.Text, out int p3))
                {
                    MessageBox.Show("Los valores de Producto, Empacados y Calidad deben ser números enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar observaciones
                CacheFormsAlmacen.observaciones = string.IsNullOrWhiteSpace(txtObservacion.Text) ? "Sin observaciones" : txtObservacion.Text;

                CacheFormsAlmacen.productosRevisados.Add(t);
                CacheFormsAlmacen.productosRevisados.Add(p1);
                CacheFormsAlmacen.productosRevisados.Add(p2);
                CacheFormsAlmacen.productosRevisados.Add(p3);
                CacheFormsAlmacen.productosIncorrectos = 100 - (3*t - p1 - p2 - p3) * 10;

                // Limpiar campos después de la inserción
                txbProducto.Clear();
                txbEmpacados.Clear();
                txbCalidad.Clear();
                txbPesoIdeal.Clear();
                txtObservacion.Text = "Sin observación.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            n1.Value = CacheFormsAlmacen.ponderacion;
            RevisionDeProductos();
            Responsables responsables = new Responsables();
            responsables.Show();
            this.Hide();
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
            Alma7Cajas alma7Cajas = new Alma7Cajas();
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
