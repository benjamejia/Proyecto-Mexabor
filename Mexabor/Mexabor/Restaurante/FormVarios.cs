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
    public partial class FormVarios : Form
    {
        private List<int> elementos = new List<int>();
        public FormVarios()
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
        private void FormVarios_Load(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Estas seguro que deseas continuar?\n Asegurate de que las opciones esten correctamente seleccionadas", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                elementos.Clear();
                Verificar(this.Controls);
                //Limpiamos la memoria almacenada de las listas
                CacheFormsRestaurante.documentos.Clear();
                CacheFormsRestaurante.almacen.Clear();
                CacheFormsRestaurante.caja.Clear();
                CacheFormsRestaurante.ambiente.Clear();
                //Agregar el valor de la lista elemetnos a las listas
                CacheFormsRestaurante.documentos = elementos.GetRange(0, 5);
                CacheFormsRestaurante.almacen = elementos.GetRange(5, 8);
                CacheFormsRestaurante.caja = elementos.GetRange(13, 10);
                CacheFormsRestaurante.ambiente = elementos.GetRange(23, 3);
                FormProovedores formProovedores = new FormProovedores();
                formProovedores.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPersonal2 formPersonal2 = new FormPersonal2();
            formPersonal2.Show();
            this.Close();
        }

        private void cbxMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            MarcarTodo(this.Controls);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
