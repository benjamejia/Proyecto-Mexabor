using Aspose.Cells.Rendering;
using Aspose.Cells;
using Microsoft.Office.Core;
using OfficeOpenXml;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public partial class FormExportacion : Form
    {
        public string rutaArchivo;
        public bool t;
        public FormExportacion()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu2 menu = new FormMenu2();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t = false;
            ExportarDatosExcel();
        }
        public void ExportarDatosExcel()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel modificado";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Ruta del archivo Excel modificado (deberías tenerlo en una variable o haberlo modificado previamente)
                    string modifiedFilePath = Path.Combine(Directory.GetCurrentDirectory(), "FormatoReporte.xlsx");

                    // Cargar el archivo Excel
                    FileInfo fileInfo = new FileInfo(modifiedFilePath);
                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        // Obtener la primera hoja
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        //Fecha
                        // Extraer solo la parte de la fecha como cadena en formato "yyyy-MM-dd"
                        DateTime ahoraFecha = DateTime.Now;
                        string soloFecha = "Fecha "+ ahoraFecha.ToString("yyyy-MM-dd"); // Formato de solo fecha
                        worksheet.Cells["H2"].Value = soloFecha;
                        //Sucusal
                        worksheet.Cells["E3"].Value = DataForms.sucursal;
                        int re1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27;
                        // Modificar las celdas incorrectas de las areas
                        worksheet.Cells["C10"].Value = re1 = 100 - DataForms.incorrectasEstacionamientoE * 10;
                        worksheet.Cells["D10"].Value = r2 = 100 - DataForms.incorrectasEstacionamientoL * 10;

                        worksheet.Cells["C12"].Value = r3 = 100 - DataForms.incorrectasComedorE * 10;
                        worksheet.Cells["D12"].Value = r4 = 100 - DataForms.incorrectasComedorL * 10;
                        worksheet.Cells["E12"].Value = r5 = 100 - DataForms.incorrectasPersonalMesas * 10;

                        worksheet.Cells["C14"].Value = r6 = 100 - DataForms.incorrectasBarraE * 10;
                        worksheet.Cells["D14"].Value = r7 = 100 - DataForms.incorrectasBarraL * 10;
                        worksheet.Cells["E14"].Value = r8 = 100 - DataForms.incorrectasPersonalBarra * 10;

                        worksheet.Cells["C16"].Value = r9 = 100 - DataForms.incorrectasTortillasE * 10;
                        worksheet.Cells["D16"].Value = r10 = 100 - DataForms.incorrectasTortillasL * 10;
                        worksheet.Cells["E16"].Value = r11 = 100 - DataForms.incorrectasPersonalTortilla * 10;

                        worksheet.Cells["C18"].Value = r12 = 100 - DataForms.incorrectasServiciosE * 10;
                        worksheet.Cells["D18"].Value = r13 = 100 - DataForms.incorrectasServiciosL * 10;
                        worksheet.Cells["E18"].Value = r14 = 100 - DataForms.incorrectasPersonalServicios * 10;

                        worksheet.Cells["C20"].Value = r15 = 100 - DataForms.incorrectasPlanchasE * 10;
                        worksheet.Cells["D20"].Value = r16 = 100 - DataForms.incorrectasPlanchasL * 10;
                        worksheet.Cells["E20"].Value = r17 = 100 - DataForms.incorrectasPersonalPlanchas * 10;

                        worksheet.Cells["C22"].Value = r18 = 100 - DataForms.incorrectasAreaLozaE * 10;
                        worksheet.Cells["D22"].Value = r19 = 100 - DataForms.incorrectasAreaLozaL * 10;
                        worksheet.Cells["E22"].Value = r20 = 100 - DataForms.incorrectasPersonalLoza * 10;

                        worksheet.Cells["C24"].Value = r21 = 100 - DataForms.incorrectasBañosE * 10;
                        worksheet.Cells["D24"].Value = r22 = 100 - DataForms.incorrectasBañosL * 10;
                        worksheet.Cells["E24"].Value = r23 = 100 - DataForms.incorrectasPersonaAseo * 10;

                        worksheet.Cells["C26"].Value = r24 = 100 - DataForms.incorrectasJuegosE * 10;
                        worksheet.Cells["D26"].Value = r25 = 100 - DataForms.incorrectasJuegosL * 10;

                        worksheet.Cells["C28"].Value = r26 = 100 - DataForms.incorrectasCaja * 10;
                        worksheet.Cells["C30"].Value = r27 = 100 - DataForms.incorrectasAlmacen * 10;
                        //trapos
                        worksheet.Cells["C68"].Value = DataForms.traposCocina;
                        worksheet.Cells["D68"].Value = DataForms.traposMesas;
                        worksheet.Cells["E68"].Value = DataForms.traposBanios;
                        worksheet.Cells["F68"].Value = DataForms.traposCaja;
                        //calificacion proovedores
                        worksheet.Cells["B57"].Value = Convert.ToInt32(DataForms.calificacionProovedores[0]);
                        worksheet.Cells["C57"].Value = Convert.ToInt32(DataForms.calificacionProovedores[1]);
                        worksheet.Cells["D57"].Value = Convert.ToInt32(DataForms.calificacionProovedores[2]);

                        worksheet.Cells["B59"].Value = Convert.ToInt32(DataForms.calificacionProovedores[3]);
                        worksheet.Cells["C59"].Value = Convert.ToInt32(DataForms.calificacionProovedores[4]);
                        worksheet.Cells["D59"].Value = Convert.ToInt32(DataForms.calificacionProovedores[5]);

                        worksheet.Cells["B61"].Value = Convert.ToInt32(DataForms.calificacionProovedores[6]);
                        worksheet.Cells["C61"].Value = Convert.ToInt32(DataForms.calificacionProovedores[7]);
                        worksheet.Cells["D61"].Value = Convert.ToInt32(DataForms.calificacionProovedores[8]);
                        worksheet.Cells["E61"].Value = Convert.ToInt32(DataForms.calificacionProovedores[9]);

                        // Método para limpiar y convertir la temperatura a double
                        double ConvertToDouble(string temp)
                        {
                            if (string.IsNullOrWhiteSpace(temp))
                            {
                                throw new InvalidOperationException("Una de las entradas en DataForms.temperatura es null o está vacía.");
                            }

                            // Elimina el símbolo "°C" y convierte la cadena a double
                            string tempStr = temp.Replace("°C", "").Trim();

                            if (!double.TryParse(tempStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double temperatura))
                            {
                                throw new InvalidOperationException($"No se puede convertir '{tempStr}' a un número decimal.");
                            }

                            return temperatura;
                        }

                        // Asignar valores a las celdas
                        worksheet.Cells["C42"].Value = ConvertToDouble(DataForms.temperatura[0]);
                        worksheet.Cells["C43"].Value = ConvertToDouble(DataForms.temperatura[1]);
                        worksheet.Cells["C44"].Value = ConvertToDouble(DataForms.temperatura[2]);
                        worksheet.Cells["C45"].Value = ConvertToDouble(DataForms.temperatura[3]);
                        worksheet.Cells["C46"].Value = ConvertToDouble(DataForms.temperatura[4]);
                        worksheet.Cells["C47"].Value = ConvertToDouble(DataForms.temperatura[5]);
                        //Cloracion
                        if (DataForms.cloracion == 0)
                        {
                            worksheet.Cells["G47"].Value = "Mal";
                        }
                        else
                        {
                            worksheet.Cells["G47"].Value = "Buena";
                        }
                        //Observaciones
                        worksheet.Cells["C71"].Value = DataForms.observacionGas;
                        worksheet.Cells["C77"].Value = DataForms.observacionFumigacion;
                        worksheet.Cells["C83"].Value = DataForms.observacionTrampa;
                        worksheet.Cells["C89"].Value = DataForms.observacionFilete;
                        worksheet.Cells["C95"].Value = DataForms.observacionMasa;
                        worksheet.Cells["C103"].Value = DataForms.observacionPostres;
                        worksheet.Cells["C109"].Value = DataForms.observacionRefresco;
                        worksheet.Cells["C115"].Value = DataForms.observacionCerveza;
                        worksheet.Cells["C121"].Value = DataForms.observacionAlmacen;
                        worksheet.Cells["C127"].Value = DataForms.observacionBasura;
                        worksheet.Cells["C133"].Value = DataForms.observacionMantenimiento;

                        //Sabores 
                        if (DataForms.sabor[0] == "1")
                        {
                            worksheet.Cells["D42"].Value = "Bien";
                        }
                        else
                        {
                            worksheet.Cells["D42"].Value = "Mal";
                        }
                        if (DataForms.sabor[1] == "1")
                        {
                            worksheet.Cells["D43"].Value = "Bien";
                        }else
                        {
                            worksheet.Cells["D43"].Value = "Mal";
                        }
                        if (DataForms.sabor[2] == "1")
                        {
                            worksheet.Cells["D44"].Value = "Bien";
                        }
                        else 
                        {
                            worksheet.Cells["D44"].Value = "Mal";
                        }
                        if (DataForms.sabor[3] == "1")
                        {
                            worksheet.Cells["D45"].Value = "Bien";
                        }
                        else
                        {
                            worksheet.Cells["D45"].Value = "Mal";
                        }
                        if (DataForms.sabor[4] == "1")
                        {
                            worksheet.Cells["D46"].Value = "Bien";
                        }
                        else
                        {
                            worksheet.Cells["D46"].Value = "Mal";
                        }
                        if (DataForms.sabor[5] == "1")
                        {
                            worksheet.Cells["D47"].Value = "Bien";
                        }
                        else
                        {
                            worksheet.Cells["D47"].Value = "Mal";
                        }
                        //Porcentaje de Sabores
                        // Define los valores de sabor (en este caso, desde DataForms.sabor)
                        int[] sabores = Array.ConvertAll(DataForms.sabor, s => int.Parse(s));

                        // Crear una lista para almacenar si el sabor es bueno (1) o malo (0)
                        List<bool> resultadosSabor = new List<bool>();

                        for (int i = 0; i < sabores.Length; i++)
                        {
                            // Obtener el valor de sabor (1 o 0)
                            int sabor = sabores[i];

                            // Verificar si el sabor es bueno (1)
                            bool esBueno = sabor == 1;
                            resultadosSabor.Add(esBueno);
                        }

                        // Contar cuántos sabores son buenos
                        int countBien = resultadosSabor.Count(r => r);
                        int totalSabores = resultadosSabor.Count;

                        // Calcular el porcentaje de sabores buenos
                        double porcentajeBien = Math.Round((double)countBien / totalSabores * 100);

                        // Mostrar el porcentaje (puedes guardar este valor o mostrarlo según lo necesites)
                        Console.WriteLine($"Porcentaje de sabores buenos: {porcentajeBien:F2}%");

                        // Aquí puedes guardar el porcentaje en el lugar que necesites, por ejemplo:
                        worksheet.Cells["D48"].Value = $"{Math.Round(porcentajeBien)}%"; // Asigna el porcentaje a una celda específica en el Excel

                        //Porcentaje Temperatura

                        // Define los rangos ideales para cada temperatura
                        int[,] rangosIdeales = {
                                                        { 60, 67 }, // Rango para la primera temperatura
                                                        { 65, 78 }, // Rango para la segunda temperatura
                                                        { 65, 80 }, // Rango para la tercera temperatura
                                                        { 50, 90 }, // Rango para la cuarta temperatura
                                                        { 65, 80 }, // Rango para la quinta temperatura
                                                        { 60, 75 }  // Rango para la sexta temperatura
                                                    };
                        // Imprime cada entrada para depurar el problema
                        foreach (var temp in DataForms.temperatura)
                        {
                            Console.WriteLine($"Temperatura antes de conversión: '{temp}'");
                        }

                        // Define las temperaturas obtenidas (en este caso, desde DataForms.temperaturas)
                        int[] temperaturasObtenidas = Array.ConvertAll(DataForms.temperatura, t =>
                        {
                            // Verifica si t es null o está vacío
                            if (string.IsNullOrWhiteSpace(t))
                            {
                                throw new InvalidOperationException("Una de las entradas en DataForms.temperatura es null o está vacía.");
                            }

                            // Elimina el símbolo "°C" y convierte la cadena a entero
                            string tempStr = t.Replace("°C", "").Trim();

                            // Verifica si tempStr puede ser convertido a entero
                            if (!int.TryParse(tempStr, out int temperatura))
                            {
                                throw new InvalidOperationException($"No se puede convertir '{tempStr}' a un número entero.");
                            }

                            return temperatura;
                        });


                        // Crear una lista para almacenar si la temperatura está dentro del rango ideal
                        List<bool> resultados = new List<bool>();
                        // Contador para las temperaturas fuera del rango
                        int contadorFueraDelRango = 0;
                        for (int i = 0; i < temperaturasObtenidas.Length; i++)
                        {
                            // Obtener la temperatura obtenida
                            int temperatura = temperaturasObtenidas[i];

                            // Obtener el rango ideal para la temperatura actual
                            int rangoMin = rangosIdeales[i, 0];
                            int rangoMax = rangosIdeales[i, 1];

                            // Verificar si la temperatura está dentro del rango ideal
                            bool dentroDelRango = temperatura >= rangoMin && temperatura <= rangoMax;
                            resultados.Add(dentroDelRango);
                            // Incrementar el contador si la temperatura está fuera del rango
                            if (!dentroDelRango)
                            {
                                contadorFueraDelRango++;
                            }
                        }
                        contadorFueraDelRango = contadorFueraDelRango * 5;
                        // Contar cuántas temperaturas están dentro del rango ideal
                        int countBien1 = resultados.Count(r => r);
                        int totalTemperaturas = resultados.Count;


                        // Calcular el porcentaje de temperaturas dentro del rango ideal
                        double porcentajeBien1 = Math.Round((double)countBien1 / totalTemperaturas * 100);
                        // Aquí puedes guardar el porcentaje en el lugar que necesites, por ejemplo:
                        worksheet.Cells["C48"].Value = $"{porcentajeBien1:F2}%"; // Asigna el porcentaje a una celda específica en el Excel
                        //checks
                        int cantidad1 = 0;
                        if (DataForms.documentos[0] == "1")
                        {
                            cantidad1++;
                        }
                        if (DataForms.documentos[1] == "1")
                        {
                            cantidad1++;
                        }
                        if (DataForms.documentos[2] == "1")
                        {
                            cantidad1++;
                        }
                        if (DataForms.documentos[3] == "1")
                        {
                            cantidad1++;
                        }
                        if (DataForms.documentos[5] == "1")
                        {
                            cantidad1++;
                        }

                        //Checks
                        worksheet.Cells["I47"].Value = $"{cantidad1} de 5";
                        //Manifestos
                        if (DataForms.documentos[4] == "1") { worksheet.Cells["H47"].Value = "Bien"; } else { worksheet.Cells["H47"].Value = "Mal"; }


                        MessageBox.Show("El archivo se ha guardado exitosamente en la ubicación seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FileInfo newFile = new FileInfo(filePath);
                            package.SaveAs(newFile);
                        // Primera calificación
                        contadorFueraDelRango = contadorFueraDelRango * 5;

                        // Declarar la variable global para almacenar el total de incorrectas de las áreas
                        int incorrectasDataForms = 0;
                        incorrectasDataForms += DataForms.incorrectasEstacionamientoL;

                        incorrectasDataForms += DataForms.incorrectasComedorL;
                        incorrectasDataForms += DataForms.incorrectasPersonalMesas;

                        incorrectasDataForms += DataForms.incorrectasBarraL;
                        incorrectasDataForms += DataForms.incorrectasPersonalBarra;

                        incorrectasDataForms += DataForms.incorrectasTortillasL;
                        incorrectasDataForms += DataForms.incorrectasPersonalTortilla;

                        incorrectasDataForms += DataForms.incorrectasServiciosL;
                        incorrectasDataForms += DataForms.incorrectasPersonalServicios;

                        incorrectasDataForms += DataForms.incorrectasPlanchasL;
                        incorrectasDataForms += DataForms.incorrectasPersonalPlanchas;

                        incorrectasDataForms += DataForms.incorrectasAreaLozaL;
                        incorrectasDataForms += DataForms.incorrectasPersonalLoza;

                        incorrectasDataForms += DataForms.incorrectasBañosL;
                        incorrectasDataForms += DataForms.incorrectasPersonaAseo;

                        incorrectasDataForms += DataForms.incorrectasJuegosL;

                        // Calcular las penalizaciones
                        incorrectasDataForms = incorrectasDataForms * 5;

                        // Calcular las demás cantidades
                        int[] sabores2 = Array.ConvertAll(DataForms.sabor, s => int.Parse(s));

                        // Crear una lista para almacenar si el sabor es bueno (1) o malo (0)
                        List<bool> resultadosSabor2 = new List<bool>();

                        for (int i = 0; i < sabores.Length; i++)
                        {
                            // Obtener el valor de sabor (1 o 0)
                            int sabor = sabores[i];

                            // Verificar si el sabor es bueno (1)
                            bool esBueno2 = sabor == 1;
                            resultadosSabor2.Add(esBueno2);
                        }

                        // Contar cuántos sabores son buenos
                        int countBien2 = (6 - resultadosSabor2.Count(r => r)) * 5;
                        int cantidad3 = (5 - cantidad1) * 5;
                        int cantidad4 = (DataForms.documentos[4] == "0") ? 5 : 0;
                        int cantidad5 = (DataForms.cloracion == 0) ? 5 : 0;

                        // Sumar las penalizaciones adicionales
                        int totalPenalizaciones = incorrectasDataForms + countBien2 + cantidad3 + cantidad4 + cantidad5 + contadorFueraDelRango;
                       
                        // Calcular la primera calificación
                        int primeraCalificacion = 100 - totalPenalizaciones;

                        worksheet.Cells["H6"].Value = primeraCalificacion;
                    }
                }
            }
        }
        public void ExportToPdf()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar archivo PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pdfFilePath = saveFileDialog.FileName;
                    string modifiedFilePath = Path.Combine(Directory.GetCurrentDirectory(), "FormatoReporte.xlsx");
                    FileInfo fileInfo = new FileInfo(modifiedFilePath);
                    using (var memoryStream = new MemoryStream())
                    {
                        // Crear el archivo Excel en memoria
                        using (var package = new ExcelPackage(fileInfo))
                        {
                            // Obtener la primera hoja
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                            //Fecha
                            // Extraer solo la parte de la fecha como cadena en formato "yyyy-MM-dd"
                            DateTime ahoraFecha = DateTime.Now;
                            string soloFecha = "Fecha " + ahoraFecha.ToString("yyyy-MM-dd"); // Formato de solo fecha
                            worksheet.Cells["H2"].Value = soloFecha;
                            //Sucusal
                            worksheet.Cells["E3"].Value = DataForms.sucursal;
                            int re1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27;
                            // Modificar las celdas incorrectas de las areas
                            worksheet.Cells["C10"].Value = re1 = 100 - DataForms.incorrectasEstacionamientoE * 10;
                            worksheet.Cells["D10"].Value = r2 = 100 - DataForms.incorrectasEstacionamientoL * 10;

                            worksheet.Cells["C12"].Value = r3 = 100 - DataForms.incorrectasComedorE * 10;
                            worksheet.Cells["D12"].Value = r4 = 100 - DataForms.incorrectasComedorL * 10;
                            worksheet.Cells["E12"].Value = r5 = 100 - DataForms.incorrectasPersonalMesas * 10;

                            worksheet.Cells["C14"].Value = r6 = 100 - DataForms.incorrectasBarraE * 10;
                            worksheet.Cells["D14"].Value = r7 = 100 - DataForms.incorrectasBarraL * 10;
                            worksheet.Cells["E14"].Value = r8 = 100 - DataForms.incorrectasPersonalBarra * 10;

                            worksheet.Cells["C16"].Value = r9 = 100 - DataForms.incorrectasTortillasE * 10;
                            worksheet.Cells["D16"].Value = r10 = 100 - DataForms.incorrectasTortillasL * 10;
                            worksheet.Cells["E16"].Value = r11 = 100 - DataForms.incorrectasPersonalTortilla * 10;

                            worksheet.Cells["C18"].Value = r12 = 100 - DataForms.incorrectasServiciosE * 10;
                            worksheet.Cells["D18"].Value = r13 = 100 - DataForms.incorrectasServiciosL * 10;
                            worksheet.Cells["E18"].Value = r14 = 100 - DataForms.incorrectasPersonalServicios * 10;

                            worksheet.Cells["C20"].Value = r15 = 100 - DataForms.incorrectasPlanchasE * 10;
                            worksheet.Cells["D20"].Value = r16 = 100 - DataForms.incorrectasPlanchasL * 10;
                            worksheet.Cells["E20"].Value = r17 = 100 - DataForms.incorrectasPersonalPlanchas * 10;

                            worksheet.Cells["C22"].Value = r18 = 100 - DataForms.incorrectasAreaLozaE * 10;
                            worksheet.Cells["D22"].Value = r19 = 100 - DataForms.incorrectasAreaLozaL * 10;
                            worksheet.Cells["E22"].Value = r20 = 100 - DataForms.incorrectasPersonalLoza * 10;

                            worksheet.Cells["C24"].Value = r21 = 100 - DataForms.incorrectasBañosE * 10;
                            worksheet.Cells["D24"].Value = r22 = 100 - DataForms.incorrectasBañosL * 10;
                            worksheet.Cells["E24"].Value = r23 = 100 - DataForms.incorrectasPersonaAseo * 10;

                            worksheet.Cells["C26"].Value = r24 = 100 - DataForms.incorrectasJuegosE * 10;
                            worksheet.Cells["D26"].Value = r25 = 100 - DataForms.incorrectasJuegosL * 10;

                            worksheet.Cells["C28"].Value = r26 = 100 - DataForms.incorrectasCaja * 10;
                            worksheet.Cells["C30"].Value = r27 = 100 - DataForms.incorrectasAlmacen * 10;

                            //Total
                            worksheet.Cells["F10"].Value = Math.Round((re1 + r2) / 2.0, 0);
                            worksheet.Cells["F12"].Value = Math.Round((r3 + r4 + r5) / 3.0, 0);
                            worksheet.Cells["F14"].Value = Math.Round((r6 + r7 + r8) / 3.0, 0);
                            worksheet.Cells["F16"].Value = Math.Round((r9 + r10 + r11) / 3.0, 0);
                            worksheet.Cells["F18"].Value = Math.Round((r12 + r13 + r14) / 3.0, 0);
                            worksheet.Cells["F20"].Value = Math.Round((r15 + r16 + r17) / 3.0, 0);
                            worksheet.Cells["F22"].Value = Math.Round((r18 + r19 + r20) / 3.0, 0);
                            worksheet.Cells["F24"].Value = Math.Round((r21 + r22 + r23) / 3.0, 0);
                            worksheet.Cells["F26"].Value = Math.Round((r24 + r25) / 2.0, 0);
                            worksheet.Cells["F28"].Value = r26;
                            worksheet.Cells["F30"].Value = r27;
                            //Promedio
                            worksheet.Cells["C32"].Value = (re1 + r3 + r6 + r9 + r12 + r15 + r18 + r21 + r24 + r26) / 10;
                            worksheet.Cells["D32"].Value = (r2 + r4 + r7 + r10 + r13 + r16 + r19 + r22 + r25) / 9;
                            worksheet.Cells["E32"].Value = (r5 + r8 + r11 + r14 + r17 + r20 + r23) / 7;
                            // Promedio proveedores
                            double resultadoPromedio = 0;
                            int cantidadCalificaciones = 0;

                            for (int i = 0; i < DataForms.calificacionProovedores.Length; i++)
                            {
                                // Procesa cada elemento de la lista como una cadena
                                string calificacion = DataForms.calificacionProovedores[i];

                                // Si es un número válido, lo conviertes a entero
                                if (calificacion == "10")
                                {
                                    resultadoPromedio += 10;
                                    cantidadCalificaciones++;
                                }
                                else if (int.TryParse(calificacion, out int cifra))
                                {
                                    // Para otros dígitos numéricos
                                    resultadoPromedio += cifra;
                                    cantidadCalificaciones++;
                                }
                            }

                            double promedioProveedores = 0;

                            // Calcula el promedio si hay calificaciones válidas
                            if (cantidadCalificaciones > 0)
                            {
                                promedioProveedores = resultadoPromedio / cantidadCalificaciones;
                                Console.WriteLine($"El promedio de los proveedores es: {promedioProveedores}");
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron calificaciones válidas.");
                            }


                            // Asigna el promedio a la celda de Excel
                            worksheet.Cells["B63"].Value = promedioProveedores;

                            //trapos
                            worksheet.Cells["C68"].Value = DataForms.traposCocina;
                            worksheet.Cells["D68"].Value = DataForms.traposMesas;
                            worksheet.Cells["E68"].Value = DataForms.traposBanios;
                            worksheet.Cells["F68"].Value = DataForms.traposCaja;
                            //calificacion proovedores
                            worksheet.Cells["B57"].Value = Convert.ToInt32(DataForms.calificacionProovedores[0]);
                            worksheet.Cells["C57"].Value = Convert.ToInt32(DataForms.calificacionProovedores[1]);
                            worksheet.Cells["D57"].Value = Convert.ToInt32(DataForms.calificacionProovedores[2]);

                            worksheet.Cells["B59"].Value = Convert.ToInt32(DataForms.calificacionProovedores[3]);
                            worksheet.Cells["C59"].Value = Convert.ToInt32(DataForms.calificacionProovedores[4]);
                            worksheet.Cells["D59"].Value = Convert.ToInt32(DataForms.calificacionProovedores[5]);

                            worksheet.Cells["B61"].Value = Convert.ToInt32(DataForms.calificacionProovedores[6]);
                            worksheet.Cells["C61"].Value = Convert.ToInt32(DataForms.calificacionProovedores[7]);
                            worksheet.Cells["D61"].Value = Convert.ToInt32(DataForms.calificacionProovedores[8]);
                            worksheet.Cells["E61"].Value = Convert.ToInt32(DataForms.calificacionProovedores[9]);
                            //Temperatura
                            worksheet.Cells["C42"].Value = DataForms.temperatura[0];
                            worksheet.Cells["C43"].Value = DataForms.temperatura[1];
                            worksheet.Cells["C44"].Value = DataForms.temperatura[2];
                            worksheet.Cells["C45"].Value = DataForms.temperatura[3];
                            worksheet.Cells["C46"].Value = DataForms.temperatura[4];
                            worksheet.Cells["C47"].Value = DataForms.temperatura[5];
                            if (DataForms.cloracion == 0)
                            {
                                worksheet.Cells["G47"].Value = "Mal";
                            }
                            else
                            {
                                worksheet.Cells["G47"].Value = "Buena";
                            }

                            //Observaciones
                            worksheet.Cells["C71"].Value = DataForms.observacionGas;
                            worksheet.Cells["C77"].Value = DataForms.observacionFumigacion;
                            worksheet.Cells["C83"].Value = DataForms.observacionTrampa;
                            worksheet.Cells["C89"].Value = DataForms.observacionFilete;
                            worksheet.Cells["C95"].Value = DataForms.observacionMasa;
                            worksheet.Cells["C103"].Value = DataForms.observacionPostres;
                            worksheet.Cells["C109"].Value = DataForms.observacionRefresco;
                            worksheet.Cells["C115"].Value = DataForms.observacionCerveza;
                            worksheet.Cells["C121"].Value = DataForms.observacionAlmacen;
                            worksheet.Cells["C127"].Value = DataForms.observacionBasura;
                            worksheet.Cells["C133"].Value = DataForms.observacionMantenimiento;

                            //Sabores 
                            if (DataForms.sabor[0] == "1")
                            {
                                worksheet.Cells["D42"].Value = "Bien";
                            }
                            else
                            {
                                worksheet.Cells["D42"].Value = "Mal";
                            }
                            if (DataForms.sabor[1] == "1")
                            {
                                worksheet.Cells["D43"].Value = "Bien";
                            }
                            else
                            {
                                worksheet.Cells["D43"].Value = "Mal";
                            }
                            if (DataForms.sabor[2] == "1")
                            {
                                worksheet.Cells["D44"].Value = "Bien";
                            }
                            else
                            {
                                worksheet.Cells["D44"].Value = "Mal";
                            }
                            if (DataForms.sabor[3] == "1")
                            {
                                worksheet.Cells["D45"].Value = "Bien";
                            }
                            else
                            {
                                worksheet.Cells["D45"].Value = "Mal";
                            }
                            if (DataForms.sabor[4] == "1")
                            {
                                worksheet.Cells["D46"].Value = "Bien";
                            }
                            else
                            {
                                worksheet.Cells["D46"].Value = "Mal";
                            }
                            if (DataForms.sabor[5] == "1")
                            {
                                worksheet.Cells["D47"].Value = "Bien";
                            }
                            else
                            {
                                worksheet.Cells["D47"].Value = "Mal";
                            }
                            //porcentaje sabor*************************************************************
                            // Define los valores de sabor (en este caso, desde DataForms.sabor)
                            int[] sabores = Array.ConvertAll(DataForms.sabor, s => int.Parse(s));

                            // Crear una lista para almacenar si el sabor es bueno (1) o malo (0)
                            List<bool> resultadosSabor = new List<bool>();

                            for (int i = 0; i < sabores.Length; i++)
                            {
                                // Obtener el valor de sabor (1 o 0)
                                int sabor = sabores[i];

                                // Verificar si el sabor es bueno (1)
                                bool esBueno = sabor == 1;
                                resultadosSabor.Add(esBueno);
                            }

                            // Contar cuántos sabores son buenos
                            int countBien = resultadosSabor.Count(r => r);
                            int totalSabores = resultadosSabor.Count;

                            // Calcular el porcentaje de sabores buenos
                            double porcentajeBien = Math.Round((double)countBien / totalSabores * 100);

                            // Mostrar el porcentaje (puedes guardar este valor o mostrarlo según lo necesites)
                            Console.WriteLine($"Porcentaje de sabores buenos: {porcentajeBien:F2}%");

                            // Aquí puedes guardar el porcentaje en el lugar que necesites, por ejemplo:
                            worksheet.Cells["D48"].Value = $"{Math.Round(porcentajeBien)}%"; // Asigna el porcentaje a una celda específica en el Excel



                            // Define los rangos ideales para cada temperatura
                            int[,] rangosIdeales = {
                                                        { 60, 67 }, // Rango para la primera temperatura
                                                        { 65, 78 }, // Rango para la segunda temperatura
                                                        { 65, 80 }, // Rango para la tercera temperatura
                                                        { 50, 90 }, // Rango para la cuarta temperatura
                                                        { 65, 80 }, // Rango para la quinta temperatura
                                                        { 60, 75 }  // Rango para la sexta temperatura
                                                    };
                            // Imprime cada entrada para depurar el problema
                            foreach (var temp in DataForms.temperatura)
                            {
                                Console.WriteLine($"Temperatura antes de conversión: '{temp}'");
                            }

                            // Define las temperaturas obtenidas (en este caso, desde DataForms.temperaturas)
                            int[] temperaturasObtenidas = Array.ConvertAll(DataForms.temperatura, t =>
                            {
                                // Verifica si t es null o está vacío
                                if (string.IsNullOrWhiteSpace(t))
                                {
                                    throw new InvalidOperationException("Una de las entradas en DataForms.temperatura es null o está vacía.");
                                }

                                // Elimina el símbolo "°C" y convierte la cadena a entero
                                string tempStr = t.Replace("°C", "").Trim();

                                // Verifica si tempStr puede ser convertido a entero
                                if (!int.TryParse(tempStr, out int temperatura))
                                {
                                    throw new InvalidOperationException($"No se puede convertir '{tempStr}' a un número entero.");
                                }

                                return temperatura;
                            });


                            // Crear una lista para almacenar si la temperatura está dentro del rango ideal
                            List<bool> resultados = new List<bool>();
                            int contadorFueraDelRango = 0;
                            for (int i = 0; i < temperaturasObtenidas.Length; i++)
                            {
                                // Obtener la temperatura obtenida
                                int temperatura = temperaturasObtenidas[i];

                                // Obtener el rango ideal para la temperatura actual
                                int rangoMin = rangosIdeales[i, 0];
                                int rangoMax = rangosIdeales[i, 1];

                                // Verificar si la temperatura está dentro del rango ideal
                                bool dentroDelRango = temperatura >= rangoMin && temperatura <= rangoMax;
                                resultados.Add(dentroDelRango);

                                if (!dentroDelRango)
                                {
                                    contadorFueraDelRango++;
                                    Console.WriteLine("temp:" + contadorFueraDelRango);
                                }

                            }
                            contadorFueraDelRango = contadorFueraDelRango * 5;

                            // Contar cuántas temperaturas están dentro del rango ideal
                            int countBien1 = resultados.Count(r => r);
                            int totalTemperaturas = resultados.Count;


                            // Calcular el porcentaje de temperaturas dentro del rango ideal
                            double porcentajeBien1 = Math.Round((double)countBien1 / totalTemperaturas * 100);
                            //checks
                            int cant = 0;
                            if (DataForms.documentos[0] == "1")
                            {
                                cant++;
                            }
                            if (DataForms.documentos[1] == "1")
                            {
                                cant++;
                            }
                            if (DataForms.documentos[2] == "1")
                            {
                                cant++;
                            }
                            if (DataForms.documentos[3] == "1")
                            {
                                cant++;
                            }
                            if (DataForms.documentos[5] == "1")
                            {
                                cant++;
                            }
                            //Checks
                            worksheet.Cells["I47"].Value = $"{cant} de 5";
                            //MANIFESTOS
                            if (DataForms.documentos[4] == "1") { worksheet.Cells["H47"].Value = "Bien"; } else { worksheet.Cells["H47"].Value = "Mal"; }

                            // Mostrar el porcentaje (puedes guardar este valor o mostrarlo según lo necesites)
                            Console.WriteLine($"Porcentaje de temperaturas dentro del rango ideal: {Math.Round(porcentajeBien1)}%");

                            // Aquí puedes guardar el porcentaje en el lugar que necesites, por ejemplo:
                            worksheet.Cells["C48"].Value = $"{porcentajeBien1:F2}%"; // Asigna el porcentaje a una celda específica en el Excel
                                                                                     // Primera calificación


                            // Declarar la variable global para almacenar el total de incorrectas de las áreas
                            int incorrectasDataForms = 0;
                            incorrectasDataForms += DataForms.incorrectasEstacionamientoL;

                            incorrectasDataForms += DataForms.incorrectasComedorL;
                            incorrectasDataForms += DataForms.incorrectasPersonalMesas;

                            incorrectasDataForms += DataForms.incorrectasBarraL;
                            incorrectasDataForms += DataForms.incorrectasPersonalBarra;

                            incorrectasDataForms += DataForms.incorrectasTortillasL;
                            incorrectasDataForms += DataForms.incorrectasPersonalTortilla;

                            incorrectasDataForms += DataForms.incorrectasServiciosL;
                            incorrectasDataForms += DataForms.incorrectasPersonalServicios;

                            incorrectasDataForms += DataForms.incorrectasPlanchasL;
                            incorrectasDataForms += DataForms.incorrectasPersonalPlanchas;

                            incorrectasDataForms += DataForms.incorrectasAreaLozaL;
                            incorrectasDataForms += DataForms.incorrectasPersonalLoza;

                            incorrectasDataForms += DataForms.incorrectasBañosL;
                            incorrectasDataForms += DataForms.incorrectasPersonaAseo;

                            incorrectasDataForms += DataForms.incorrectasJuegosL;

                            // Calcular las penalizaciones
                            incorrectasDataForms = incorrectasDataForms * 5;

                            // Calcular las demás cantidades
                            int[] sabores2 = Array.ConvertAll(DataForms.sabor, s => int.Parse(s));

                            // Crear una lista para almacenar si el sabor es bueno (1) o malo (0)
                            List<bool> resultadosSabor2 = new List<bool>();

                            for (int i = 0; i < sabores.Length; i++)
                            {
                                // Obtener el valor de sabor (1 o 0)
                                int sabor = sabores[i];

                                // Verificar si el sabor es bueno (1)
                                bool esBueno2 = sabor == 1;
                                resultadosSabor2.Add(esBueno2);
                            }

                            // Contar cuántos sabores son buenos
                            int countBien2 = (6 - resultadosSabor2.Count(r => r)) * 5;
                            int cantidad3 = (5 - cant) * 5;
                            int cantidad4 = (DataForms.documentos[4] == "0") ? 5 : 0;
                            int cantidad5 = (DataForms.cloracion == 0) ? 5 : 0;

                            // Sumar las penalizaciones adicionales
                            int totalPenalizaciones = incorrectasDataForms + countBien2 + cantidad3 + cantidad4 + cantidad5 + contadorFueraDelRango;
                            Console.WriteLine(cant + " " + totalPenalizaciones + $"dataforms {incorrectasDataForms}" + $"sabor {countBien2}" + $"checks {cantidad3}" + $"documentos{cantidad4}" + $"cloracion {cantidad5} + {contadorFueraDelRango}");

                            // Calcular la primera calificación
                            int primeraCalificacion = 100 - totalPenalizaciones;

                            worksheet.Cells["H6"].Value = primeraCalificacion;

                            // Guardar el archivo Excel en el MemoryStream
                            package.SaveAs(memoryStream);
                        }

                        // Convertir el MemoryStream a un archivo PDF usando Aspose.Cells
                        using (var excelStream = new MemoryStream(memoryStream.ToArray()))
                        {
                            var workbook = new Workbook(excelStream);
                            var pdfSaveOptions = new PdfSaveOptions
                            {
                                Compliance = PdfCompliance.PdfA1b
                            };
                            workbook.Save(pdfFilePath, pdfSaveOptions);
                        }
                    }

                    MessageBox.Show("El archivo PDF se ha guardado exitosamente en la ubicación seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            ExportToPdf();
        }
    }
}







