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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnCedis_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void btnAjustesAvanzados_Click(object sender, EventArgs e)
        {
            AjustesAvanzados ajustesAvanzados = new AjustesAvanzados();
            ajustesAvanzados.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CacheConfiguracion.DobleConfirmacion = checkBox1.Checked;
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = CacheConfiguracion.DobleConfirmacion;
        }
    }
}
