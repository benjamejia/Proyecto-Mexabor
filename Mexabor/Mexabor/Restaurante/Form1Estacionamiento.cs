using Mexabor.CacheAplicacion;
using System.Windows.Forms;

namespace Mexabor
{
    public partial class Form1Estacionamiento : Form
    {
        private List<int> elementos = new List<int>();
        public Form1Estacionamiento()
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
        private void button1_Click(object sender, EventArgs e)
        {
            //Condicionales para los campos de texto.
            if (string.IsNullOrEmpty(txbAuditor.Text) || string.IsNullOrEmpty(txbGerente.Text) || string.IsNullOrEmpty(txbSucursal.Text))
            {
                lblAviso.Visible = true;
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            else { lblAviso.Visible = false; }

            //Opcion para poder verificar que el uuario selecciono las respuestas correctamente.
            DialogResult opcion = MessageBox.Show("¿Estas seguro que deseas continuar?\n Asegurate de que las opciones esten correctamente seleccionadas", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                //Limpia la lista principal donde se guardan las respeustas de los checks
                elementos.Clear();
                //Vuelve a llamar al metodo para verificar las respuestas.
                Verificar(this.Controls);
                /*Aqui se limpira y se guardan los elementos tomando la posicion 0 como 1,
                 * en caso de que se agreguen mas opciones, se debera cambiar manualmente este indice,
                 * en este caso se hace del 0 y el segundo parametro es el numero de opciones que quieres copiar.
                 */
                CacheFormsRestaurante.estacionamientoEstructura.Clear();
                CacheFormsRestaurante.estacionamientoLimpieza.Clear();
                int A = elementos.Count / 2;
                CacheFormsRestaurante.estacionamientoEstructura = elementos.GetRange(0, A);
                CacheFormsRestaurante.estacionamientoLimpieza = elementos.GetRange(A, A);
                //Asignamos los valores de los campos de texto a rellenar.
                CacheFormsRestaurante.sucursal = txbSucursal.Text;
                CacheFormsRestaurante.auditor = txbAuditor.Text;
                CacheFormsRestaurante.gerente = txbGerente.Text;
                //Muestra el siguiente form
                //Console.WriteLine(A);
                Form2Comedor formComedor = new Form2Comedor();
                formComedor.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show the Menu form and close the current form
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void FormEstacionamiento_Load(object sender, EventArgs e)
        {

        }

        private void cbxMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            MarcarTodo(this.Controls);
        }

        private void txbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int maxCaracteres = 10;

            if (txbSucursal.Text.Length > maxCaracteres)
            {
                // Si se excede el límite, recortar el texto y notificar al usuario si es necesario
                txbSucursal.Text = txbSucursal.Text.Substring(0, maxCaracteres);
                txbSucursal.SelectionStart = txbSucursal.Text.Length; // Mantener el cursor al final
            }
        }

        private void txbGerente_TextChanged(object sender, EventArgs e)
        {
            const int maxCaracteres = 10;

            if (txbGerente.Text.Length > maxCaracteres)
            {
                // Si se excede el límite, recortar el texto y notificar al usuario si es necesario
                txbGerente.Text = txbGerente.Text.Substring(0, maxCaracteres);
                txbGerente.SelectionStart = txbGerente.Text.Length; // Mantener el cursor al final
            }
        }

        private void txbAuditor_TextChanged(object sender, EventArgs e)
        {
            const int maxCaracteres = 10;

            if (txbAuditor.Text.Length > maxCaracteres)
            {
                // Si se excede el límite, recortar el texto y notificar al usuario si es necesario
                txbAuditor.Text = txbAuditor.Text.Substring(0, maxCaracteres);
                txbAuditor.SelectionStart = txbAuditor.Text.Length; // Mantener el cursor al final
            }
        }
    }
}
