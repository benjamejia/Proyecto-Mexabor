using OfficeOpenXml;
using Syncfusion.Pdf;
using Syncfusion.XlsIO;
using Syncfusion.XlsIORenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mexabor.CacheAplicacion
{
    public class GenerarExcelAlmacen
    {
        public static string leyendaAlmacen = $"La auditoría fue realizada por {CacheUsuario.usuario} el día {DateTime.Now.ToString("yyyy-MM-dd")}  " +
          $"en el horario de {DateTime.Now.ToString("hh:mm")} pm La persona encargada de la sucursal en el momento que se realizo la auditoria y firmo de enterado fue {CacheFormsAlmacen.gerente}.";

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
                    string modifiedFilePath = Path.Combine(Directory.GetCurrentDirectory(), "CacheAplicacion", "EvaluacionAlmacen.xlsx");

                    // Cargar el archivo Excel
                    FileInfo fileInfo = new FileInfo(modifiedFilePath);
                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        // Obtener la primera hoja
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        //Fecha
                        worksheet.Cells["G1"].Value = "Fecha: " + CacheFormsAlmacen.fecha.ToString("yyyy-MM-dd");
                        //Sucusal
                        worksheet.Cells["E3"].Value = CacheFormsAlmacen.sucursal;
                        // Modificar las celdas incorrectas de las areas
                        worksheet.Cells["B13"].Value = 100 - CacheFormsAlmacen.areaPersonalEstructura.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["C13"].Value = 100 - CacheFormsAlmacen.areaPersonalLimpieza.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;

                        worksheet.Cells["B14"].Value = 100 - CacheFormsAlmacen.cocincaCalienteEstructura.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["C14"].Value = 100 - CacheFormsAlmacen.cocinaCalienteLimpieza.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["D14"].Value = 100 - CacheFormsAlmacen.personalCocinaCaliente.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;

                        worksheet.Cells["B15"].Value = 100 - CacheFormsAlmacen.camaraEstructura.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["C15"].Value = 100 - CacheFormsAlmacen.camaraLimpieza.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;

                        worksheet.Cells["B16"].Value = 100 - CacheFormsAlmacen.almacenEstructura.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["C16"].Value = 100 - CacheFormsAlmacen.almacenLimpieza.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;

                        worksheet.Cells["B17"].Value = 100 - CacheFormsAlmacen.cocinaFriaEstructura.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["C17"].Value = 100 - CacheFormsAlmacen.cocinaFriaLimpieza.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["D17"].Value = 100 - CacheFormsAlmacen.personalCocinaFria.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;

                        worksheet.Cells["B18"].Value = 100 - CacheFormsAlmacen.cajasEstructura.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["C18"].Value = 100 - CacheFormsAlmacen.cajasLimpieza.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;

                        worksheet.Cells["B19"].Value = 100 - CacheFormsAlmacen.areaPersonalEstructura.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["C19"].Value = 100 - CacheFormsAlmacen.areaPersonalLimpieza.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        //Metodo para sacar estructura y limpieza de vajillas
                        List<int> vajillaEstructura = [CacheFormsAlmacen.vajillas[0], CacheFormsAlmacen.vajillas[4], CacheFormsAlmacen.vajillas[6]];
                        List<int> vajillaLimpieza = [CacheFormsAlmacen.vajillas[1], CacheFormsAlmacen.vajillas[2], CacheFormsAlmacen.vajillas[3], CacheFormsAlmacen.vajillas[5], CacheFormsAlmacen.vajillas[7]];
                        
                        worksheet.Cells["B20"].Value = 100 - vajillaEstructura.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        worksheet.Cells["C20"].Value = 100 - vajillaLimpieza.Count(x => x == 0) * CacheFormsAlmacen.ponderacionAlmacen;
                        //Responsables
                        worksheet.Cells["F13"].Value = CacheFormsAlmacen.responsables[0];
                        worksheet.Cells["F14"].Value = CacheFormsAlmacen.responsables[1];
                        worksheet.Cells["F15"].Value = CacheFormsAlmacen.responsables[2];
                        worksheet.Cells["F16"].Value = CacheFormsAlmacen.responsables[3];
                        worksheet.Cells["F17"].Value = CacheFormsAlmacen.responsables[4];
                        worksheet.Cells["F18"].Value = CacheFormsAlmacen.responsables[5];
                        worksheet.Cells["F19"].Value = CacheFormsAlmacen.responsables[6];
                        worksheet.Cells["F20"].Value = CacheFormsAlmacen.responsables[7];
                        worksheet.Cells["A29"].Value = leyendaAlmacen;

                        //Obersevaciones productos e inventario
                        if (CacheFormsAlmacen.productosIncorrectosProductos == -1)
                        {
                            CacheFormsAlmacen.productosIncorrectosProductos = 100 - (3 * CacheFormsAlmacen.productosRevisados[0] - CacheFormsAlmacen.productosRevisados[1]
                            - CacheFormsAlmacen.productosRevisados[2] - CacheFormsAlmacen.productosRevisados[3]) * CacheFormsAlmacen.ponderacionProductos;
                            worksheet.Cells["A27"].Value = CacheFormsAlmacen.productosIncorrectosProductos;
                        }
                        else 
                        {
                            worksheet.Cells["A27"].Value = CacheFormsAlmacen.productosIncorrectosProductos;
                        }
                        //Obersevaciones productos e inventario
                        if (CacheFormsAlmacen.productosIncorrectosInventario == -1)
                        {
                            CacheFormsAlmacen.productosIncorrectosInventario = 100 - (CacheFormsAlmacen.productosRevisadosInventario[0] - CacheFormsAlmacen.productosRevisadosInventario[1]) * CacheFormsAlmacen.ponderacionInventario;
                            worksheet.Cells["E27"].Value = CacheFormsAlmacen.productosIncorrectosInventario;
                        }
                        else
                        {
                            worksheet.Cells["E27"].Value = CacheFormsAlmacen.productosIncorrectosInventario;
                        }

                        worksheet.Cells["E23"].Value = CacheFormsAlmacen.observacionesInventario;
                        worksheet.Cells["A23"].Value = CacheFormsAlmacen.observaciones;
                        


                        MessageBox.Show("El archivo se ha guardado exitosamente en la ubicación seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FileInfo newFile = new FileInfo(filePath);
                        package.SaveAs(newFile);
                        /*
                        DialogResult result = MessageBox.Show("¿Deseas exportarlo en PDF?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ConvertirExcelAPdf(filePath);
                        }
                        */
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
        static public void ExcelTablaDesglozada()
        {
        }
    }
}
