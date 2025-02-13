using Mexabor.Almacen;
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
    public partial class FormGestor : Form
    {
        public FormGestor()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new();
            formMenu.Show();
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormRegistros formRegistros = new();
            formRegistros.Show();
            this.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ExportacionRestaurante exportacionFinal = new();
            exportacionFinal.Show();
            this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            AjustesAvanzados ajustesAvanzados = new();
            ajustesAvanzados.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1Estacionamiento formEstacionamiento = new();
            formEstacionamiento.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2Comedor formComedor = new();
            formComedor.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3Barra formBarra = new();
            formBarra.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4Tortillas formTortilla = new();
            formTortilla.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5Servicios formServicios = new();
            formServicios.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6Planchas formPlanchas = new();
            formPlanchas.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7Loza formLoza = new();
            formLoza.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8Banos formBanos = new();
            formBanos.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9Juegos formJuegos = new();
            formJuegos.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10Personal formPersonal = new();
            formPersonal.Show();
            this.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FormPersonal2 formPersonal2 = new();
            formPersonal2.Show();
            this.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FormVarios formVarios = new();
            formVarios.Show();
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            FormProovedores formProovedores = new();
            formProovedores.Show();
            this.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            FormTemperaturas formTemperaturas = new();
            formTemperaturas.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AlmaSalida formSalida = new();
            formSalida.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Alma2CocinaCaliente almaCocinaCaliente = new();
            almaCocinaCaliente.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Alma6CocinaFria almaCocinaFria = new();
            almaCocinaFria.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Almacen.Alma4 almacen = new Almacen.Alma4();
            almacen.Show();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Alma5Personal almaPersonal = new();
            almaPersonal.Show();
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Alma3CamaraFria almaCamaraFria = new();
            almaCamaraFria.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Alma7Cajas almaCajas = new();
            almaCajas.Show();
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            RevisionProductos almacenProductos = new();
            almacenProductos.Show();
            this.Close();
        }
    }
}
