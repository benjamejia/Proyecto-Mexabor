using Mexabor.CacheAplicacion;
using System.Windows.Forms;

namespace Mexabor
{
    public partial class Form1Estacionamiento : Form
    {
        public Form1Estacionamiento()
        {
            InitializeComponent();
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
            CacheFormsRestaurante.estacionamientoEstructura = ObtenerValoresDeCheckBox(t1);
            CacheFormsRestaurante.estacionamientoLimpieza = ObtenerValoresDeCheckBox(t2);
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
        public void SiguienteForm()
        {
            //Este metodo obtiene las repsuestas emitidas por el usausrio haciendo dos instancias de los nombres de los tableLayoutPanel's
            ObtenerRespuestas(tlpEstructura,tlpLimpieza);
            CacheFormsRestaurante.sucursal = txbSucursal.Text;
            CacheFormsRestaurante.auditor = txbAuditor.Text;
            CacheFormsRestaurante.gerente = txbGerente.Text;
            //Muestra el siguiente form
            Form2Comedor formComedor = new Form2Comedor();
            formComedor.Show();
            this.Close();
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
                SiguienteForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void Form1Estacionamiento_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
