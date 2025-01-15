using Aspose.Cells.Rendering;
using Aspose.Cells;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using System.Linq;

namespace App
{
    public partial class FormHistorial : Form
    {
        public string rutaArchivo;
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public FormHistorial()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            InitializeComponent();
        }
        private void FormHistorial_Load(object sender, EventArgs e)
        {
            if (CacheUsuario.tipoUsuario == "administrador")
            {
                panel5.Visible = true;
                btnResdaldo.Visible = true;
                btnAdmin.Visible = true;
                btnBorrar.Visible = true;
                panelBorrar.Visible = true;
            }

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string consulta = "SELECT * FROM reporte";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
                conn.Close();
            }
        }
        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            DataForms.LimpiarDatos();
            FormMenu2 menu = new FormMenu2();
            menu.Show();
            this.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (calendario.Visible == true && btn_calendario.Visible == true)
            {
                calendario.Visible = false;
                btn_calendario.Visible = false;
            }
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                string encargado = txb_Gerente.Text;
                string sucursal = txb_sucursal.Text;
                string fecha = txb_fecha.Text;
                string auditor = txb_auditor.Text;

                // IF para buscar los cuatro datos
                if (string.IsNullOrEmpty(encargado) && string.IsNullOrEmpty(sucursal) &&
                    string.IsNullOrEmpty(fecha) && string.IsNullOrEmpty(auditor))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM reporte WHERE Encargado = @encargado AND Sucursal = @sucursal AND Fecha = @fecha AND Auditor = @auditor", conn);
                    cmd.Parameters.AddWithValue("@encargado", encargado);
                    cmd.Parameters.AddWithValue("@sucursal", sucursal);
                    cmd.Parameters.AddWithValue("@fecha", calendario.SelectionRange.Start.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@auditor", auditor);

                    SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró ningún reporte con esos datos.");
                    }
                }
                // IF para buscar solo gerente
                else if (!string.IsNullOrEmpty(encargado))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM reporte WHERE Encargado = @encargado", conn);
                    cmd.Parameters.AddWithValue("@encargado", encargado);

                    SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró ningún Encargado con ese nombre.");
                    }
                }
                // IF para buscar solo sucursal
                else if (!string.IsNullOrEmpty(sucursal))
                {
                    conn.Open();
                    SQLiteCommand cmd2 = new SQLiteCommand("SELECT * FROM reporte WHERE Sucursal = @sucursal", conn);
                    cmd2.Parameters.AddWithValue("@sucursal", sucursal);

                    SQLiteDataAdapter sda2 = new SQLiteDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró ninguna Sucursal con ese nombre.");
                    }
                }
                // IF para buscar solo fecha
                else if (!string.IsNullOrEmpty(fecha))
                {
                    conn.Open();
                    SQLiteCommand cmd2 = new SQLiteCommand("SELECT * FROM reporte WHERE Fecha = @fecha", conn);
                    cmd2.Parameters.AddWithValue("@fecha", calendario.SelectionRange.Start.ToString("yyyy-MM-dd"));

                    SQLiteDataAdapter sda2 = new SQLiteDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró reportes en la Fecha ingresada.");
                    }
                }
                // IF para buscar solo auditor
                else if (!string.IsNullOrEmpty(auditor))
                {
                    conn.Open();
                    SQLiteCommand cmd2 = new SQLiteCommand("SELECT * FROM reporte WHERE Auditor = @auditor", conn);
                    cmd2.Parameters.AddWithValue("@auditor", auditor);

                    SQLiteDataAdapter sda2 = new SQLiteDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró ningún Auditor con ese nombre.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una opción.");
                }
            }
        }
        private void Txb_fecha_Click(object sender, EventArgs e)
        {
            if (txb_fecha.Text == string.Empty)
            {
                txb_fecha.Text = DateTime.Now.ToString("d/MM/y");
            }
            calendario.Visible = true;
            btn_calendario.Visible = true;

        }
        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = calendario.SelectionRange.Start;
            txb_fecha.Text = fechaSeleccionada.ToShortDateString();
        }

        private void Btn_calendario_Click(object sender, EventArgs e)
        {
            btn_calendario.Visible = false;
            calendario.Visible = false;
        }
        private void Txb_fecha_TextChanged(object sender, EventArgs e)
        {
        }
        //DataGridView1
        public void Excel()
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
        public void ExportarExcel2()
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
                    string timestamp = DateTime.Now.ToString("yyyyMMdd");
                    string filePath = saveFileDialog.FileName;
                    string modifiedFilePath = Path.Combine(Directory.GetCurrentDirectory(), "FormatoMexabor.xlsx");

                    // Cargar el archivo Excel
                    FileInfo fileInfo = new FileInfo(modifiedFilePath);
                    // Crear un nuevo archivo de Excel utilizando EPPlus
                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        // Agregar información adicional antes de la tabla principal
                        worksheet.Cells["B1"].Value = DataForms.sucursal;
                        worksheet.Cells["B2"].Value = DataForms.encargado;
                        worksheet.Cells["B3"].Value = DataForms.auditor;
                        worksheet.Cells["B4"].Value = DataForms.fecha;
                        //Estacionamiento
                        for (int i = 0; i < DataForms.estacionamientoEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.estacionamientoEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 3].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.estacionamientoLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.estacionamientoLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 4].Value = result1;
                            }
                        }
                        //Comedor
                        for (int i = 0; i < DataForms.comedorEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.comedorEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 5].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.comedorLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.comedorLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 6].Value = result1;
                            }
                        }
                        //barra
                        for (int i = 0; i < DataForms.barraEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.barraEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 7].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.barraLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.barraLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 8].Value = result1;
                            }
                        }
                        //Tortilla
                        for (int i = 0; i < DataForms.tortillasEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.tortillasEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 9].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.tortillasLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.tortillasLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 10].Value = result1;
                            }
                        }
                        //Servicios
                        for (int i = 0; i < DataForms.serviciosEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.serviciosEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 11].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.serviciosLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.serviciosLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 12].Value = result1;
                            }
                        }
                        //Planchas
                        for (int i = 0; i < DataForms.planchasEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.planchasEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 13].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.planchasLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.planchasLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 14].Value = result1;
                            }
                        }
                        //Loza
                        for (int i = 0; i < DataForms.areaLozaEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.areaLozaEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 15].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.areaLozaLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.areaLozaLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 16].Value = result1;
                            }
                        }
                        //Baños
                        for (int i = 0; i < DataForms.bañosEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.bañosEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 17].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.bañosLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.bañosLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 18].Value = result1;
                            }
                        }
                        //Juegos
                        for (int i = 0; i < DataForms.juegosEstructura.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.juegosEstructura[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 19].Value = result1;
                            }
                        }
                        for (int i = 0; i < DataForms.juegosLimpieza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.juegosLimpieza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 20].Value = result1;
                            }
                        }
                        //Personal Planchas
                        for (int i = 0; i < DataForms.personalPlanchas.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.personalPlanchas[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 21].Value = result1;
                            }
                        }
                        //Personal Loza
                        for (int i = 0; i < DataForms.personalLoza.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.personalLoza[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 22].Value = result1;
                            }
                        }
                        //Personal Aseo
                        for (int i = 0; i < DataForms.personaAseo.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.personaAseo[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 23].Value = result1;
                            }
                        }
                        //PersonalTortilla
                        for (int i = 0; i < DataForms.personalTortilla.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.personalTortilla[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 24].Value = result1;
                            }
                        }
                        //Personal Barra
                        for (int i = 0; i < DataForms.personalBarra.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.personalBarra[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 25].Value = result1;
                            }
                        }
                        //Personal Mesas
                        for (int i = 0; i < DataForms.personalMesas.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.personalMesas[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 26].Value = result1;
                            }
                        }
                        //Personal Servicio
                        for (int i = 0; i < DataForms.personalServicios.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.personalServicios[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 27].Value = result1;
                            }
                        }
                        //Documentos
                        for (int i = 0; i < DataForms.documentos.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.documentos[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 28].Value = result1;
                            }
                        }
                        //Caja
                        for (int i = 0; i < DataForms.caja.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.caja[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 29].Value = result1;
                            }
                        }
                        //Almacen
                        for (int i = 0; i < DataForms.almacen.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.almacen[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 30].Value = result1;
                            }
                        }
                        //Ambiente
                        for (int i = 0; i < DataForms.ambiente.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.ambiente[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 31].Value = result1;
                            }
                        }
                        //Proveedores
                        for (int i = 0; i < DataForms.calificacionProovedores.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.calificacionProovedores[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 32].Value = result1;
                            }
                        }
                        //Herramienta
                        for (int i = 0; i < DataForms.herramienta.Length; i++)
                        {
                                worksheet.Cells[6 + i, 33].Value = DataForms.herramienta[i];
                        }
                        //Sabor
                        for (int i = 0; i < DataForms.sabor.Length; i++)
                        {
                            // Intentar convertir el string a int
                            if (int.TryParse(DataForms.sabor[i], out int result1))
                            {
                                worksheet.Cells[6 + i, 34].Value = result1;
                            }
                        }
                        //Temperatura
                        for (int i = 0; i < DataForms.temperatura.Length; i++)
                        {
                            worksheet.Cells[6 + i, 35].Value = DataForms.temperatura[i];
                        }
                        worksheet.Cells["AU6"].Value = DataForms.observacionGas;
                        worksheet.Cells["AU7"].Value = DataForms.observacionFumigacion; 
                        worksheet.Cells["AU8"].Value = DataForms.observacionTrampa;
                        worksheet.Cells["AU9"].Value = DataForms.observacionFilete;
                        worksheet.Cells["AU10"].Value = DataForms.observacionMasa;
                        worksheet.Cells["AU11"].Value = DataForms.observacionPostres;
                        worksheet.Cells["AU12"].Value = DataForms.observacionRefresco;
                        worksheet.Cells["AU13"].Value = DataForms.observacionCerveza;
                        worksheet.Cells["AU14"].Value = DataForms.observacionAlmacen;
                        worksheet.Cells["AU15"].Value = DataForms.observacionBasura;


                        // Autoajustar las columnas
                        worksheet.Cells.AutoFitColumns();

                        // Guardar el archivo Excel
                        MessageBox.Show("El archivo se ha guardado exitosamente en la ubicación seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FileInfo newFile = new FileInfo(filePath);
                        package.SaveAs(newFile);
                    }
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
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (calendario.Visible == true && btn_calendario.Visible == true)
                {
                    calendario.Visible = false;
                    btn_calendario.Visible = false;
                }
                txb_auditor.Text = "";
                txb_fecha.Text = "";
                txb_Gerente.Text = "";
                txb_sucursal.Text = "";
                btn_Exportar1.Text = "Exportar Reporte";

                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string consulta = "SELECT * FROM reporte";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conn);
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds;
                    conn.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private void FormHistorial_Click(object sender, EventArgs e)
        {
            if (calendario.Visible == true && btn_calendario.Visible == true)
            {
                calendario.Visible = false;
                btn_calendario.Visible = false;
            }
        }
        private void Txb_Gerente_Click(object sender, EventArgs e)
        {
            if (calendario.Visible == true && btn_calendario.Visible == true)
            {
                calendario.Visible = false;
                btn_calendario.Visible = false;
            }
        }

        private void Txb_auditor_Click(object sender, EventArgs e)
        {
            if (calendario.Visible == true && btn_calendario.Visible == true)
            {
                calendario.Visible = false;
                btn_calendario.Visible = false;
            }
        }
        private void Cbx_exportar_Click(object sender, EventArgs e)
        {
            if (calendario.Visible == true && btn_calendario.Visible == true)
            {
                calendario.Visible = false;
                btn_calendario.Visible = false;
            }
        }

        public void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataForms.LimpiarDatos();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                DatosFila datos = new DatosFila
                {
                    Fecha = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value),
                    Hora = filaSeleccionada.Cells["Hora"].Value.ToString(),
                    Sucursal = filaSeleccionada.Cells["Sucursal"].Value.ToString(),
                    Encargado = filaSeleccionada.Cells["Encargado"].Value.ToString(),
                    Auditor = filaSeleccionada.Cells["Auditor"].Value.ToString(),
                    EstacionamientoEstructura = filaSeleccionada.Cells["EstacionamientoEstructura"].Value.ToString(),
                    EstacionamientoLimpieza = filaSeleccionada.Cells["EstacionamientoLimpieza"].Value.ToString(),
                    ComedorEstructura = filaSeleccionada.Cells["ComedorEstructura"].Value.ToString(),
                    ComedorLimpieza = filaSeleccionada.Cells["ComedorLimpieza"].Value.ToString(),
                    BarraEstructura = filaSeleccionada.Cells["BarraEstructura"].Value.ToString(),
                    BarraLimpieza = filaSeleccionada.Cells["BarraLimpieza"].Value.ToString(),
                    TortillasLimpieza = filaSeleccionada.Cells["TortillasLimpieza"].Value.ToString(),
                    TortillasEstructura = filaSeleccionada.Cells["TortillaEstructura"].Value.ToString(),
                    ServiciosEstructura = filaSeleccionada.Cells["ServiciosEstructura"].Value.ToString(),
                    ServiciosLimpieza = filaSeleccionada.Cells["ServiciosLimpieza"].Value.ToString(),
                    PlanchasEstructura = filaSeleccionada.Cells["PlanchaEstrctura"].Value.ToString(),
                    PlanchasLimpieza = filaSeleccionada.Cells["PlanchasLimpieza"].Value.ToString(),
                    AreaLozaEstructura = filaSeleccionada.Cells["LozaEstructura"].Value.ToString(),
                    AreaLozaLimpieza = filaSeleccionada.Cells["LozaLimpieza"].Value.ToString(),
                    BanosEstructura = filaSeleccionada.Cells["BanioEstructura"].Value.ToString(),
                    BanosLimpieza = filaSeleccionada.Cells["BanioLimpieza"].Value.ToString(),
                    JuegosEstructura = filaSeleccionada.Cells["JuegosEstructura"].Value.ToString(),
                    JuegosLimpieza = filaSeleccionada.Cells["JuegosLimpieza"].Value.ToString(),
                    PersonalPlanchas = filaSeleccionada.Cells["PersonalPlanchas"].Value.ToString(),
                    PersonalLoza = filaSeleccionada.Cells["PersonalLoza"].Value.ToString(),
                    PersonalAseo = filaSeleccionada.Cells["PersonalAseo"].Value.ToString(),
                    PersonalTortilla = filaSeleccionada.Cells["PersonalTortillas"].Value.ToString(),
                    PersonalBarra = filaSeleccionada.Cells["PersonalBarra"].Value.ToString(),
                    PersonalMesa = filaSeleccionada.Cells["PersonalMesa"].Value.ToString(),
                    PersonalServicio = filaSeleccionada.Cells["PersonalServicio"].Value.ToString(),
                    Documentos = filaSeleccionada.Cells["Documentos"].Value.ToString(),
                    Caja = filaSeleccionada.Cells["Caja"].Value.ToString(),
                    Almacen = filaSeleccionada.Cells["Almacen"].Value.ToString(),
                    Ambiente = filaSeleccionada.Cells["Ambiente"].Value.ToString(),
                    CalificacionProovedores = filaSeleccionada.Cells["Proveedores"].Value.ToString(),
                    ExistenciaHerramienta = filaSeleccionada.Cells["Herramienta"].Value.ToString(),
                    CloracionAgua = filaSeleccionada.Cells["CloracionDeAgua"].Value.ToString(),
                    Temperatura = filaSeleccionada.Cells["Temperaturas"].Value.ToString(),
                    Sabor = filaSeleccionada.Cells["Sabor"].Value.ToString(),
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
                DateTime date = DateTime.Parse(datos.Hora);
                DataForms.hora = date.Date;
                DataForms.fecha = datos.Fecha.Date;
                DataForms.sucursal = datos.Sucursal;
                DataForms.encargado = datos.Encargado;
                DataForms.auditor = datos.Auditor;

                // Bucle para estacionamientoEstructura
                for (int i = 0; i < datos.EstacionamientoEstructura.Length; i++)
                {
                    DataForms.estacionamientoEstructura[i] = datos.EstacionamientoEstructura[i].ToString();
                }

                // Bucle para estacionamientoLimpieza
                for (int i = 0; i < datos.EstacionamientoLimpieza.Length; i++)
                {
                    DataForms.estacionamientoLimpieza[i] = datos.EstacionamientoLimpieza[i].ToString();
                }

                // Bucle para comedorEstructura
                for (int i = 0; i < datos.ComedorEstructura.Length; i++)
                {
                    DataForms.comedorEstructura[i] = datos.ComedorEstructura[i].ToString();
                }

                // Bucle para comedorLimpieza
                for (int i = 0; i < datos.ComedorLimpieza.Length; i++)
                {
                    DataForms.comedorLimpieza[i] = datos.ComedorLimpieza[i].ToString();
                }

                // Bucle para barraEstructura
                for (int i = 0; i < datos.BarraEstructura.Length; i++)
                {
                    DataForms.barraEstructura[i] = datos.BarraEstructura[i].ToString();
                }

                // Bucle para barraLimpieza
                for (int i = 0; i < datos.BarraLimpieza.Length; i++)
                {
                    DataForms.barraLimpieza[i] = datos.BarraLimpieza[i].ToString();
                }

                // Bucle para tortillasEstructura
                for (int i = 0; i < datos.TortillasEstructura.Length; i++)
                {
                    DataForms.tortillasEstructura[i] = datos.TortillasEstructura[i].ToString();
                }

                // Bucle para tortillasLimpieza
                for (int i = 0; i < datos.TortillasLimpieza.Length; i++)
                {
                    DataForms.tortillasLimpieza[i] = datos.TortillasLimpieza[i].ToString();
                }

                // Bucle para serviciosEstructura
                for (int i = 0; i < datos.ServiciosEstructura.Length; i++)
                {
                    DataForms.serviciosEstructura[i] = datos.ServiciosEstructura[i].ToString();
                }

                // Bucle para serviciosLimpieza
                for (int i = 0; i < datos.ServiciosLimpieza.Length; i++)
                {
                    DataForms.serviciosLimpieza[i] = datos.ServiciosLimpieza[i].ToString();
                }

                // Bucle para planchasEstructura
                for (int i = 0; i < datos.PlanchasEstructura.Length; i++)
                {
                    DataForms.planchasEstructura[i] = datos.PlanchasEstructura[i].ToString();
                }

                // Bucle para planchasLimpieza
                for (int i = 0; i < datos.PlanchasLimpieza.Length; i++)
                {
                    DataForms.planchasLimpieza[i] = datos.PlanchasLimpieza[i].ToString();
                }

                // Bucle para areaLozaEstructura
                for (int i = 0; i < datos.AreaLozaEstructura.Length; i++)
                {
                    DataForms.areaLozaEstructura[i] = datos.AreaLozaEstructura[i].ToString();
                }

                // Bucle para areaLozaLimpieza
                for (int i = 0; i < datos.AreaLozaLimpieza.Length; i++)
                {
                    DataForms.areaLozaLimpieza[i] = datos.AreaLozaLimpieza[i].ToString();
                }

                // Bucle para bañosEstructura
                for (int i = 0; i < datos.BanosEstructura.Length; i++)
                {
                    DataForms.bañosEstructura[i] = datos.BanosEstructura[i].ToString();
                }

                // Bucle para bañosLimpieza
                for (int i = 0; i < datos.BanosLimpieza.Length; i++)
                {
                    DataForms.bañosLimpieza[i] = datos.BanosLimpieza[i].ToString();
                }

                // Bucle para juegosEstructura
                for (int i = 0; i < datos.JuegosEstructura.Length; i++)
                {
                    DataForms.juegosEstructura[i] = datos.JuegosEstructura[i].ToString();
                }

                // Bucle para juegosLimpieza
                for (int i = 0; i < datos.JuegosLimpieza.Length; i++)
                {
                    DataForms.juegosLimpieza[i] = datos.JuegosLimpieza[i].ToString();
                }

                // Bucle para personalPlanchas
                for (int i = 0; i < datos.PersonalPlanchas.Length; i++)
                {
                    DataForms.personalPlanchas[i] = datos.PersonalPlanchas[i].ToString();
                }

                // Bucle para personalLoza
                for (int i = 0; i < datos.PersonalLoza.Length; i++)
                {
                    DataForms.personalLoza[i] = datos.PersonalLoza[i].ToString();
                }

                // Bucle para personaAseo
                for (int i = 0; i < datos.PersonalAseo.Length; i++)
                {
                    DataForms.personaAseo[i] = datos.PersonalAseo[i].ToString();
                }

                // Bucle para personalTortilla
                for (int i = 0; i < datos.PersonalTortilla.Length; i++)
                {
                    DataForms.personalTortilla[i] = datos.PersonalTortilla[i].ToString();
                }

                // Bucle para personalBarra
                for (int i = 0; i < datos.PersonalBarra.Length; i++)
                {
                    DataForms.personalBarra[i] = datos.PersonalBarra[i].ToString();
                }

                // Bucle para personalMesas
                for (int i = 0; i < datos.PersonalMesa.Length; i++)
                {
                    DataForms.personalMesas[i] = datos.PersonalMesa[i].ToString();
                }

                // Bucle para personalServicios
                for (int i = 0; i < datos.PersonalServicio.Length; i++)
                {
                    DataForms.personalServicios[i] = datos.PersonalServicio[i].ToString();
                }
                // Bucle para documentos
                for (int i = 0; i < datos.Documentos.Length; i++)
                {
                    DataForms.documentos[i] = datos.Documentos[i].ToString();
                }

                // Bucle para caja
                for (int i = 0; i < datos.Caja.Length; i++)
                {
                    DataForms.caja[i] = datos.Caja[i].ToString();
                }

                // Bucle para almacen
                for (int i = 0; i < datos.Almacen.Length; i++)
                {
                    DataForms.almacen[i] = datos.Almacen[i].ToString();
                }

                // Bucle para ambiente
                for (int i = 0; i < datos.Ambiente.Length; i++)
                {
                    DataForms.ambiente[i] = datos.Ambiente[i].ToString();
                }

                // Bucle para calificacionProovedores
                int j = 0;
                int k = 0;
                while (j < datos.CalificacionProovedores.Length)
                {
                    if (j < datos.CalificacionProovedores.Length - 1 &&
                        datos.CalificacionProovedores[j].ToString() == "1" &&
                        datos.CalificacionProovedores[j + 1].ToString() == "0")
                    {
                        DataForms.calificacionProovedores[k] = "10";
                        j += 2;
                        k += 1;
                    }
                    else
                    {
                        DataForms.calificacionProovedores[k] = datos.CalificacionProovedores[j].ToString();
                        j += 1;
                        k += 1;
                    }
                }
                
                for (int i = 0; i < datos.ExistenciaHerramienta.Length; i++)
                {
                    // Asignar cada carácter al arreglo de 'herramienta'  convirtiendo a int el string de 'datos.existenciaHerramienta'.
                    DataForms.herramienta[i] = int.Parse(datos.ExistenciaHerramienta[i].ToString());
                }
                //esta  informacion no se imprime pero es necesaria para completar algunos campos si se requiere.
                DataForms.traposCocina = DataForms.herramienta[2];
                DataForms.traposMesas = DataForms.herramienta[3];
                DataForms.traposBanios = DataForms.herramienta[4];
                DataForms.traposCaja = DataForms.herramienta[5];

                // Bucle para sabor
                for (int i = 0; i < datos.Sabor.Length; i++)
                {
                    DataForms.sabor[i] = datos.Sabor[i].ToString();
                }

                // Asignación directa para cloracion
                DataForms.cloracion = int.Parse(datos.CloracionAgua);

                // No se aplica el bucle a temperatura, ya que solo se asigna un valor directamente
                string[] temperatura = datos.Temperatura.Split(new[] { '°', 'C' }, StringSplitOptions.RemoveEmptyEntries);

                DataForms.temperatura = temperatura;
                DataForms.observacionAlmacen = datos.observacionAlmacen;
                DataForms.observacionGas = datos.observacionGas;
                DataForms.observacionFumigacion = datos.observacionFumigacion;
                DataForms.observacionTrampa = datos.observacionTrampa;
                DataForms.observacionFilete = datos.observacionFilete;
                DataForms.observacionMasa = datos.observacionMasa;
                DataForms.observacionPostres = datos.observacionPostres;
                DataForms.observacionRefresco = datos.observacionRefresco;
                DataForms.observacionCerveza = datos.observacionCerveza;
                DataForms.observacionBasura = datos.observacionBasura;
                DataForms.observacionMantenimiento = datos.observacionMantenimiento;
                DataForms.Contador();


                panel.Visible = true;
                refrescar.Enabled = false;
                txb_fecha.Enabled = false;
                btn_siguiente.Enabled = false;
                btn_buscar.Enabled = false;
                txb_auditor.Enabled = false;
                txb_Gerente.Enabled = false;
                txb_sucursal.Enabled = false;
                btn_Exportar1.Enabled = false;

                // Configurar DataGridView2 para usar DataSource
                List<DatosFila> listaDatos = new List<DatosFila> { datos };
                dataGridView2.DataSource = listaDatos;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            refrescar.Enabled = true;
            txb_fecha.Enabled = true;
            btn_siguiente.Enabled = true;
            btn_buscar.Enabled = true;
            txb_auditor.Enabled = true;
            txb_Gerente.Enabled = true;
            txb_sucursal.Enabled = true;
            btn_Exportar1.Enabled = true;
        }

        private void Txb_sucursal_Click_1(object sender, EventArgs e)
        {
            if (calendario.Visible == true && btn_calendario.Visible == true)
            {
                calendario.Visible = false;
                btn_calendario.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Excel();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            //lineas para verificar cuanto tarda en  ejecutar la creacion de  archivos
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ExportarExcel2();
            stopwatch.Stop();
            // Mostrar el tiempo transcurrido
            Console.WriteLine($"Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataForms.Contador();
            //lineas para verificar cuanto tarda en  ejecutar la creacion de  archivos
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ExportToPdf();
            stopwatch.Stop();
            // Mostrar el tiempo transcurrido
            Console.WriteLine($"Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");
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
                            worksheet.Cells["H2"].Value = "Fecha " + DataForms.fecha.ToString("dd/MM/yyyy");
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
                            }

                            // Asigna el promedio a la celda de Excel
                            worksheet.Cells["B63"].Value = promedioProveedores;

                            //trapos
                            Console.WriteLine(DataForms.traposBanios.ToString() + DataForms.traposCaja.ToString());
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
                            int countBien2 = (6 - resultadosSabor2.Count(r => r))  * 5;
                            int cantidad3 = (5 - cant) * 5;
                            int cantidad4 = (DataForms.documentos[4] == "0") ? 5 : 0;
                            int cantidad5 = (DataForms.cloracion == 0) ? 5 : 0;

                            // Sumar las penalizaciones adicionales
                            int totalPenalizaciones = incorrectasDataForms + countBien2 + cantidad3 + cantidad4 + cantidad5 + contadorFueraDelRango ;
                            
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
        private void button4_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }
        private void FormHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Primer diálogo de confirmación
            DialogResult primeraConfirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas borrar todos los registros de la tabla 'reporte'?",
                "Confirmación inicial",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (primeraConfirmacion == DialogResult.Yes)
            {
                // Segundo diálogo de confirmación
                DialogResult segundaConfirmacion = MessageBox.Show(
                    "Esta acción eliminará *todos* los registros permanentemente. ¿Deseas continuar?",
                    "Confirmación final",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (segundaConfirmacion == DialogResult.Yes)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(cadena))
                    {
                        try
                        {
                            connection.Open();

                            // Define la consulta SQL para borrar todos los registros
                            string query = "DELETE FROM reporte";

                            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();
                                MessageBox.Show(
                                    $"{rowsAffected} fila(s) eliminada(s) de la tabla 'reporte'.",
                                    "Operación completada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                connection.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Configurar el cuadro de diálogo para guardar archivos
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos SQLite (*.db)|*.db";
                saveFileDialog.Title = "Guardar respaldo de la base de datos";
                saveFileDialog.FileName = "Respaldo.db"; // Nombre predeterminado

                // Mostrar el cuadro de diálogo y verificar si el usuario seleccionó una ubicación
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Ruta del archivo original (base de datos actual)
                        string rutaOriginal = "C:\\Users\\PC\\Desktop\\Codigo Completo\\App\\App\\Datos.db"; // Reemplaza con la ruta de tu archivo .db

                        // Ruta seleccionada por el usuario
                        string rutaDestino = saveFileDialog.FileName;

                        // Copiar el archivo
                        File.Copy(rutaOriginal, rutaDestino, overwrite: true);

                        MessageBox.Show("Respaldo creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al crear el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

