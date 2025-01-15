using System;
using System.Windows.Forms;

namespace App
{
    public partial class FormBaños : Form
    {
        public bool Checado = false;
        public bool SegundoChecado = false;
        public FormBaños()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormAreLoza formLoza = new FormAreLoza();
            formLoza.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bañosEstructura();
            bañosLimpieza();

            if (Checado == true && SegundoChecado == true)
            {
                FormJuegos formJuegos = new FormJuegos();
                this.Hide();
                formJuegos.Show();
            }
            else
            {
                MessageBox.Show("Hay opciones sin seleccionar.");
            }
        }
        public void bañosEstructura()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14, r15, r16, r17, r18, r19, r20,r21,r22,r23,r24,r25,r26};

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.bañosEstructura[index] = "1";

                    }
                    else
                    {
                        DataForms.bañosEstructura[index] = "0";
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
        public void bañosLimpieza()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = {r27,r28,
                r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42,r43,r44,r45,r46,r47,r48,r49,r50};

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)

                    {
                        DataForms.bañosLimpieza[index] = "1";
                    }
                    else
                    {
                        DataForms.bañosLimpieza[index] = "0";
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
        private void FormBaños_FormClosing(object sender, FormClosingEventArgs e)
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
        private void FormBaños_Load(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = {r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,r21,r22,r23,r24,r25,r26,r27,r28,
               r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42,r43,r44,r45,r46,r47,r48,r49,r50};
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].TabIndex = i;
            }
            GroupBox[] groupBox = { estructura1, estructura2, estructura3, estructura4, estructura5, estructura6, estructura7, estructura8, estructura9, estructura10, estructura11, estructura12, estructura13, limpieza1, limpieza2, limpieza3, limpieza4, limpieza5, limpieza6, limpieza7, limpieza8, limpieza9, limpieza10, limpieza11, limpieza12 };
            for (int i = 0; i < groupBox.Length; i++)
            {
                groupBox[i].TabIndex = i;
            }
            // Restaura el estado de los RadioButtons para la estructura
            RadioButton[] radioButtonsEstructura = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14, r15, r16, r17, r18, r19, r20,r21,r22,r23,r24,r25,r26};

            for (int i = 0; i < radioButtonsEstructura.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.bañosEstructura[index] == "1")
                {
                    radioButtonsEstructura[i].Checked = true;
                }
                else if (DataForms.bañosEstructura[index] == "0")
                {
                    radioButtonsEstructura[i + 1].Checked = true;
                }
            }

            // Restaura el estado de los RadioButtons para la limpieza
            RadioButton[] radioButtonsLimpieza = {r27,r28,
                r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42,r43,r44,r45,r46,r47,r48,r49,r50};

            for (int i = 0; i < radioButtonsLimpieza.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.bañosLimpieza[index] == "1")
                {
                    radioButtonsLimpieza[i].Checked = true;
                }
                else if (DataForms.bañosLimpieza[index] == "0")
                {
                    radioButtonsLimpieza[i + 1].Checked = true;
                }
            }
        }
    }
}
