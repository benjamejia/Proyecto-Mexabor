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
                    string.IsNullOrWhiteSpace(txbEmpacados.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que los valores numéricos sean correctos
                if (!int.TryParse(txbProducto.Text, out ConexionBD_Productos.productos) ||
                    !int.TryParse(txbEmpacados.Text, out ConexionBD_Productos.empacado) ||
                    !int.TryParse(txbCalidad.Text, out ConexionBD_Productos.calidad))
                {
                    MessageBox.Show("Los valores de Producto, Empacados y Calidad deben ser números enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ConexionBD_Productos.observaciones = string.IsNullOrWhiteSpace(txtObservacion.Text) ? "Sin observaciones" : txtObservacion.Text;
                ConexionBD_Productos.SubirProductos();
                // Notificar éxito y limpiar campos
                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos después de la inserción
                txbProducto.Clear();
                txbEmpacados.Clear();
                txbCalidad.Clear();
                txtObservacion.Text = "Sin observacion.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RevisionDeProductos();
            ExportacionAlmacen exportacionAlmacen = new ExportacionAlmacen();
            exportacionAlmacen.Show();
            this.Close();
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            const int maxCaracteres = 200;

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
            this.Close();
        }
    }
}
