using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;


namespace App
{
    public partial class FormEstacionamiento : Form
    {
        public bool Checado = false;
        public bool SegundoChecado = false;
        // En la clase del formulario

        public FormEstacionamiento()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
        }
        public void ExcelCancelado()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel modificado";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Ruta del archivo Excel modificado
                    string modifiedFilePath = Path.Combine(Directory.GetCurrentDirectory(), "FormatoReporte.xlsx");

                    // Cargar el archivo Excel
                    FileInfo fileInfo = new FileInfo(modifiedFilePath);
                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        // Obtener la primera hoja
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        worksheet.Cells["B33"].Value = $"La auditoría fue realizada por _____ el día {DateTime.Now}. La persona encargada de la sucursal en el momento que se realizó la auditoria y\n firmo de enterado fue __________. En caso de la negativa de firma o negación de acceso:\n  La persona que estaba a cargo en el momento y se negó a firmar de realizado o negó acceso fue: ___________________";

                        // Guardar los cambios en el nuevo archivo
                        package.SaveAs(new FileInfo(filePath));
                        MessageBox.Show("Guardado con exito");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu2 formMenu2 = new FormMenu2();
            formMenu2.Show();
            this.Hide();
        }
        private void VerificacionEstacionamientoEstructura()
        {
            RadioButton[] radioButtons = { rd1, rd2, rd3, rd4, rd5, rd6, rd7, rd8, rd9, rd10, rd11, rd12, rd13, rd14, rd15, rd16, rd17, rd18, rd19, rd20 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;

                    if (radioButtons[i].Checked)
                    {
                        DataForms.estacionamientoEstructura[index] = "1";
                    }
                    else
                    {
                        DataForms.estacionamientoLimpieza[index] = "0";
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
        private void VerificacionEstacionamientoLimpieza()
        {
            RadioButton[] radioButtons = { rd21, rd22, rd23, rd24, rd25, rd26, rd27, rd28, rd29, rd30, rd31, rd32, rd33, rd34, rd35, rd36, rd37, rd38, rd39, rd40 };

            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.estacionamientoLimpieza[index] = "1";
                    }
                    else
                    {
                        DataForms.estacionamientoLimpieza[index] = "0";
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

        private void FormEstacionamiento_FormClosing(object sender, FormClosingEventArgs e)
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
        private void FormEstacionamiento_Load(object sender, EventArgs e)
        {
            txb_auditor.Text = DataForms.auditor;
            txb_encargado.Text = DataForms.encargado;
            txb_sucursal.Text = DataForms.sucursal;
            // Restaura el estado de los RadioButtons para la estructura
            RadioButton[] radioButtonsEstructura = { rd1, rd2, rd3, rd4, rd5, rd6, rd7, rd8, rd9, rd10, rd11, rd12, rd13, rd14, rd15, rd16, rd17, rd18, rd19, rd20 };

            for (int i = 0; i < radioButtonsEstructura.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.estacionamientoEstructura[index] == "1")
                {
                    radioButtonsEstructura[i].Checked = true;
                }
                else if (DataForms.estacionamientoEstructura[index] == "0")
                {
                    radioButtonsEstructura[i + 1].Checked = true;
                }
            }

            // Restaura el estado de los RadioButtons para la limpieza
            RadioButton[] radioButtonsLimpieza = { rd21, rd22, rd23, rd24, rd25, rd26, rd27, rd28, rd29, rd30, rd31, rd32, rd33, rd34, rd35, rd36, rd37, rd38, rd39, rd40 };

            for (int i = 0; i < radioButtonsLimpieza.Length; i += 2)
            {
                int index = i / 2;
                if (DataForms.estacionamientoLimpieza[index] == "1")
                {
                    radioButtonsLimpieza[i].Checked = true;
                }
                else if (DataForms.estacionamientoLimpieza[index] == "0")
                {
                    radioButtonsLimpieza[i + 1].Checked = true;
                }
            }
        }

        private void FormEstacionamiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {

            DataForms.LimpiarDatos();
            DataForms.encargado = txb_encargado.Text;
            DataForms.sucursal = txb_sucursal.Text;
            DataForms.auditor = txb_auditor.Text;
            DataForms.uno = true;

            VerificacionEstacionamientoEstructura();
            VerificacionEstacionamientoLimpieza();

            if (Checado == true && SegundoChecado == true && txb_auditor.Text != string.Empty && txb_encargado.Text != string.Empty && txb_sucursal.Text != string.Empty)
            {
                FormComedor comedorForm = new FormComedor();
                comedorForm.Show();
                this.Hide(); // Oculta el formulario actual
            }
            else
            {
                MessageBox.Show("Hay casillas sin seleccionar o rellenar.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExcelCancelado();
        }
    }

}
