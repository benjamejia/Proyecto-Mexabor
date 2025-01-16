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
    public partial class ExportacionRestaurante : Form
    {
        public ExportacionRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CacheFormsRestaurante.LimpiarCache();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string rutaExcel = Path.Combine(Directory.GetCurrentDirectory(),"CacheAplicacion", "FormatoReporte.xlsx");
            //GenerarExcel.LlenarExcel();
            GenerarExcel.ExportarDatosExcel();
        }
    }
}
