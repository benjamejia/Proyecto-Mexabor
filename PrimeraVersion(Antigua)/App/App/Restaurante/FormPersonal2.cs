using System;
using System.Windows.Forms;

namespace App
{
    public partial class FormPersonal2 : Form
    {
        public bool Checado = false;
        public bool SegundoChecado = false;
        public bool TercerChecado = false;
        public FormPersonal2()
        {
            InitializeComponent();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            personalBarra();
            PersonalServicio();
            PersonalMesas();

            if (Checado == true && SegundoChecado == true && TercerChecado == true)
            {
                FormVarios formVarios = new FormVarios();
                formVarios.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hay opciones sin seleccionar.");
            }
        }

        private void btn_aterior_Click(object sender, EventArgs e)
        {
            FormPersonal formPersonal = new FormPersonal();
            formPersonal.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
        public void personalBarra()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14};

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.personalBarra[index] = "1";
                    }
                    else
                    {
                        DataForms.personalBarra[index] = "0";
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

        public void PersonalServicio()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.personalServicios[index] = "1";
                    }
                    else
                    {
                        DataForms.personalServicios[index] = "0";
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

        public void PersonalMesas()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r29, r30, r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41, r42 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.personalMesas[index] = "1";
                    }
                    else
                    {
                        DataForms.personalMesas[index] = "0";
                    }
                    TercerChecado = true;
                }
                else
                {
                    TercerChecado = false;
                    break;
                }

            }
        }

        private void FormPersonal2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormPersonal2_Load(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = {r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,r21,r22,r23,r24,r25,r26,r27,r28,
               r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42};
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].TabIndex = i;
            }
            GroupBox[] groupBox = { estructura1, estructura2, estructura3, estructura4, estructura5, estructura6, estructura7, estructura8, estructura9, estructura10, estructura11, estructura12, estructura13, estructura14, limpieza2, limpieza3, limpieza4, limpieza5, limpieza6, limpieza7, limpieza8 };
            for (int i = 0; i < groupBox.Length; i++)
            {
                groupBox[i].TabIndex = i;
            }
            // Personal Barra
            RadioButton[] radioButtonsPersonalBarra = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14 };

            for (int i = 0; i < radioButtonsPersonalBarra.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.personalBarra[index] == "1")
                {
                    radioButtonsPersonalBarra[i].Checked = true;
                }
                else if (DataForms.personalBarra[index] == "0")
                {
                    radioButtonsPersonalBarra[i + 1].Checked = true;
                }
            }
            //Personal Servicio
            RadioButton[] radioButtonsPersonalServicio = { r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28 };

            for (int i = 0; i < radioButtonsPersonalServicio.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.personalServicios[index] == "1")
                {
                    radioButtonsPersonalServicio[i].Checked = true;
                }
                else if (DataForms.personalServicios[index] == "0")
                {
                    radioButtonsPersonalServicio[i + 1].Checked = true;
                }
            }
            //Personal Mesa
            RadioButton[] radioButtonsPersonalMesa = { r29, r30, r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41, r42 };

            for (int i = 0; i < radioButtonsPersonalMesa.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.personalMesas[index] == "1")
                {
                    radioButtonsPersonalMesa[i].Checked = true;
                }
                else if (DataForms.personalMesas[index] == "0")
                {
                    radioButtonsPersonalMesa[i + 1].Checked = true;
                }
            }

        }
    }
}
