using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Math;
using SQLitePCL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    public partial class FormAdmin : Form
    {
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public FormAdmin()
        {
            InitializeComponent();

            toolTip = new System.Windows.Forms.ToolTip
            {
                IsBalloon = false, // Opcional: hace que el ToolTip tenga un diseño de globo
                ToolTipTitle = "Acción", // Título del ToolTip
                InitialDelay = 500, // Tiempo en milisegundos antes de que aparezca
                ReshowDelay = 200,  // Tiempo entre apariciones si el mouse se mueve rápidamente
                AutoPopDelay = 5000 // Tiempo que permanece visible (en milisegundos)
            };
            toolTip2 = new System.Windows.Forms.ToolTip
            {
                IsBalloon = false, // Opcional: hace que el ToolTip tenga un diseño de globo
                ToolTipTitle = "Acción", // Título del ToolTip
                InitialDelay = 500, // Tiempo en milisegundos antes de que aparezca
                ReshowDelay = 200,  // Tiempo entre apariciones si el mouse se mueve rápidamente
                AutoPopDelay = 5000 // Tiempo que permanece visible (en milisegundos)
            };
            toolTip3 = new System.Windows.Forms.ToolTip
            {
                IsBalloon = false, // Opcional: hace que el ToolTip tenga un diseño de globo
                ToolTipTitle = "Acción", // Título del ToolTip
                InitialDelay = 500, // Tiempo en milisegundos antes de que aparezca
                ReshowDelay = 200,  // Tiempo entre apariciones si el mouse se mueve rápidamente
                AutoPopDelay = 5000 // Tiempo que permanece visible (en milisegundos)
            };
        }



        private void FormAdmin_Load(object sender, EventArgs e)
        {
            //Lineas  para cargar los  placeholders de los textos de modificacion de usuarios.
            txbUsuario.Text = "Ingrese usuario";
            txbUsuario.ForeColor = SystemColors.GrayText; // Texto inicial en color opaco
            txbClave.Text = "Ingrese contraseña";
            txbClave.ForeColor = SystemColors.GrayText;
            txbUsuario.Enter += textBox2_Enter; // Vincular eventos
            txbUsuario.Leave += txbUsuario_Leave;
            txbClave.Leave += txbClave_Leave;
            txbClave.Leave += txbClave_Leave;
            //linea para definir el texto encima del boton de guardar
            toolTip.SetToolTip(btnGuardar, "Guardar Cambios.");
            toolTip2.SetToolTip(btnAgregar, "Agregar Usuario.");
            toolTip3.SetToolTip(btnEliminar, "Eliminar Usuario");

            //Linea para llenar el dataGridView principal
            DataUsuarios();
        }

        public void DataUsuarios()
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string consulta = "SELECT * FROM usuarios";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
                conn.Close();
            }
        }
        public void AgregarUsuario()
        {
            using (SQLiteConnection connection = new SQLiteConnection(cadena))
            {
                try
                {
                    connection.Open();

                    // Define la consulta SQL con parámetros
                    string query = "INSERT INTO usuarios (Usuario, Clave, Correo) VALUES (@Usuario, @Clave, @Correo)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        // Añade los parámetros a la consulta
                        cmd.Parameters.AddWithValue("@Usuario", CacheUsuario.usuarioTemporal);
                        cmd.Parameters.AddWithValue("@Clave", CacheUsuario.claveTemporal);
                        cmd.Parameters.AddWithValue("@Correo", CacheUsuario.correoTemporal);

                        // Ejecuta la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("El usuario se ha agregado correctamente.");
                        Console.WriteLine($"{rowsAffected} fila(s) insertada(s).");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(cadena))
            {
                try
                {
                    connection.Open();

                    // consulta SQL para actualizar el usuario
                    string query = "UPDATE usuarios SET Usuario = @Usuario, Clave = @Clave, tipoUsuario = @tipoUsuario WHERE Id = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        // Añade los parámetros a la consulta
                        cmd.Parameters.AddWithValue("@Usuario", txbUsuario.Text);
                        cmd.Parameters.AddWithValue("@Clave", txbClave.Text);
                        cmd.Parameters.AddWithValue("@tipoUsuario", cbPermisos.Text);
                        cmd.Parameters.AddWithValue("@id", CacheUsuario.idUser);

                        // Ejecuta la consulta
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} fila(s) actualizada(s).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        //Linea para actualizar el dataGridView
                        DataUsuarios();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "Ingrese usuario")
            {
                txbUsuario.Text = "";
                txbUsuario.ForeColor = SystemColors.WindowText; // Cambia a color normal
            }
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsuario.Text))
            {
                txbUsuario.Text = "Ingrese usuario";
                txbUsuario.ForeColor = SystemColors.GrayText; // Cambia a color opaco
            }
        }

        private void txbClave_Enter(object sender, EventArgs e)
        {
            if (txbClave.Text == "Ingrese contraseña")
            {
                txbClave.Text = "";
                txbClave.ForeColor = SystemColors.WindowText; // Cambia a color normal
            }
        }

        private void txbClave_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbClave.Text))
            {
                txbClave.Text = "Ingrese contraseña";
                txbClave.ForeColor = SystemColors.GrayText; // Cambia a color opaco
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                txbClave.Text = filaSeleccionada.Cells["Clave"].Value.ToString();
                txbUsuario.Text = filaSeleccionada.Cells["Usuario"].Value.ToString();
                cbPermisos.Text = filaSeleccionada.Cells["tipoUsuario"].Value.ToString();
                CacheUsuario.idUser = filaSeleccionada.Cells["id"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpiar cachce del usuario anterior si es que se ha seleccionado.
            using (SQLiteConnection connection = new SQLiteConnection(cadena))
            {
                try
                {
                    connection.Open();
                    // Define la consulta SQL con parámetros
                    string query = "DELETE FROM usuarios WHERE Id = @Id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        // Añade los parámetros a la consulta
                        cmd.Parameters.AddWithValue("@Id", CacheUsuario.idUser);
                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();
                        // Verificar el resultado
                        if (rowsAffected != 0)
                        {
                            //actualizar el dataGridView
                            DataUsuarios();
                            MessageBox.Show("Usuario eliminado exitosamente.");
                            //limpiar los campos
                            txbClave.Text = string.Empty;
                            txbUsuario.Text = string.Empty;
                            cbPermisos.Text = string.Empty;
                            CacheUsuario.idUser = string.Empty;
                        }
                        else 
                        {
                            MessageBox.Show("Selecciona un usuario!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //se limpia el cache del ususario por si habia uno asignado previamente.
            CacheUsuario.idUser = string.Empty;
            if (txbUsuario.Text == string.Empty || txbClave.Text == string.Empty || cbPermisos.Text == string.Empty) 
            {
                MessageBox.Show("Hay campos vacios.");
                return;
            }
            using (SQLiteConnection connection = new SQLiteConnection(cadena)) 
            {
                try
                {
                    connection.Open();
                    // Define la consulta SQL con parámetros
                    string query = "INSERT INTO usuarios (Usuario,Clave,tipoUsuario) VALUES (@usuario,@clave,@tipoUsuario)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", txbUsuario.Text);
                        cmd.Parameters.AddWithValue("@clave", txbClave.Text);
                        cmd.Parameters.AddWithValue("@tipoUsuario", cbPermisos.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine("Usuario agregado exitosamente.");
                        //Actualizar el dataGridView
                        DataUsuarios();
                        // Verificar el resultado
                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("Error.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHistorial formHistorial = new FormHistorial();
            formHistorial.Show();
            this.Close();
        }
    }
}

