using Mexabor.Almacen;
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
    public partial class Alma2CocinaCaliente : Form
    {
        private List<int> elementos = new List<int>();
        public Alma2CocinaCaliente()
        {
            InitializeComponent();
        }
        private void Verificar(Control.ControlCollection controls)
        {
            var orderedControls = controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList();

            foreach (Control control in orderedControls)
            {
                // Verificar si el control es un Panel o GroupBox
                if (control is Panel || control is GroupBox)
                {
                    // Llamar recursivamente a Verificar para controles dentro del Panel o GroupBox
                    Verificar(control.Controls);
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
                            int i = 0;
                            checkBox.TabIndex = i;
                            i++;
                            // Agregar 1 o 0 según el estado del CheckBox
                            elementos.Add(checkBox.Checked ? 1 : 0);
                        }
                    }
                }
            }
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
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void AlmaCocinaCaliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlmaSalida almaSalida = new AlmaSalida();
            almaSalida.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Estas seguro que deseas continuar?\n Asegurate de que las opciones esten correctamente seleccionadas", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                elementos.Clear();
                Verificar(this.Controls);
                //Limpiar memoria de las listas
                CacheFormsAlmacen.cocincaCalienteEstructura.Clear();
                CacheFormsAlmacen.cocinaCalienteLimpieza.Clear();
                //Agregar el valor de la lista elemetnos a las listas
                CacheFormsAlmacen.cocincaCalienteEstructura = elementos.GetRange(0, 14);
                CacheFormsAlmacen.cocinaCalienteLimpieza = elementos.GetRange(14, 15);
                Alma3CamaraFria almaCamaraFria = new Alma3CamaraFria();
                almaCamaraFria.Show();
                this.Close();
            }
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            MarcarTodo(this.Controls);
        }
    }
}
