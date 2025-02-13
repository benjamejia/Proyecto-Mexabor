using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mexabor.Almacen
{
    public partial class AgregarProducto : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public AgregarProducto()
        {
            InitializeComponent();
        }
        public void AgregarProductos()
        {
            try
            {
                // Validación de entradas
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SQLiteConnection connection = new SQLiteConnection(cadena))
                {
                    string cantidad = txtCantidad.Text + " " + comboBox1.Text;
                    connection.Open();
                    string query = @"INSERT INTO ProductosAlmacen
                             (Producto, Folio, Empacado, Calidad, CantidadIdeal, Observaciones)
                             VALUES
                             (@producto, @folio,@empacado,@calidad ,@cantidadIdeal, @observaciones)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@producto", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@folio", 0);
                        cmd.Parameters.AddWithValue("@empacado", 0);
                        cmd.Parameters.AddWithValue("@calidad", "");
                        cmd.Parameters.AddWithValue("@cantidadIdeal", cantidad);
                        cmd.Parameters.AddWithValue("@observaciones", "");
                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                // Notificar éxito y limpiar campos
                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = string.Empty;
                txtCantidad.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AgregarProductos();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            this.Close();
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            AgregarProductos();
        }
    }
}
