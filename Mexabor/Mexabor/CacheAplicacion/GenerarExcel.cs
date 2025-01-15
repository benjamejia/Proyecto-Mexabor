using System.Diagnostics;
using System.Text;
using OfficeOpenXml;
using Syncfusion.XlsIO;
using Syncfusion.Pdf;
using Syncfusion.XlsIORenderer;

namespace Mexabor.CacheAplicacion
{
    public class GenerarExcel
    {
        /*static public void LlenarExcel()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Configura el filtro para el tipo de archivo Excel
                saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel modificado";

                // Mostrar el cuadro de diálogo para seleccionar la ubicación de guardado
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;  // Ruta donde el usuario desea guardar el archivo

                    // Ruta del archivo original (el que estás modificando)
                    string modifiedFilePath = Path.Combine(Directory.GetCurrentDirectory(), "CacheAplicacion", "FormatoReporte.xlsx");

                    // Verificar si el archivo existe
                    if (File.Exists(modifiedFilePath))
                    {
                        try
                        {
                            // Abrir el archivo Excel usando ClosedXML
                            using (var workbook = new XLWorkbook(modifiedFilePath))
                            {
                                // Obtener la primera hoja
                                var worksheet = workbook.Worksheet(1);

                                // Obtener la fecha actual
                                DateTime ahoraFecha = DateTime.Now;
                                string soloFecha = "Fecha " + ahoraFecha.ToString("yyyy-MM-dd");  // Formato de solo fecha
                                worksheet.Cell("H2").Value = soloFecha;  // Establecer el valor en la celda H2

                                // Establecer otros valores (como ejemplo, se establece "Patria" en la celda E3)
                                worksheet.Cell("E3").Value = "Patria";

                                // Guardar el archivo Excel en la ubicación seleccionada
                                workbook.SaveAs(filePath);

                                // Confirmar que el archivo se guardó con éxito
                                MessageBox.Show("Se ha creado el archivo Excel con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Mostrar el error en un MessageBox si algo falla al procesar el archivo
                            MessageBox.Show($"Error al llenar el archivo Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo de formato no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        */
        static public void ExcelTablaCompleta(DataGridView dataGridView1)
        {
            // Crear un OpenFileDialog para seleccionar la ubicación y nombre del archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = "NombreArchivo.xlsx"; // Nombre predeterminado
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                DialogResult result = saveFileDialog.ShowDialog();

                // Si el usuario selecciona un archivo y hace clic en Guardar
                if (result == DialogResult.OK)
                {
                    // Ruta donde se guardará el archivo Excel
                    string timestamp = DateTime.Today.ToString();
                    string filePath = saveFileDialog.FileName;
                    // Crear un nuevo archivo de Excel utilizando EPPlus
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Datos");

                        // Encabezados
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                        }

                        // Datos
                        for (int row = 0; row < dataGridView1.Rows.Count; row++)
                        {
                            for (int col = 0; col < dataGridView1.Columns.Count; col++)
                            {
                                worksheet.Cells[row + 2, col + 1].Value = dataGridView1.Rows[row].Cells[col].Value;
                            }
                        }

                        // Autoajustar las columnas
                        worksheet.Cells.AutoFitColumns();

                        // Guardar el archivo Excel
                        FileInfo excelFile = new FileInfo(filePath);
                        package.SaveAs(excelFile);

                    }

                    MessageBox.Show("Archivo Excel creado exitosamente en: " + filePath);


