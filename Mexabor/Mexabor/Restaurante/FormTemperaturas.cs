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
        private List<int> elementos = new List<int>();
        private List<int> temperaturas = new List<int>();
        public FormTemperaturas()
        {
            InitializeComponent();
        }
        private void Verificar(Control.ControlCollection controls)
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
                            elementos.Add(checkBox.Checked ? 1 : 0);
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
                            temperaturas.Select(c => int.Parse(c.ToString()));
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
                elementos.Clear();
                temperaturas.Clear();
                Verificar(this.Controls);
                VerificarTemperaturas(this.Controls);
                //Limpiamos la memoria almacenadas en las listas
                CacheFormsRestaurante.sabor.Clear();
                CacheFormsRestaurante.temperatura.Clear();
                //Agregar el valor de la lista elemetnos a las listas
                CacheFormsRestaurante.temperatura = temperaturas;
                CacheFormsRestaurante.sabor = elementos;
                CacheFormsRestaurante.cloracion = (radioButton1.Checked ? 1 : 0);
                CacheFormsRestaurante.fecha = DateTime.Now;
                CacheFormsRestaurante.hora = DateTime.Now;
                //Llamamos al metodo para subir los datos a la base de datos
                ConexionBD_Restaruante.SubirDatos();
                ExportacionFinal exportacionFinal = new ExportacionFinal();
                exportacionFinal.Show();
                this.Close();
            }
        }

    }
}
