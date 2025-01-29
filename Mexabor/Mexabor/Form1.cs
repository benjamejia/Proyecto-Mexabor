//Version 1.0
//Fecha 19 de diciembre 2024
//Fehca actualizada 14 de enero del 2025, aun no termino jeje

using System.Configuration;
using System.Data.SQLite;

namespace Mexabor
{
    public partial class Login : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }
        //Metodo para iniciar sesion con credenciales.
        public void IniciarSesion()
        {
            //Verifica si los campos de inicio de sesion estan vacios.
            if (txb_Usuario.Text == string.Empty || txb_Clave.Text == string.Empty)
            {
                MessageBox.Show("Los campos estan vacios!");
            }
            else
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string usuario = txb_Usuario.Text;
                    string contrase�a = txb_Clave.Text;

                    // Prepara la consulta SQL
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT Credenciales FROM Usuarios WHERE Usuario = @usuario AND Clave = @contrase�a", conexion))
                    {
                        // A�ade los par�metros
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrase�a", contrase�a);

                        // Ejecuta la consulta
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Si encuentra un resultado
                            {
                                // Obt�n el valor de tipoUsuario y almacena en cache el usuario.
                                CacheAplicacion.CacheUsuario.tipoUsuario = reader["Credenciales"].ToString();
                                CacheAplicacion.CacheUsuario.usuario = usuario;

                                FormMenu menu = new FormMenu();
                                menu.Show();
                                // Oculta el formulario de login
                                this.Hide();
                            }
                            else
                            {
                                // Muestra un mensaje si el usuario y/o contrase�a son incorrectos
                                MessageBox.Show(
                                     "Usuario y/o Contrase�a incorrecta.",
                                     "Error de autenticaci�n",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error
                                 );
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void txb_Clave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void txb_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void txb_Clave_TextChanged(object sender, EventArgs e)
        {
            txb_Clave.PasswordChar = '*';
        }

        private void imagenMexabor_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
