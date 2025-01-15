using System;
using System.Windows.Forms;

namespace App
{
    public partial class FormMenu2 : Form
    {
        public FormMenu2()
        {
            InitializeComponent();
            if (CacheUsuario.tipoUsuario == "administrador")
            {
                btn_admin.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataForms.LimpiarDatos();
            FormEstacionamiento formEstacionamiento = new FormEstacionamiento();
            formEstacionamiento.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            //Linea para borrar el cache del usuario al cerrar sesion.
            CacheUsuario.usuario = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHistorial formHistorial = new FormHistorial();
            formHistorial.Show();
            this.Hide();
        }

        private void FormMenu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                Admin admin = new Admin();
                admin.Show();
        }
    }
}
