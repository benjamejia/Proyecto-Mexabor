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
    public partial class FormTemperaturas : Form
    {
        private List<int> sabores = new List<int>();
        private List<int> temperaturas = new List<int>();
        public FormTemperaturas()
        {
            InitializeComponent();
        }
        private void VerificarSabores(Control.ControlCollection controls)
        {
            var orderedControls = controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList();

            foreach (Control control in orderedControls)
            {
                // Verificar si el control es un TableLayoutPanel
                if (control is TableLayoutPanel tableLayout)
                {
                    // Recorrer los controles dentro del TableLayoutPanel
                    foreach (Control cellControl in tableLayout.Controls)
                    {
                        // Verificar si el control es un CheckBox
                        if (cellControl is CheckBox checkBox)
                        {
                            sabores.Add(checkBox.Checked ? 1 : 0);
                        }
                    }
                }
            }
        }
        private void VerificarTemperaturas(Control.ControlCollection controls)
        {
            var orderedControls = controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList();

            foreach (Control control in orderedControls)
            {
                // Verificar si el control es un TableLayoutPanel
                if (control is TableLayoutPanel tableLayout)
                {
                    // Recorrer los controles dentro del TableLayoutPanel
                    foreach (Control cellControl in tableLayout.Controls)
                    {
                        // Verificar si el control es un CheckBox
                        if (cellControl is TextBox comboBox)
                        {
                            temperaturas.Add(int.Parse(comboBox.Text));
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            FormProovedores formProovedores = new FormProovedores();
            formProovedores.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TableLayoutPanel tableLayoutPanel) 
                {
                    // Recorrer los controles dentro del TableLayoutPanel
                    foreach (Control cellControl in tableLayoutPanel.Controls)
                    {
                        if (cellControl is TextBox textBox)
                        {
                            if (textBox.Text == string.Empty) 
                            {
                                MessageBox.Show("Hay campos de temperaturas vacias.");
                                return;
                            }
                        }
                    }
                }
                
            }
            DialogResult opcion = MessageBox.Show("¿Estas seguro que deseas continuar?\n Asegurate de que las opciones esten correctamente seleccionadas", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                sabores.Clear();
                temperaturas.Clear();
                VerificarSabores(this.Controls);
                VerificarTemperaturas(this.Controls);
                //Agregar el valor de la lista elemetnos a las listas
                CacheFormsRestaurante.temperatura = temperaturas;
                CacheFormsRestaurante.sabor = sabores;
                CacheFormsRestaurante.cloracion = (radioButton1.Checked ? 1 : 0);
                CacheFormsRestaurante.fecha = DateTime.Now;
                CacheFormsRestaurante.hora = DateTime.Now;
                //Llamamos al metodo para subir los datos a la base de datos
                ConexionBD_Restaruante.SubirDatos();
                ExportacionRestaurante exportacionFinal = new ExportacionRestaurante();
                exportacionFinal.Show();
                this.Hide();
            }
        }

        private void FormTemperaturas_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void FormTemperaturas_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void FormTemperaturas_FormClosing(object sender, FormClosingEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
