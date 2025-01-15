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
    public partial class Form9Juegos : Form
    {
        private List<int> elementos = new List<int>();
        public Form9Juegos()
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
        private void button2_Click(object sender, EventArgs e)
        {
            Form8Banos formBanos = new Form8Banos();
            formBanos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call Verificar method to fill the list with checkbox states
            DialogResult opcion = MessageBox.Show("¿Estas seguro que deseas continuar?\n Asegurate de que las opciones esten correctamente seleccionadas", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                elementos.Clear();
                Verificar(this.Controls);
                CacheFormsRestaurante.juegosEstructura.Clear();
                CacheFormsRestaurante.juegosLimpieza.Clear();
                //Agregar el valor de la lista elemetnos a las listas
                CacheFormsRestaurante.juegosEstructura = elementos.GetRange(0, 6);
                CacheFormsRestaurante.juegosLimpieza = elementos.GetRange(6, 4);
                Form10Personal formPersonal = new Form10Personal();
                formPersonal.Show();
                this.Close();
            }
        }

        private void cbxMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            MarcarTodo(this.Controls);
        }
    }
}