                    try
                    {
                        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al intentar abrir el archivo Excel: " + ex.Message);
                    }
                }
            }
        }
        static public void ExportarDatosExcel()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel modificado";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Ruta del archivo Excel modificado (deberías tenerlo en una variable o haberlo modificado previamente)
                    string modifiedFilePath = Path.Combine(Directory.GetCurrentDirectory(),"CacheAplicacion", "FormatoReporte.xlsx");

                    // Cargar el archivo Excel
                    FileInfo fileInfo = new FileInfo(modifiedFilePath);
                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        // Obtener la primera hoja
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        //Fecha
                        worksheet.Cells["H2"].Value = "Fecha" + CacheFormsRestaurante.fecha.ToString("yyyy-MM-dd");
                        //Sucusal
                        worksheet.Cells["E3"].Value = CacheFormsRestaurante.sucursal;
                        int re1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27;
                        // Modificar las celdas incorrectas de las areas
                        worksheet.Cells["C10"].Value = re1 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D10"].Value = r2 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C12"].Value = r3 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D12"].Value = r4 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0)     * 10;
                        worksheet.Cells["E12"].Value = r5 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C14"].Value = r6 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D14"].Value = r7 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["E14"].Value = r8 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C16"].Value = r9 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D16"].Value = r10 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["E16"].Value = r11 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C18"].Value = r12 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D18"].Value = r13 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["E18"].Value = r14 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C20"].Value = r15 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D20"].Value = r16 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["E20"].Value = r17 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C22"].Value = r18 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D22"].Value = r19 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["E22"].Value = r20 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C24"].Value = r21 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D24"].Value = r22 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["E24"].Value = r23 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C26"].Value = r24 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["D26"].Value = r25 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;

                        worksheet.Cells["C28"].Value = r26 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        worksheet.Cells["C30"].Value = r27 = 100 - CacheFormsRestaurante.estacionamientoEstructura.Count(x => x == 0) * 10;
                        //trapos
                        worksheet.Cells["C68"].Value = CacheFormsRestaurante.traposCocina;
                        worksheet.Cells["D68"].Value = CacheFormsRestaurante.traposMesas;
                        worksheet.Cells["E68"].Value = CacheFormsRestaurante.traposBanios;
                        worksheet.Cells["F68"].Value = CacheFormsRestaurante.traposCaja;
                        //calificacion proovedores
                        worksheet.Cells["B57"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[0]);
                        worksheet.Cells["C57"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[1]);
                        worksheet.Cells["D57"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[2]);

                        worksheet.Cells["B59"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[3]);
                        worksheet.Cells["C59"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[4]);
                        worksheet.Cells["D59"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[5]);

                        worksheet.Cells["B61"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[6]);
                        worksheet.Cells["C61"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[7]);
                        worksheet.Cells["D61"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[8]);
                        worksheet.Cells["E61"].Value = Convert.ToInt32(CacheFormsRestaurante.calificacionProveedores[9]);

                        // Asignar valores a las celdas
                        worksheet.Cells["C42"].Value = CacheFormsRestaurante.temperatura[0];
                        worksheet.Cells["C43"].Value = CacheFormsRestaurante.temperatura[1];
                        worksheet.Cells["C44"].Value = CacheFormsRestaurante.temperatura[2];
                        worksheet.Cells["C45"].Value = CacheFormsRestaurante.temperatura[3];
                        worksheet.Cells["C46"].Value = CacheFormsRestaurante.temperatura[4];
                        worksheet.Cells["C47"].Value = CacheFormsRestaurante.temperatura[5];
                        //Cloracion
                        worksheet.Cells["G47"].Value = CacheFormsRestaurante.cloracion == 1 ? "bien" : "mal";
                        //Observaciones
                        worksheet.Cells["C71"].Value = CacheFormsRestaurante.observaciones[0];
                        worksheet.Cells["C77"].Value = CacheFormsRestaurante.observaciones[1];
                        worksheet.Cells["C83"].Value = CacheFormsRestaurante.observaciones[2];
                        worksheet.Cells["C89"].Value = CacheFormsRestaurante.observaciones[3];
                        worksheet.Cells["C95"].Value = CacheFormsRestaurante.observaciones[4];
                        worksheet.Cells["C103"].Value = CacheFormsRestaurante.observaciones[5];
                        worksheet.Cells["C109"].Value = CacheFormsRestaurante.observaciones[6];
                        worksheet.Cells["C115"].Value = CacheFormsRestaurante.observaciones[7];
                        worksheet.Cells["C121"].Value = CacheFormsRestaurante.observaciones[8];
                        worksheet.Cells["C127"].Value = CacheFormsRestaurante.observaciones[9];
                        worksheet.Cells["C133"].Value = CacheFormsRestaurante.observaciones[10];

                        for (int i = 0; i < CacheFormsRestaurante.sabor.Count && i < 6; i++)
                        {
                            string cellAddress = $"D{42 + i}"; // Genera dinámicamente las celdas D42 a D47
                            worksheet.Cells[cellAddress].Value = CacheFormsRestaurante.sabor[i] == 1 ? "Bien" : "Mal";
                        }
                        //Porcentaje de Sabores
                        // Define los valores de sabor
                        // Crear una lista para almacenar si el sabor es bueno (1) o malo (0)
                        List<bool> resultadosSabor = new List<bool>();
                        foreach (var item in CacheFormsRestaurante.sabor)
                        {
                            for (int i = 0; i < CacheFormsRestaurante.sabor.Count; i++)
                            {
                                resultadosSabor.Add(CacheFormsRestaurante.sabor[i] == 1);
                            }
                        }
                        // Calcular el porcentaje de sabores buenos
                        double porcentajeBien = Math.Round((double)resultadosSabor.Count(x => x) / CacheFormsRestaurante.sabor.Count * 100);
                        // Mostrar el porcentaje (puedes guardar este valor o mostrarlo según lo necesites)
                        Console.WriteLine($"Porcentaje de sabores buenos: {porcentajeBien:F2}%");

                        // Aquí puedes guardar el porcentaje en el lugar que necesites, por ejemplo:
                        worksheet.Cells["D48"].Value = $"{Math.Round(porcentajeBien)}%"; // Asigna el porcentaje a una celda específica en el Excel
                        //Checks
                        worksheet.Cells["I47"].Value = $"{CacheFormsRestaurante.documentos.Count(x => x == 1)} de 5";
                        //Manifestos
                        worksheet.Cells["H47"].Value = CacheFormsRestaurante.documentos[4] == 1 ? "bien" : "mal";

                        MessageBox.Show("El archivo se ha guardado exitosamente en la ubicación seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FileInfo newFile = new FileInfo(filePath);
                        package.SaveAs(newFile);
                        ConvertirExcelAPdf(filePath);
                    }
                }
            }
        }
        static public void ConvertirExcelAPdf(string excelFilePath)
        {
            // Inicializar el ExcelEngine y la aplicación
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;

                // Abrir el archivo Excel desde la ruta proporcionada
                using (FileStream excelStream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = application.Workbooks.Open(excelStream);

                    // Inicializar el renderizador de XlsIO
                    XlsIORenderer renderer = new XlsIORenderer();

                    // Convertir el documento Excel a un documento PDF
                    PdfDocument pdfDocument = renderer.ConvertToPDF(workbook);

                    // Usar un cuadro de diálogo para permitir que el usuario elija la ruta para guardar el archivo PDF
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar PDF";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        // Guardar el archivo PDF en la ruta seleccionada
                        using (FileStream pdfStream = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write))
                        {
                            pdfDocument.Save(pdfStream);
                        }

                        MessageBox.Show("Archivo PDF guardado correctamente en: " + pdfFilePath);
                    }

                    // Cerrar el documento PDF
                    pdfDocument.Close();
                }
            }
        }
    }
}
