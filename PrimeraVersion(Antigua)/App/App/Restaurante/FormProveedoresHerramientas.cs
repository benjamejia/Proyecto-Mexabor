using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace App
{
    public partial class FormProveedoresHerramientas : Form
    {
        public bool Checado = false;
        public bool SegundoChecado = false;
        public FormProveedoresHerramientas()
        {
            InitializeComponent();
        }
        private void btn_aterior_Click(object sender, EventArgs e)
        {
            FormVarios formVarios = new FormVarios();
            formVarios.Show();
            this.Hide();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            proveedor();
            herramienta();

            if (Checado == true && SegundoChecado == true)
            {
                FormAgua formAgua = new FormAgua();
                formAgua.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hay opciones sin seleccionar.");
            }
        }

        public void proveedor()
        {
            ComboBox[] comboBoxes = { cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10 };
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (comboBoxes[i].Text != string.Empty)
                {
                    DataForms.calificacionProovedores[i] = comboBoxes[i].Text;
                    Checado = true;
                }
                else
                {
                    Checado = false;
                    break;
                }
            }
        }

        public void herramienta()
        {
            /*
             * Solo se agarran los valores del 1 al 2 de herramienta, los otros 4 pertenecen a trapos.
             */
            NumericUpDown[] numericHerramienta = { n1, n2, n3, n4, n5, n6 };
            for (int i = 0;i < numericHerramienta.Length; i++) {
                DataForms.herramienta[i] = (int)numericHerramienta[i].Value;
            }
            DataForms.traposCocina = (int)n3.Value;
            DataForms.traposMesas = (int)n4.Value;
            DataForms.traposBanios = (int)n5.Value;
            DataForms.traposCaja = (int)n6.Value;
            SegundoChecado = true;
        }

        private void FormProveedoresHerramientas_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verificar si el motivo del cierre es debido a un clic en el botón de cerrar
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar? La información se perderá.",
                                                       "Confirmar cierre",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);
                // Si el usuario elige No, cancelar el cierre del formulario
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void cb1_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;
        }

        private void n1_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            if (nud != null)
            {
                if (nud.Value < 0)
                {
                    // Mostrar un mensaje de error o ajustar el valor a 0
                    nud.Value = 0;
                }
            }
        }

        private void FormProveedoresHerramientas_Load(object sender, EventArgs e)
        {
            ComboBox[] comboBoxesCalificacion = { cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10,cb11 };
            for (int i = 0; i < comboBoxesCalificacion.Length; i++)
            {
                comboBoxesCalificacion[i].Text = DataForms.calificacionProovedores[i];
            }
            //Aqui cargams los valores de herramienta en la posicion 0 que es la 1 en la parte visual
            //y ponemos el vaor de trapos uno por uno ya que son valores distintos.
            NumericUpDown[] numericHerramienta = { n1, n2, n3, n4, n5, n6 };
            for (int i = 0;i < numericHerramienta.Length; i++)
            {
                DataForms.herramienta[i] = (int)numericHerramienta[i].Value;
            }
            numericHerramienta[2].Value = DataForms.traposCocina;
            numericHerramienta[3].Value = DataForms.traposMesas;
            numericHerramienta[4].Value = DataForms.traposBanios;
            numericHerramienta[5].Value = DataForms.traposCaja;
            NumericUpDown[] numericUps = { n1, n2, n3, n4, n5, n6 };
            for (int i = 0; i < numericUps.Length; i++)
            {
                numericUps[i].Maximum = 9;
            }

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        public void VerificarObservacion()
        {
            ComboBox[] comboBoxes = { cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10,cb11 };
            Label[] labels = { l1, l2, l3, l4, l5, l6, l7, l8, l9, l10,lbl11 };
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (comboBoxes[i].Text == "10" || comboBoxes[i].Text == string.Empty)
                {
                    labels[i].Visible = false;
                }
                else if (comboBoxes[i].Text != "10" && comboBoxes[i].Text != string.Empty)
                {
                    labels[i].Visible = true;
                }
            }
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void cb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void cb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void cb6_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void cb7_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void cb8_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void cb9_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void cb10_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void l1_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Gas";
        }

        private void l2_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Fumigacion";
        }

        private void l3_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Trampa de Gas";
        }

        private void l4_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Filete";
        }

        private void l5_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Masa y Tortillas";
        }

        private void l6_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Postres";
        }

        private void l7_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Refresco";
        }

        private void l8_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Cerveza";
        }

        private void l9_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Almacen";
        }

        private void l10_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Basura";
        }

        private bool allowKeyPress = true;



        private void label14_Click(object sender, EventArgs e)
        {
            Observacion.Visible = true;
            lbl_observacion.Text = "Observacion Mantenimiento";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarObservacion();
        }

        private void guardar_Click_1(object sender, EventArgs e)
        {

            if (lbl_observacion.Text == "Observacion Gas")
            {
                DataForms.observacionGas = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Fumigacion")
            {
                DataForms.observacionFumigacion = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Trampa de Gas")
            {
                DataForms.observacionTrampa = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Filete")
            {
                DataForms.observacionFilete = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Masa y Tortillas")
            {
                DataForms.observacionMasa = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Postres")
            {
                DataForms.observacionPostres = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Refresco")
            {
                DataForms.observacionRefresco = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Cerveza")
            {
                DataForms.observacionCerveza = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Almacen")
            {
                DataForms.observacionAlmacen = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Basura")
            {
                DataForms.observacionBasura = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }
            else if (lbl_observacion.Text == "Observacion Mantenimiento")
            {
                DataForms.observacionMantenimiento = richTextBox.Text;
                MessageBox.Show("Observacion Guardada con exito!");
                Observacion.Visible = false;
                richTextBox.Text = string.Empty;
            }

            Observacion.Visible = false;
            ComboBox[] comboBoxes = { cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10, cb11 };
            Label[] labels = { l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, lbl11 };
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].Enabled = true;
                labels[i].Enabled = true;
            }
            btn_aterior.Enabled = true;
            btn_siguiente.Enabled = true;
        }

        private void cancelar_Click_1(object sender, EventArgs e)
        {
            Observacion.Visible = false;
            richTextBox.Text = string.Empty;
        }

        private void richTextBox_TextChanged_1(object sender, EventArgs e)
        {

            if (richTextBox.Text.Length >= 200)
            {
                MessageBox.Show("Se ha alcanzado el maximo de caracteres permitidos");
                allowKeyPress = false;
            }
            else
            {
                // Permite la entrada de texto si el texto es menor a 100 caracteres
                allowKeyPress = true;
            }
        }

        private void richTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!allowKeyPress)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

    }
}
