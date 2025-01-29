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

namespace Mexabor
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
            CacheUsuario.LimpiarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CacheFormsRestaurante.LimpiarCache();
            FormRegistros formRegistros = new FormRegistros();
            formRegistros.Show();
            this.Close();
        }

        private void btn_Auditoria_Click(object sender, EventArgs e)
        {
            btnCedis.Visible = true;
            btnRedtaurante.Visible = true;
            btn_Auditoria.Visible = false;
            btnRegistros.Visible = false;
            lblCerrarSesion.Visible = false;
            lblVolver.Visible = true;
        }

        private void btnRedtaurante_Click(object sender, EventArgs e)
        {
            CacheFormsRestaurante.LimpiarCache();
            Form1Estacionamiento formEstacionamiento = new Form1Estacionamiento();
            formEstacionamiento.Show();
            this.Close();
        }

        private void lblVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnCedis.Visible = false;
            btnRedtaurante.Visible = false;
            btn_Auditoria.Visible = true;
            btnRegistros.Visible = true;
            lblCerrarSesion.Visible = true;
            lblVolver.Visible = false;
        }

        private void btnCedis_Click(object sender, EventArgs e)
        {
            AlmaSalida almaSalida = new AlmaSalida();
            almaSalida.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormGestor formGestor = new FormGestor();
            formGestor.Show();
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (CacheAplicacion.CacheUsuario.tipoUsuario == "administrador")
            {
                iconoAdmin.Visible = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Close();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
