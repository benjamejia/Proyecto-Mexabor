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
    public partial class AlmaSalida : Form
    {
        private List<int> elementos = new List<int>();
        public AlmaSalida()
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
        private void button1_Click(object sender, EventArgs e)
        {
            //Condicionales para los campos de texto.
            if (string.IsNullOrEmpty(txbAuditor.Text) || string.IsNullOrEmpty(txbGerente.Text) || string.IsNullOrEmpty(txbSucursal.Text))
            {
                lblAviso.Visible = true;
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            else
            {
                lblAviso.Visible = false;
                //Limpia la lista principal donde se guardan las respeustas de los checks
                elementos.Clear();
                //Vuelve a llamar al metodo para verificar las respuestas.
                Verificar(this.Controls);
                /*Aqui se limpira y se guardan los elementos tomando la posicion 0 como 1,
                 * en caso de que se agreguen mas opciones, se debera cambiar manualmente este indice,
                 * en este caso se hace del 0 y el segundo parametro es el numero de elementos que quieres copiar.
                 */
                CacheFormsAlmacen.salidaEstructura.Clear();
                CacheFormsAlmacen.salidaLimpieza.Clear();
                CacheFormsAlmacen.salidaEstructura = elementos.GetRange(0, 9);
                CacheFormsAlmacen.salidaLimpieza = elementos.GetRange(9, 6);
                //Asignamos los valores de los campos de texto a rellenar.
                CacheFormsAlmacen.sucursal = txbSucursal.Text;
                CacheFormsAlmacen.gerente = txbGerente.Text;
                CacheFormsAlmacen.auditor = txbAuditor.Text;

                Alma2CocinaCaliente almaCocinaCalient = new Alma2CocinaCaliente();
                almaCocinaCalient.Show();
                this.Close();
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
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void r5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AlmaSalida_Load(object sender, EventArgs e)
        {

        }

        private void cbxMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            MarcarTodo(this.Controls);
        }
    }
}
