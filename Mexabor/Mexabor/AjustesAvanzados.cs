using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Mexabor
{
    public partial class AjustesAvanzados : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public AjustesAvanzados()
        {
            InitializeComponent();
        }
        public void ActualizarTabla()
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string consulta = "SELECT * FROM Usuarios";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
                conn.Close();
            }
        }
        public void LimpiarCampos() 
        {
            // Limpiar los campos
            txtClave.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            cbCredenciales.Text = string.Empty;
        }
        public void ElimarUsuario(int id) 
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Consulta con los nombres de parámetros correctos
                string consulta = "DELETE FROM Usuarios WHERE Id = @id";
                try
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(consulta, conn)) // Asegúrate de pasar la conexión al comando
                    {
                        command.Parameters.AddWithValue("@id", id);

                        // Ejecutar la consulta
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show($"Usuario {txtUsuario.Text} eliminado con éxito.");
                        }
                        // Actualizar la tabla si tienes un método para esto
                        ActualizarTabla();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
        public void AgregarUsuario() 
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Consulta con los nombres de parámetros correctos
                string consulta = "INSERT INTO Usuarios (Usuario, Clave, Credenciales) VALUES (@usuario, @clave, @credenciales)";
                try
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(consulta, conn)) // Asegúrate de pasar la conexión al comando
                    {
                        // Agregar los parámetros con nombres que coincidan en la consulta
                        command.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        command.Parameters.AddWithValue("@clave", txtClave.Text);
                        command.Parameters.AddWithValue("@credenciales", cbCredenciales.Text);

                        // Ejecutar la consulta
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show($"Usuario {txtUsuario.Text} agregado con éxito.");
                        }

                        // Actualizar la tabla si tienes un método para esto
                        ActualizarTabla();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AjustesAvanzados_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Validar manualmente cada control
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo de usuario está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("El campo de clave está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbCredenciales.Text))
            {
                MessageBox.Show("El campo de credenciales está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todos los campos están completos, ejecutar la lógica
            AgregarUsuario();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LimpiarCampos();
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Validar que la celda no sea nula y convertir de manera segura
                if (filaSeleccionada.Cells["Id"].Value != null && int.TryParse(filaSeleccionada.Cells["Id"].Value.ToString(), out int id))
                {
                    string usuario = filaSeleccionada.Cells["Usuario"].Value.ToString();
                    DialogResult resultado = MessageBox.Show($"¿Deseas eliminar el usuario: {usuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ElimarUsuario(id); // Asegúrate de que el método ElimarUsuario funcione correctamente
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

        }
    }
}
