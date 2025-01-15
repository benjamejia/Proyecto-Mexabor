using System;
using System.Windows.Forms;

namespace App
{
    public partial class FormPersonal : Form
    {
        public bool Checado = false;
        public bool SegundoChecado = false;
        public bool TercerChecado = false;
        public bool CuartoChecado = false;

        public FormPersonal()
        {
            InitializeComponent();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            personalPlanchas();
            PersonalAseo();
            PersonalLoza();
            PersonalTortillas();

            if (Checado == true && SegundoChecado == true && TercerChecado == true && CuartoChecado == true)
            {
                FormPersonal2 formPersonal2 = new FormPersonal2();
                formPersonal2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hay opciones sin seleccionar.");
            }
        }

        private void btn_aterior_Click(object sender, EventArgs e)
        {
            FormJuegos formJuegos = new FormJuegos();
            formJuegos.Show();
            this.Hide();
        }
        public void personalPlanchas()
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
                        DataForms.personalPlanchas[index] = "1";
                    }
                    else
                    {
                        DataForms.personalPlanchas[index] = "0";
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

        public void PersonalAseo()
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
                        DataForms.personaAseo[index] = "1";
                    }
                    else
                    {
                        DataForms.personaAseo[index] = "0";
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

        public void PersonalLoza()
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
                        DataForms.personalLoza[index] = "1";
                    }
                    else
                    {
                        DataForms.personalLoza[index] = "0";
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

        public void PersonalTortillas()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r43, r44, r45, r46, r47, r48, r49, r50, r51, r52, r53, r54, r55, r56 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.personalTortilla[index] = "1";
                    }
                    else
                    {
                        DataForms.personalTortilla[index] = "0";
                    }
                    CuartoChecado = true;
                }
                else
                {
                    CuartoChecado = false;
                    break;
                }
            }
        }

        private void FormAreLoza_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = {r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,r21,r22,r23,r24,r25,r26,r27,r28,
               r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42,r43,r44,r45,r46,r47,r48,r49,r50,r51,r52 ,r53,r54,r55,r56};
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].TabIndex = i;
            }
            GroupBox[] groupBox = { estructura1, estructura2, estructura3, estructura4, estructura5, estructura6, estructura7, estructura8, estructura9, estructura10, estructura11, estructura12, estructura13, estructura14, limpieza2, limpieza3, limpieza4, limpieza5, limpieza6, limpieza7, limpieza8, limpieza9, limpieza10, limpieza11, limpieza12, limpieza13 };
            for (int i = 0; i < groupBox.Length; i++)
            {
                groupBox[i].TabIndex = i;
            }
            // Personal Planchas
            RadioButton[] radioButtonsPersonalPlanchas = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14 };

            for (int i = 0; i < radioButtonsPersonalPlanchas.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.personalPlanchas[index] == "1")
                {
                    radioButtonsPersonalPlanchas[i].Checked = true;
                }
                else if (DataForms.personalPlanchas[index] == "0")
                {
                    radioButtonsPersonalPlanchas[i + 1].Checked = true;
                }
            }
            //Personal Aseo
            RadioButton[] radioButtonsPersonalAseo = { r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28 };

            for (int i = 0; i < radioButtonsPersonalAseo.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.personaAseo[index] == "1")
                {
                    radioButtonsPersonalAseo[i].Checked = true;
                }
                else if (DataForms.personaAseo[index] == "0")
                {
                    radioButtonsPersonalAseo[i + 1].Checked = true;
                }
            }
            //Personal Loza
            RadioButton[] radioButtonsPersonalLoza = { r29, r30, r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41, r42 };

            for (int i = 0; i < radioButtonsPersonalLoza.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.personalLoza[index] == "1")
                {
                    radioButtonsPersonalLoza[i].Checked = true;
                }
                else if (DataForms.personalLoza[index] == "0")
                {
                    radioButtonsPersonalLoza[i + 1].Checked = true;
                }
            }

            //Personal Tortilla
            RadioButton[] radioButtonsPersonalTortilla = { r43, r44, r45, r46, r47, r48, r49, r50, r51, r52, r53, r54, r55, r56 };

            for (int i = 0; i < radioButtonsPersonalTortilla.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.personalTortilla[index] == "1")
                {
                    radioButtonsPersonalTortilla[i].Checked = true;
                }
                else if (DataForms.personalTortilla[index] == "0")
                {
                    radioButtonsPersonalTortilla[i + 1].Checked = true;
                }
            }
        }

    }
}

