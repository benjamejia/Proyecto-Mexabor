using System;
using System.Windows.Forms;

namespace App
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Estacionamiento_Click(object sender, EventArgs e)
        {
            FormEstacionamiento formEstacionamiento = new FormEstacionamiento();
            formEstacionamiento.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormComedor formComedor = new FormComedor();
            formComedor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBarra formBarra = new FormBarra();
            formBarra.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTortillas formTortillas = new FormTortillas();
            formTortillas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormServicios formServicios = new FormServicios();
            formServicios.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPlanchas formPlanchas = new FormPlanchas();
            formPlanchas.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormAreLoza formAreLoza = new FormAreLoza();
            formAreLoza.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormBaños formBaños = new FormBaños();
            formBaños.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormJuegos formJuegos = new FormJuegos();
            formJuegos.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormPersonal formPersonal = new FormPersonal();
            formPersonal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPersonal2 formPersonal2 = new FormPersonal2();
            formPersonal2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormVarios formVarios = new FormVarios();
            formVarios.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormProveedoresHerramientas formProveedoresHerramientas = new FormProveedoresHerramientas();
            formProveedoresHerramientas.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormAgua formAgua = new FormAgua();
            formAgua.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FormHistorial formHistorial = new FormHistorial();
            formHistorial.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormExportacion formExportacion = new FormExportacion();
            formExportacion.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormMenu2 formMenu2 = new FormMenu2();
            formMenu2.Show();
            this.Close();
        }
    }
}
