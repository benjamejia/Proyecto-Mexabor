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
        }
        public void CargarDatos()
        {
            CacheFormsAlmacen.responsables[0] = cbAreaSalida.Text;
            CacheFormsAlmacen.responsables[1] = cbCocinaCaliente.Text;
            CacheFormsAlmacen.responsables[2] = cbCamaraFria.Text;
            CacheFormsAlmacen.responsables[3] = cbAlmacen.Text;
            CacheFormsAlmacen.responsables[4] = cbCocinaFria.Text;
            CacheFormsAlmacen.responsables[5] = cbCajas.Text;
            CacheFormsAlmacen.responsables[6] = cbVajillas.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
            CacheFormsAlmacen.fecha = DateTime.Now;
            CacheFormsAlmacen.hora = DateTime.Now;
            ConexionBD_Almacen.SubirDatos();
            ExportacionAlmacen exportacionAlmacen = new ExportacionAlmacen();
            this.Hide();
            exportacionAlmacen.Show();
        }
    }
}
