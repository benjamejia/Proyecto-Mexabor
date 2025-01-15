//Autor: MEJIA PADILLA CARLOS BENJAMIN.
//VERSION: 1.0(solo para tener control.)
//FECHA: 11/11/24

using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;

namespace App
{
    public partial class Form1 : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Logear();
        }

        public void Logear()
        {
            //Verifica si los campos de inicio de sesion estan vacios.
            if (txb_usuario.Text == string.Empty || txb_contraseña.Text == string.Empty) 
            {
                MessageBox.Show("Los campos estan vacios!");
            }
            else
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string usuario = txb_usuario.Text;
                    string contraseña = txb_contraseña.Text;

                    // Prepara la consulta SQL
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT tipoUsuario FROM usuarios WHERE usuario = @usuario AND clave = @contraseña", conexion))
                    {
                        // Añade los parámetros
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);

                        // Ejecuta la consulta
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Si encuentra un resultado
                            {
                                // Obtén el valor de tipoUsuario y almacena en cache el usuario.
                                CacheUsuario.tipoUsuario = reader["tipoUsuario"].ToString();
                                CacheUsuario.usuario = usuario;

                                // Verifica el tipo de usuario
                                if (CacheUsuario.tipoUsuario == "administrador")
                                {
                                    // Si es administrador, abre el formulario del administrador
                                    Admin menuAdmin = new Admin();
                                    menuAdmin.Show();
                                    // Oculta el formulario de login
                                    this.Hide();
                                }
                                else if (CacheUsuario.tipoUsuario == "usuario")
                                {
                                    // Si es usuario normal, abre el formulario del usuario
                                    FormMenu2 menuUsuario = new FormMenu2();
                                    menuUsuario.Show();
                                    // Oculta el formulario de login
                                    this.Hide();
                                }
                            }
                            else
                            {
                                // Muestra un mensaje si el usuario y/o contraseña son incorrectos
                                MessageBox.Show("Usuario y/o Contraseña incorrecta.");
                            }
                        }
                    }
                }
            }
        }

        private void txb_contraseña_TextChanged_1(object sender, EventArgs e)
        {
            txb_contraseña.PasswordChar = '*';
        }

        private void txb_contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logear();
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txb_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logear();
            }
        }
    }
}
