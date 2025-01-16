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
        //Este metodo llena los items del checkBox de cada alimento de acuerdo a sus temperaturas
        public void TemperaturasIdeales(Control.ControlCollection controls)
        {
            // Ordenar los controles una sola vez
            var orderedControls = controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList();

            foreach (Control control in orderedControls)
            {
                // Verificar si el control es un TableLayoutPanel
                if (control is TableLayoutPanel tableLayout)
                {
                    // Recorrer los controles dentro del TableLayoutPanel
                    foreach (Control cellControl in tableLayout.Controls)
                    {
                        // Verificar si el control es un Label
                        if (cellControl is Label label)
                        {
                            string alimento = label.Text;

                            // Si el alimento está en temperaturasIdeales
                            if (CacheFormsRestaurante.temperaturasIdeales.ContainsKey(alimento))
                            {
                                int[] rango = CacheFormsRestaurante.temperaturasIdeales[alimento];
                                int tempMin = rango[0];
                                int tempMax = rango[1];

                                // Buscar el ComboBox relacionado dentro del mismo contenedor
                                var relatedComboBox = tableLayout.Controls
                                    .OfType<ComboBox>()
                                    .FirstOrDefault(cb => cb.TabIndex > label.TabIndex); // Relacionar por TabIndex

                                if (relatedComboBox != null)
                                {
                                    // Agregar las temperaturas al ComboBox
                                    relatedComboBox.Items.Clear(); // Limpia los valores previos
                                    for (int i = tempMin; i <= tempMax; i++)
                                    {
                                        relatedComboBox.Items.Add(i);
                                    }
                                }
                            }
                        }
                    }
                }
            }
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
                        if (cellControl is ComboBox comboBox)
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
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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
                this.Close();
            }
        }

        private void FormTemperaturas_Load(object sender, EventArgs e)
        {
            TemperaturasIdeales(this.Controls);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TemperaturasIdeales(this.Controls);
        }
    }
}
