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
        public AlmaSalida()
        {
            InitializeComponent();

            RestaurarValoresDeCheckBox(CacheFormsAlmacen.salidaEstructura, tlpE);
            RestaurarValoresDeCheckBox(CacheFormsAlmacen.salidaLimpieza, tlpL);
        }
        private void RestaurarValoresDeCheckBox(List<int> valores, TableLayoutPanel tableLayout)
        {
            int index = 0;

            for (int fila = 0; fila < tableLayout.RowCount; fila++)
            {
                for (int columna = 0; columna < tableLayout.ColumnCount; columna++)
                {
                    Control control = tableLayout.GetControlFromPosition(columna, fila);

                    if (control is CheckBox checkBox)
                    {
                        // Verificamos si hay un valor disponible en la lista para restaurar
                        if (index < valores.Count)
                        {
                            checkBox.Checked = valores[index] == 1; // Restaurar el estado del CheckBox
                            index++;
                        }
                    }
                }
            }
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
            CacheFormsAlmacen.salidaEstructura = ObtenerValoresDeCheckBox(t1);
            CacheFormsAlmacen.salidaLimpieza = ObtenerValoresDeCheckBox(t2);
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
        private void button1_Click(object sender, EventArgs e)
        {
            //Condicionales para los campos de texto.
            if (string.IsNullOrEmpty(txbAuditor.Text) || string.IsNullOrEmpty(txbGerente.Text))
            {
                lblAviso.Visible = true;
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            else
            {
                lblAviso.Visible = false;
                ObtenerRespuestas(tlpE, tlpL);
                //Asignamos los valores de los campos de texto a rellenar.
                CacheFormsAlmacen.sucursal = "Patria";
                CacheFormsAlmacen.gerente = txbGerente.Text;
                CacheFormsAlmacen.auditor = txbAuditor.Text;
                CacheFormsAlmacen.auditoriaEmpezada = true;
                Alma2CocinaCaliente almaCocinaCalient = new Alma2CocinaCaliente();
                almaCocinaCalient.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void r5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AlmaSalida_Load(object sender, EventArgs e)
        {
            txbAuditor.Text = CacheUsuario.usuario;
            txbGerente.Text = CacheFormsAlmacen.gerente;
        }

        private void cbxMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            MarcarTodo(this.Controls);
        }

        private void AlmaSalida_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void AlmaSalida_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verificamos si la causa del cierre es la "X" o si el usuario está cerrando el formulario explícitamente.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Mostrar la alerta solo si el usuario está intentando cerrar el formulario
                DialogResult opcion = MessageBox.Show("¿Estás seguro que deseas cerrar el formulario?\nSe perderá el progreso no guardado.", "Cerrar formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Si el usuario cancela el cierre, evitamos que el formulario se cierre
                if (opcion == DialogResult.No)
                {
                    e.Cancel = true;
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                    this.Hide();
                }
                else
                {
                    // Si el usuario acepta, permitimos que el formulario se cierre
                    e.Cancel = false;
                }
            }
        }
    }
}
