using System.Diagnostics;
using System.Text;
using OfficeOpenXml;
using Syncfusion.XlsIO;
using Syncfusion.Pdf;
using Syncfusion.XlsIORenderer;

namespace Mexabor.CacheAplicacion
{
    public class GenerarExcelRestaurante
    {
        static public void ExcelTablaDesglozada()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = "NombreArchivo.xlsx";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string modifiedFilePath = Path.Combine(Directory.GetCurrentDirectory(), "CacheAplicacion", "FormatoMexabor.xlsx");

                    using (ExcelPackage package = new ExcelPackage(new FileInfo(modifiedFilePath)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        // Información adicional
                        worksheet.Cells["B1"].Value = CacheFormsRestaurante.sucursal;
                        worksheet.Cells["B2"].Value = CacheFormsRestaurante.gerente;
                        worksheet.Cells["B3"].Value = CacheFormsRestaurante.auditor;
                        worksheet.Cells["B4"].Value = CacheFormsRestaurante.fecha;

                        // Datos por columna
                        var datosPorColumna = new Dictionary<int, List<int>>
                    {
                        { 3, CacheFormsRestaurante.estacionamientoEstructura },
                        { 4, CacheFormsRestaurante.estacionamientoLimpieza},
                        { 5, CacheFormsRestaurante.comedorEstructura },
                        { 6, CacheFormsRestaurante.comedorLimpieza },
                        { 7, CacheFormsRestaurante.barraEstructura },
                        { 8, CacheFormsRestaurante.barraLimpieza },
                        { 9, CacheFormsRestaurante.tortillasEstructura },
                        { 10, CacheFormsRestaurante.tortillasLimpieza },
                        { 11, CacheFormsRestaurante.serviciosEstructura },
                        { 12, CacheFormsRestaurante.serviciosLimpieza },
                        { 13, CacheFormsRestaurante.planchasEstructura },
                        { 14, CacheFormsRestaurante.planchasLimpieza },
                        { 15, CacheFormsRestaurante.lozaEstructura },
                        { 16, CacheFormsRestaurante.lozaLimpieza },
                        { 17, CacheFormsRestaurante.bañosEstructura },
                        { 18, CacheFormsRestaurante.bañosLimpieza },
                        { 19, CacheFormsRestaurante.juegosEstructura },
                        { 20, CacheFormsRestaurante.juegosLimpieza },
                        { 21, CacheFormsRestaurante.personalPlanchas },
                        { 22, CacheFormsRestaurante.personalAseo },
                        { 23, CacheFormsRestaurante.personalLoza },
                        { 24, CacheFormsRestaurante.personalTortillas },
                        { 25, CacheFormsRestaurante.personalBarra },
                        { 26, CacheFormsRestaurante.personalServicios },
                        { 27, CacheFormsRestaurante.personalMesas },
                        { 28, CacheFormsRestaurante.documentos },
                        { 29, CacheFormsRestaurante.almacen },
                        { 30, CacheFormsRestaurante.caja },
                        { 31, CacheFormsRestaurante.ambiente },
                        { 32, CacheFormsRestaurante.calificacionProveedores },
                        { 33, CacheFormsRestaurante.herramienta },
                        { 34, CacheFormsRestaurante.sabor },
                        { 35, CacheFormsRestaurante.temperatura },
                    };

                        foreach (var item in datosPorColumna)
                        {
                            RellenarDatos(worksheet, item.Key, 6, item.Value);
                        }

                        // Observaciones
                        var observaciones = new Dictionary<string, string>
                    {
                        { "AU6", CacheFormsRestaurante.observaciones[0] },
                        { "AU7", CacheFormsRestaurante.observaciones[1] },
                        { "AU8", CacheFormsRestaurante.observaciones[2] },
                        { "AU9", CacheFormsRestaurante.observaciones[3] },
                        { "AU10", CacheFormsRestaurante.observaciones[4] },
                        { "AU11", CacheFormsRestaurante.observaciones[5] },
                        { "AU12", CacheFormsRestaurante.observaciones[6] },
                        { "AU13", CacheFormsRestaurante.observaciones[7] },
                        { "AU14", CacheFormsRestaurante.observaciones[8] },
                        { "AU15", CacheFormsRestaurante.observaciones[9] },
                        { "AU16", CacheFormsRestaurante.observaciones[10] }
                    };

                        foreach (var obs in observaciones)
                        {
                            worksheet.Cells[obs.Key].Value = obs.Value;
                        }

                        worksheet.Cells.AutoFitColumns();

                        package.SaveAs(new FileInfo(filePath));
                        MessageBox.Show("El archivo se ha guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        try
                        {
                            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al abrir el archivo Excel: " + ex.Message);
                        }
                    }
                }
            }
        }
        static private void RellenarDatos(ExcelWorksheet worksheet, int columnaInicio, int filaInicio, List<int> datos)
        {
            for (int i = 0; i < datos.Count; i++)
            {
                worksheet.Cells[filaInicio + i, columnaInicio].Value = datos[i];
            }
        }

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

                        // Asignar valores a las celdas con un bucle
                        for (int i = 0; i < CacheFormsRestaurante.temperatura.Count; i++)
                        {
                            int row = 42 + i; // La fila comienza en 42 y aumenta con cada iteración
                            string cell = $"C{row}"; // Construir la referencia de celda
                            worksheet.Cells[cell].Value = CacheFormsRestaurante.temperatura[i]; // Asignar el valor
                        }

                        // Calcular el porcentaje de cumplimiento
                        int totalTemperaturas = CacheFormsRestaurante.temperatura.Count; // Total de temperaturas
                        int temperaturasCorrectas = 0; // Contador de temperaturas dentro del rango

                        // Validar las temperaturas contra los rangos ideales
                        for (int i = 0; i < totalTemperaturas; i++)
                        {
                            int[] rango = CacheFormsRestaurante.temperaturasIdeales.ElementAt(i).Value; // Obtener el rango ideal
                            int temperatura = CacheFormsRestaurante.temperatura[i]; // Obtener la temperatura

                            // Verificar si la temperatura está dentro del rango
                            if (temperatura >= rango[0] && temperatura <= rango[1])
                            {
                                temperaturasCorrectas++; // Incrementar contador si está dentro del rango
                            }
                        }

                        // Calcular el porcentaje
                        double porcentajeCumplimiento = ((double)temperaturasCorrectas / totalTemperaturas) * 100;

                        // Asignar el porcentaje a la celda C48
                        worksheet.Cells["C48"].Value = $"{porcentajeCumplimiento:F2}%";
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
                        DialogResult result = MessageBox.Show("¿Deseas exportarlo en PDF?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ConvertirExcelAPdf(filePath);
                        }
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
