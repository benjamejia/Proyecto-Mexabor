using System;
using System.Windows.Forms;

namespace App
{
    public partial class FormJuegos : Form
    {
        public bool Checado = false;
        public bool SegundoChecado = false;
        public FormJuegos()
        {
            InitializeComponent();
        }
        public void juegosEstructura()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.juegosEstructura[index] = "1";
                    }
                    else
                    {
                        DataForms.juegosEstructura[index] = "0";
                    }
                    Checado = true;
                }
                else
                {
                    Checado = false;
                    break;
                }

            }
        }

        public void juegosLimpieza()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r13, r14, r15, r16, r17, r18, r19, r20 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.juegosLimpieza[index] = "1";
                    }
                    else
                    {
                        DataForms.juegosLimpieza[index] = "0";
                    }
                    SegundoChecado = true;
                }
                else
                {
                    SegundoChecado = false;
                    break;
                }

            }
        }
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            FormBaños formBaños = new FormBaños();
            this.Hide();
            formBaños.Show();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            juegosEstructura();
            juegosLimpieza();

            if (Checado == true && SegundoChecado == true)
            {
                FormPersonal fomPersonal = new FormPersonal();
                this.Hide();
                fomPersonal.Show();
            }
            else
            {
                MessageBox.Show("Hay opciones sin seleccionar.");
            }
        }
        private void FormJuegos_FormClosing(object sender, FormClosingEventArgs e)
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
        private void FormJuegos_Load(object sender, EventArgs e)
        {
            // Restaura el estado de los RadioButtons para la estructura
            RadioButton[] radioButtonsEstructura = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12 };

            for (int i = 0; i < radioButtonsEstructura.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.juegosEstructura[index] == "1")
                {
                    radioButtonsEstructura[i].Checked = true;
                }
                else if (DataForms.juegosEstructura[index] == "0")
                {
                    radioButtonsEstructura[i + 1].Checked = true;
                }
            }

            // Restaura el estado de los RadioButtons para la limpieza
            RadioButton[] radioButtonsLimpieza = { r13, r14, r15, r16, r17, r18, r19, r20 };

            for (int i = 0; i < radioButtonsLimpieza.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.juegosLimpieza[index] == "1")
                {
                    radioButtonsLimpieza[i].Checked = true;
                }
                else if (DataForms.juegosLimpieza[index] == "0")
                {
                    radioButtonsLimpieza[i + 1].Checked = true;
                }
            }
        }
    }
}
