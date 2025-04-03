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

namespace Mexabor.Almacen
{
    public partial class Responsables : Form
    {
        public Responsables()
        {
            InitializeComponent();
            CargarDatos();
        }
        public void CargarDatos()
        {
            CacheFormsAlmacen.responsables[0] = textBox1.Text;
            CacheFormsAlmacen.responsables[1] = textBox2.Text;
            CacheFormsAlmacen.responsables[2] = textBox3.Text;
            CacheFormsAlmacen.responsables[3] = textBox4.Text;
            CacheFormsAlmacen.responsables[4] = textBox5.Text;
            CacheFormsAlmacen.responsables[5] = textBox6.Text;
            CacheFormsAlmacen.responsables[6] = textBox7.Text;
            CacheFormsAlmacen.responsables[7] = textBox8.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
            CacheFormsAlmacen.auditoriaEmpezada = false;
            CacheFormsAlmacen.fecha = DateTime.Now;
            CacheFormsAlmacen.hora = DateTime.Now;
            ConexionBD_Almacen.SubirDatos();
            ExportacionAlmacen exportacionAlmacen = new ExportacionAlmacen();
            this.Hide();
            exportacionAlmacen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RevisionInventario revisionInventario = new RevisionInventario();
            this.Hide();
            revisionInventario.Show();
        }

        private void Responsables_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Estás seguro que deseas continuar?\n Se perderá el progreso de la auditoría", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (opcion == DialogResult.OK)
            {
                e.Cancel = false;

                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
