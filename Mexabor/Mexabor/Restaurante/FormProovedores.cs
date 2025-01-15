using Mexabor.CacheAplicacion;
using System.Data;
using System.Windows.Forms;

namespace Mexabor
{
    public partial class FormProovedores : Form
    {
        private List<int> calificaciones = new List<int>();
        private List<int> herramienta = new List<int>();
        public int[] valores = { 1,2,3,4,5,6,7,8,9,10 };
        public FormProovedores()
        {
            InitializeComponent();
        }
        public void VerificarCampos()
        {
            if (txtObersavacion.Text == string.Empty)
            {
                MessageBox.Show("Los campos no pueden ir vacios");
                return;
            }
            else
            {
                CacheFormsRestaurante.observaciones[cbProveedores.SelectedIndex] = txtObersavacion.Text;
                MessageBox.Show($"Se agrego la observacion del proveedor {cbProveedores.Text} con exíto");
                txtObersavacion.Text = string.Empty;
                Console.WriteLine(CacheFormsRestaurante.observaciones[cbProveedores.SelectedIndex]);
            }
        }

        private void btnAgregarObersavaciones_Click(object sender, EventArgs e)
        {
            switch (cbProveedores.SelectedIndex)
            {
                case 0:
                    VerificarCampos();
                    break;
                case 1:
                    VerificarCampos();
                    break;
                case 2:
                    VerificarCampos();
                    break;
                case 3:
                    VerificarCampos();
                    break;
                case 4:
                    VerificarCampos();
                    break;
                case 5:
                    VerificarCampos();
                    break;
                case 6:
                    VerificarCampos();
                    break;
                case 7:
                    VerificarCampos();
                    break;
                case 8:
                    VerificarCampos();
                    break;
                case 9:
                    VerificarCampos();
                    break;
                case 10:
                    VerificarCampos();
                    break;
                default:
                    break;
            }
        }

        private void VerificarCalificaciones(Control.ControlCollection controls)
        {
            var orderedControls = controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList();
            foreach (Control control in orderedControls)
            {
                // Verificar si el control es un Combobox
                if (control is ComboBox comboBox)
                {
                    calificaciones.Add(int.Parse(comboBox.Text));
                }
            }
        }
        private void VerificarHerramienta(Control.ControlCollection controls)
        {
            var orderedControls = controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList();
            foreach (Control control in orderedControls)
            {
                if (control is TableLayoutPanel tableLayout)
                {
                    // Recorrer los controles dentro del TableLayoutPanel
                    foreach (Control cellControl in tableLayout.Controls)
                    {
                        // Verificar si el control es un CheckBox
                        if (cellControl is NumericUpDown numericUpDown)
                        {
                            // Agregar 1 o 0 según el estado del CheckBox
                            herramienta.Add((int)numericUpDown.Value);
                        }
                    }
                }
            }
            NumericUpDown[] numericHerramienta = { n1, n2, n3, n4, n5, n6 };
            CacheFormsRestaurante.traposCocina = (int)n3.Value;
            CacheFormsRestaurante.traposMesas = (int)n4.Value;
            CacheFormsRestaurante.traposBanios = (int)n5.Value;
            CacheFormsRestaurante.traposCaja = (int)n6.Value;
        }
        private void FormProovedores_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Estas seguro que deseas continuar?\n Asegurate de que las opciones esten correctamente seleccionadas", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                //Limpiamos la memoria almacenadas en las listas
                CacheFormsRestaurante.herramienta.Clear();
                CacheFormsRestaurante.calificacionProveedores.Clear();
                VerificarCalificaciones(this.Controls);
                VerificarHerramienta(this.Controls);
                //Agregar el valor de la lista elemetnos a las listas
                CacheFormsRestaurante.herramienta = herramienta;
                CacheFormsRestaurante.calificacionProveedores = calificaciones;
                FormTemperaturas formTemperaturas = new FormTemperaturas();
                formTemperaturas.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVarios formVarios = new FormVarios();
            formVarios.Show();
            this.Close();
        }
        
        private void txtObersavacion_TextChanged(object sender, EventArgs e)
        {
            const int maxCaracteres = 200;

            if (txtObersavacion.Text.Length > maxCaracteres)
            {
                // Si se excede el límite, recortar el texto y notificar al usuario si es necesario
                txtObersavacion.Text = txtObersavacion.Text.Substring(0, maxCaracteres);
                txtObersavacion.SelectionStart = txtObersavacion.Text.Length; // Mantener el cursor al final
            }
        }
    }
}
