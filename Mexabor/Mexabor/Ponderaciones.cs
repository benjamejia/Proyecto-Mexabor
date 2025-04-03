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
    public partial class Ponderaciones : Form
    {
        public Ponderaciones()
        {
            InitializeComponent();
            numericUpDown1.Value = CacheFormsRestaurante.ponderacionRestaurante;
            numericUpDown2.Value = CacheFormsAlmacen.ponderacionAlmacen;
            numericUpDown3.Value = CacheFormsAlmacen.ponderacionProductos;
            numericUpDown4.Value = CacheFormsAlmacen.ponderacionInventario;
        }
        public void GuardarCambios()
        {
            CacheFormsRestaurante.ponderacionRestaurante = (int)numericUpDown1.Value;
            CacheFormsAlmacen.ponderacionAlmacen = (int)numericUpDown2.Value;
            CacheFormsAlmacen.ponderacionProductos = (int)numericUpDown3.Value;
            CacheFormsAlmacen.ponderacionInventario = (int)numericUpDown4.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            MessageBox.Show("Se han guardado los cambios correctamente.");
        }

        private void Ponderaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide();
        }
    }
}
