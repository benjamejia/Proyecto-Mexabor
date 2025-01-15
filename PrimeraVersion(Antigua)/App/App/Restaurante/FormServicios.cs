using System;
using System.Windows.Forms;

namespace App
{
    public partial class FormServicios : Form
    {
        public bool Checado = false;
        public bool SegundoChecado = false;
        public FormServicios()
        {
            InitializeComponent();
        }

        public void servicioEstructura()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14, r15, r16, r17, r18};

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.serviciosEstructura[index] = "1";
                    }
                    else
                    {
                        DataForms.serviciosEstructura[index] = "0";
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

        public void servicioLimpieza()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = {r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,
                r29,r30,r31,r32,r33,r34,r35,r36};

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.serviciosLimpieza[index] = "1";
                    }
                    else
                    {
                        DataForms.serviciosLimpieza[index] = "0";
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

        private void button1_Click(object sender, EventArgs e)
        {
            servicioEstructura();
            servicioLimpieza();

            if (Checado == true && SegundoChecado == true)
            {
                FormPlanchas formPlanchas = new FormPlanchas();
                formPlanchas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hay opciones sin seleccionar.");
            }
        }
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            FormTortillas formTortillas = new FormTortillas();
            this.Hide();
            formTortillas.Show();
        }

        private void FormServicios_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormServicios_Load(object sender, EventArgs e)
        {
            // Restaura el estado de los RadioButtons para la estructura
            RadioButton[] radioButtonsEstructura = {r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14, r15, r16, r17, r18};

            for (int i = 0; i < radioButtonsEstructura.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.serviciosEstructura[index] == "1")
                {
                    radioButtonsEstructura[i].Checked = true;
                }
                else if (DataForms.serviciosEstructura[index] == "0")
                {
                    radioButtonsEstructura[i + 1].Checked = true;
                }
            }

            // Restaura el estado de los RadioButtons para la limpieza
            RadioButton[] radioButtonsLimpieza = {r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,
                r29,r30,r31,r32,r33,r34,r35,r36 };

            for (int i = 0; i < radioButtonsLimpieza.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.serviciosLimpieza[index] == "1")
                {
                    radioButtonsLimpieza[i].Checked = true;
                }
                else if (DataForms.serviciosLimpieza[index] == "0")
                {
                    radioButtonsLimpieza[i + 1].Checked = true;
                }
            }
        }
    }
}
