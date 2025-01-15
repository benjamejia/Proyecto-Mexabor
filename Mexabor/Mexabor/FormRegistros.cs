using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mexabor.CacheAplicacion;
using OfficeOpenXml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mexabor
{
    public partial class FormRegistros : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public FormRegistros()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
        }
        public void ExcelTablaDesglozada()
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
                        { 34, CacheFormsRestaurante.temperatura },
                        { 35, CacheFormsRestaurante.sabor },
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

        private void RellenarDatos(ExcelWorksheet worksheet, int columnaInicio, int filaInicio, List<int> datos)
        {
            for (int i = 0; i < datos.Count; i++)
            {
                worksheet.Cells[filaInicio + i, columnaInicio].Value = datos[i];
            }
        }
        private void GuardarEnCache(DatosFila datosFila)
        {
            // Convertir y asignar listas de enteros
            CacheFormsRestaurante.fecha = datosFila.Fecha;
            CacheFormsRestaurante.auditor = datosFila.Auditor;
            CacheFormsRestaurante.gerente = datosFila.Encargado;
            CacheFormsRestaurante.sucursal = datosFila.Sucursal;
            CacheFormsRestaurante.estacionamientoEstructura = datosFila.EstacionamientoEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.estacionamientoLimpieza = datosFila.EstacionamientoLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.comedorEstructura = datosFila.ComedorEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.comedorLimpieza = datosFila.ComedorLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.barraEstructura = datosFila.BarraEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.barraLimpieza = datosFila.BarraLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.tortillasEstructura = datosFila.TortillasEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.tortillasLimpieza = datosFila.TortillasLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.serviciosEstructura = datosFila.ServiciosEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.serviciosLimpieza = datosFila.ServiciosLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.planchasEstructura = datosFila.PlanchasEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.planchasLimpieza = datosFila.PlanchasLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.lozaEstructura = datosFila.AreaLozaEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.lozaLimpieza = datosFila.AreaLozaLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.bañosEstructura = datosFila.BanosEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.bañosLimpieza = datosFila.BanosLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.juegosEstructura = datosFila.JuegosEstructura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.juegosLimpieza = datosFila.JuegosLimpieza.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.personalPlanchas = datosFila.PersonalPlanchas.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.personalLoza = datosFila.PersonalLoza.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.personalAseo = datosFila.PersonalAseo.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.personalTortillas = datosFila.PersonalTortilla.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.personalBarra = datosFila.PersonalBarra.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.personalServicios = datosFila.PersonalServicio.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.personalMesas = datosFila.PersonalMesa.Select(c => int.Parse(c.ToString())).ToList();

            CacheFormsRestaurante.documentos = datosFila.Documentos.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.almacen = datosFila.Almacen.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.caja = datosFila.Caja.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.ambiente = datosFila.Ambiente.Select(c => int.Parse(c.ToString())).ToList();

            // Asignar listas de strings
            CacheFormsRestaurante.calificacionProveedores = datosFila.CalificacionProovedores.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.herramienta = datosFila.ExistenciaHerramienta.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.temperatura = datosFila.Temperatura.Select(c => int.Parse(c.ToString())).ToList();
            CacheFormsRestaurante.sabor = datosFila.Sabor.Select(c => int.Parse(c.ToString())).ToList();

            // Asignar valores individuales
            CacheFormsRestaurante.cloracion = int.Parse(datosFila.CloracionAgua);

            // Asignar observaciones
            CacheFormsRestaurante.observaciones[0] = datosFila.observacionGas;
            CacheFormsRestaurante.observaciones[1] = datosFila.observacionFumigacion;
            CacheFormsRestaurante.observaciones[2] = datosFila.observacionTrampa;
            CacheFormsRestaurante.observaciones[3] = datosFila.observacionFilete;
            CacheFormsRestaurante.observaciones[4] = datosFila.observacionMasa;
            CacheFormsRestaurante.observaciones[5] = datosFila.observacionPostres;
            CacheFormsRestaurante.observaciones[6] = datosFila.observacionRefresco;
            CacheFormsRestaurante.observaciones[7] = datosFila.observacionCerveza;
            CacheFormsRestaurante.observaciones[8] = datosFila.observacionAlmacen;
            CacheFormsRestaurante.observaciones[9] = datosFila.observacionBasura;
            CacheFormsRestaurante.observaciones[10] = datosFila.observacionMantenimiento;
            Console.WriteLine("Datos guardados en cacheRestaurante:");
            Console.WriteLine($"EstacionamientoEstructura: {string.Join(",", CacheFormsRestaurante.estacionamientoEstructura)}");
            Console.WriteLine($"ComedorEstructura: {string.Join(",", CacheFormsRestaurante.comedorEstructura)}");

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjustesAvanzados ajustesAvanzados = new AjustesAvanzados();
            ajustesAvanzados.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Reporte de Restaurante")
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string consulta = "SELECT * FROM reporteRestaurante";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds;
                    conn.Close();
                }
            }
            else if (comboBox1.Text == "Reporte de Almacen")
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string consulta = "SELECT * FROM ReporteAlmacen";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds;
                    conn.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Reporte de Restaurante")
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string consulta = "SELECT * FROM reporteRestaurante";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds;
                    conn.Close();
                }
            }
            else if (comboBox1.Text == "Reporte de Almacen")
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string consulta = "SELECT * FROM ReporteAlmacen";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds;
                    conn.Close();
                }
            }
            else if (comboBox1.Text == "Productos de Almacen")
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string consulta = "SELECT * FROM ProductosAlmacen";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds;
                    conn.Close();
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            GenerarExcel.ExcelTablaCompleta(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcelTablaDesglozada();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                DatosFila datosFila = new DatosFila
                {
                    Fecha = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value),
                    Hora = filaSeleccionada.Cells["Hora"].Value.ToString(),
                    Sucursal = filaSeleccionada.Cells["Sucursal"].Value.ToString(),
                    Encargado = filaSeleccionada.Cells["Encargado"].Value.ToString(),
                    Auditor = filaSeleccionada.Cells["Auditor"].Value.ToString(),
                    EstacionamientoEstructura = filaSeleccionada.Cells["EstacionamientoEstructura"].Value.ToString().Replace(",", ""),
                    EstacionamientoLimpieza = filaSeleccionada.Cells["EstacionamientoLimpieza"].Value.ToString().Replace(",", ""),
                    ComedorEstructura = filaSeleccionada.Cells["ComedorEstructura"].Value.ToString().Replace(",", ""),
                    ComedorLimpieza = filaSeleccionada.Cells["ComedorLimpieza"].Value.ToString().Replace(",", ""),
                    BarraEstructura = filaSeleccionada.Cells["BarraEstructura"].Value.ToString().Replace(",", ""),
                    BarraLimpieza = filaSeleccionada.Cells["BarraLimpieza"].Value.ToString().Replace(",", ""),
                    TortillasLimpieza = filaSeleccionada.Cells["TortillasLimpieza"].Value.ToString().Replace(",", ""),
                    TortillasEstructura = filaSeleccionada.Cells["TortillaEstructura"].Value.ToString().Replace(",", ""),
                    ServiciosEstructura = filaSeleccionada.Cells["ServiciosEstructura"].Value.ToString().Replace(",", ""),
                    ServiciosLimpieza = filaSeleccionada.Cells["ServiciosLimpieza"].Value.ToString().Replace(",", ""),
                    PlanchasEstructura = filaSeleccionada.Cells["PlanchaEstrctura"].Value.ToString().Replace(",", ""),
                    PlanchasLimpieza = filaSeleccionada.Cells["PlanchasLimpieza"].Value.ToString().Replace(",", ""),
                    AreaLozaEstructura = filaSeleccionada.Cells["LozaEstructura"].Value.ToString().Replace(",", ""),
                    AreaLozaLimpieza = filaSeleccionada.Cells["LozaLimpieza"].Value.ToString().Replace(",", ""),
                    BanosEstructura = filaSeleccionada.Cells["BanioEstructura"].Value.ToString().Replace(",", ""),
                    BanosLimpieza = filaSeleccionada.Cells["BanioLimpieza"].Value.ToString().Replace(",", ""),
                    JuegosEstructura = filaSeleccionada.Cells["JuegosEstructura"].Value.ToString().Replace(",", ""),
                    JuegosLimpieza = filaSeleccionada.Cells["JuegosLimpieza"].Value.ToString().Replace(",", ""),
                    PersonalPlanchas = filaSeleccionada.Cells["PersonalPlanchas"].Value.ToString().Replace(",", ""),
                    PersonalLoza = filaSeleccionada.Cells["PersonalLoza"].Value.ToString().Replace(",", ""),
                    PersonalAseo = filaSeleccionada.Cells["PersonalAseo"].Value.ToString().Replace(",", ""),
                    PersonalTortilla = filaSeleccionada.Cells["PersonalTortillas"].Value.ToString().Replace(",", ""),
                    PersonalBarra = filaSeleccionada.Cells["PersonalBarra"].Value.ToString().Replace(",", ""),
                    PersonalMesa = filaSeleccionada.Cells["PersonalMesa"].Value.ToString().Replace(",", ""),
                    PersonalServicio = filaSeleccionada.Cells["PersonalServicio"].Value.ToString().Replace(",", ""),
                    Documentos = filaSeleccionada.Cells["Documentos"].Value.ToString().Replace(",", ""),
                    Caja = filaSeleccionada.Cells["Caja"].Value.ToString().Replace(",", ""),
                    Almacen = filaSeleccionada.Cells["Almacen"].Value.ToString().Replace(",", ""),
                    Ambiente = filaSeleccionada.Cells["Ambiente"].Value.ToString().Replace(",", ""),
                    CalificacionProovedores = filaSeleccionada.Cells["Proveedores"].Value.ToString().Replace(",", ""),
                    ExistenciaHerramienta = filaSeleccionada.Cells["Herramienta"].Value.ToString().Replace(",", ""),
                    CloracionAgua = filaSeleccionada.Cells["CloracionDeAgua"].Value.ToString().Replace(",", ""),
                    Temperatura = filaSeleccionada.Cells["Temperaturas"].Value.ToString().Replace(",", ""),
                    Sabor = filaSeleccionada.Cells["Sabor"].Value.ToString().Replace(",", ""),
                    observacionGas = filaSeleccionada.Cells["ObservacionGas"].Value.ToString(),
                    observacionFumigacion = filaSeleccionada.Cells["ObservacionFumigacion"].Value.ToString(),
                    observacionTrampa = filaSeleccionada.Cells["ObservacionTrampa"].Value.ToString(),
                    observacionFilete = filaSeleccionada.Cells["ObservacionFilete"].Value.ToString(),
                    observacionMasa = filaSeleccionada.Cells["ObservacionMasa"].Value.ToString(),
                    observacionPostres = filaSeleccionada.Cells["ObservacionPostres"].Value.ToString(),
                    observacionRefresco = filaSeleccionada.Cells["ObservacionRefresco"].Value.ToString(),
                    observacionCerveza = filaSeleccionada.Cells["ObservacionCerveza"].Value.ToString(),
                    observacionAlmacen = filaSeleccionada.Cells["ObservacionAlmacen"].Value.ToString(),
                    observacionBasura = filaSeleccionada.Cells["ObservacionBasura"].Value.ToString(),
                    observacionMantenimiento = filaSeleccionada.Cells["ObservacionMantenimiento"].Value.ToString()
                };
                GuardarEnCache(datosFila);
                // Configurar DataGridView2 para usar DataSource
                List<DatosFila> listaDatos = new List<DatosFila> { datosFila };
                dataGridView2.DataSource = listaDatos;
                panelDobleClick.Visible = true;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panelDobleClick.Visible = false;
        }
    }
}
