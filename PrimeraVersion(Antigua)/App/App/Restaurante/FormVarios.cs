using System;
using System.Windows.Forms;

namespace App
{
    public partial class FormVarios : Form
    {
        public bool Checado = false;
        public bool SegundoChecado = false;
        public bool TercerChecado = false;
        public bool CuartoChecado = false;

        public FormVarios()
        {
            InitializeComponent();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            caja();
            documentos();
            alamacen();
            ambiente();

            if (Checado == true && SegundoChecado == true && TercerChecado == true && CuartoChecado == true)
            {
                FormProveedoresHerramientas formProveedoresHerramientas = new FormProveedoresHerramientas();
                formProveedoresHerramientas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hay opciones sin seleccionar.");
            }

            if (r43.Checked)
            {
                DataForms.checkBaños = true;
            }else { DataForms.checkBaños = false; }
            if (r45.Checked) 
            {
                DataForms.checkPersonal = true;
            }else { DataForms.checkPersonal = false; }
            if (r47.Checked) 
            {
                DataForms.checkCocina = true;
            }else { DataForms.checkCocina = false; }
            if (r49.Checked)
            {
                DataForms.checkComedor = true;
            }else { DataForms.checkComedor = false; }
            if (r53.Checked)
            {
                DataForms.checkGerente = true;
            }else { DataForms.checkGerente = false; }
        }
        //Metodo para subir todo a la Base De Datos


        private void caja()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14, r15, r16, r17, r18,r19 , r20};

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.caja[index] = "1";
                    }
                    else
                    {
                        DataForms.caja[index] = "0";
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


        private void ambiente()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r21, r22, r23, r24, r25, r26 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.ambiente[index] = "1";
                    }
                    else
                    {
                        DataForms.ambiente[index] = "0";
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

        private void alamacen()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r27, r28, r29, r30, r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41, r42 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.almacen[index] = "1";
                    }
                    else
                    {
                        DataForms.almacen[index] = "0";
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

        private void documentos()
        {
            //For para verificar si hay alguna opcion en blanco.
            RadioButton[] radioButtons = { r43, r44, r45, r46, r47, r48, r49, r50, r51, r52, r53, r54 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.documentos[index] = "1";
                    }
                    else
                    {
                        DataForms.documentos[index] = "0";
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


        private void btn_aterior_Click(object sender, EventArgs e)
        {
            FormPersonal2 formPersonal2 = new FormPersonal2();
            formPersonal2.Show();
            this.Hide();
        }

        private void FormVarios_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormVarios_Load(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = {r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,r21,r22,r23,r24,r25,r26,r27,r28,
               r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42,r43,r44,r45,r46,r47,r48,r49,r50,r51,r52,r53,r54};
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].TabIndex = i;
            }
            GroupBox[] groupBox = { estructura1, estructura2, estructura3, estructura4, estructura5, estructura6, estructura7, estructura8, estructura9, estructura10, estructura11, estructura12, estructura13, limpieza3, limpieza4, limpieza5, limpieza6, limpieza7, limpieza8, limpieza9, limpieza10, limpieza11, limpieza12, limpieza13 };
            for (int i = 0; i < groupBox.Length; i++)
            {
                groupBox[i].TabIndex = i;
            }
            // Personal Cajas
            RadioButton[] radioButtonsCajas = {r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14, r15, r16, r17, r18, r19, r20};

            for (int i = 0; i < radioButtonsCajas.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.caja[index] == "1")
                {
                    radioButtonsCajas[i].Checked = true;
                }
                else if (DataForms.caja[index] == "0")
                {
                    radioButtonsCajas[i + 1].Checked = true;
                }
            }
            //Personal Ambiente
            RadioButton[] radioButtonsAmbiente = { r21, r22, r23, r24, r25, r26 };

            for (int i = 0; i < radioButtonsAmbiente.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.ambiente[index] == "1")
                {
                    radioButtonsAmbiente[i].Checked = true;
                }
                else if (DataForms.ambiente[index] == "0")
                {
                    radioButtonsAmbiente[i + 1].Checked = true;
                }
            }
            //Personal Almacen
            RadioButton[] radioButtonsAlmacen = { r27, r28, r29, r30, r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41, r42};

            for (int i = 0; i < radioButtonsAlmacen.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.almacen[index] == "1")
                {
                    radioButtonsAlmacen[i].Checked = true;
                }
                else if (DataForms.almacen[index] == "0")
                {
                    radioButtonsAlmacen[i + 1].Checked = true;
                }
            }
            //Personal Documentos
            RadioButton[] radioButtonsDocumentos = { r43, r44, r45, r46, r47, r48, r49, r50, r51 ,r52,r53,r54 };

            for (int i = 0; i < radioButtonsDocumentos.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.documentos[index] == "1")
                {
                    radioButtonsDocumentos[i].Checked = true;
                }
                else if (DataForms.documentos[index] == "0")
                {
                    radioButtonsDocumentos[i + 1].Checked = true;
                }
            }
           
            
        }
    }
}
