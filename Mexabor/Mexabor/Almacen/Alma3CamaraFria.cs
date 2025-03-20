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
    public partial class Alma3CamaraFria : Form
    {
        public Alma3CamaraFria()
        {
            InitializeComponent();
        }
        private List<int> ObtenerValoresDeCheckBox(TableLayoutPanel tableLayout)
        {
            List<int> valores = new List<int>();

            for (int fila = 0; fila < tableLayout.RowCount; fila++)
            {
                for (int columna = 0; columna < tableLayout.ColumnCount; columna++)
                {
                    Control control = tableLayout.GetControlFromPosition(columna, fila);

                    if (control is CheckBox checkBox)
                    {
                        valores.Add(checkBox.Checked ? 1 : 0);
                    }
                }
            }

            return valores;
        }
        public void ObtenerRespuestas(TableLayoutPanel t1, TableLayoutPanel t2)
        {
            CacheFormsAlmacen.camaraEstructura = ObtenerValoresDeCheckBox(t1);
            CacheFormsAlmacen.camaraLimpieza = ObtenerValoresDeCheckBox(t2);
        }
        public void MarcarTodo(Control.ControlCollection controls)
        {
            var orderedControls = controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList();

            if (cbxMarcarTodo.Checked == true)
            {
                foreach (Control control in orderedControls)
                {
                    // Verificar si el control es un Panel o GroupBox
                    if (control is Panel || control is GroupBox)
                    {
                        // Llamar recursivamente a Verificar para controles dentro del Panel o GroupBox
                        MarcarTodo(control.Controls);
                    }
                    // Verificar si el control es un TableLayoutPanel
                    if (control is TableLayoutPanel tableLayout)
                    {
                        // Recorrer los controles dentro del TableLayoutPanel
                        foreach (Control cellControl in tableLayout.Controls)
                        {
                            // Verificar si el control es un CheckBox
                            if (cellControl is CheckBox checkBox)
                            {
                                checkBox.Checked = true;
                            }
                        }
                    }
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alma2CocinaCaliente almaCocinaCaliente = new Alma2CocinaCaliente();
            almaCocinaCaliente.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerRespuestas(tlpE, tlpL);
            Alma4 almacen = new Alma4();
            almacen.Show();
            this.Hide();
        }

        private void tableLayoutPanel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            MarcarTodo(this.Controls);
        }

        private void Alma3CamaraFria_FormClosing(object sender, FormClosingEventArgs e)
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
