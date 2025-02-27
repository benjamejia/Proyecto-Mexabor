using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mexabor.CacheAplicacion;
using OfficeOpenXml;
using Syncfusion.Pdf.Parsing;
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
        private void GuardarEnCacheAlmacen(DatosAlmacen datos)
        {
            CacheFormsAlmacen.fecha = datos.Fecha;
            CacheFormsAlmacen.hora = Convert.ToDateTime(datos.Hora);
            CacheFormsAlmacen.sucursal = datos.Sucursal;
            CacheFormsAlmacen.gerente = datos.Gerente;
            CacheFormsAlmacen.auditor = datos.Auditor;
            CacheFormsAlmacen.id_auditoria = datos.Id;

            // Agregar los valores a las listas correspondientes
            CacheFormsAlmacen.salidaEstructura.Add(datos.SalidaEstructura);
            CacheFormsAlmacen.salidaLimpieza.Add(datos.SalidaLimpieza);
            CacheFormsAlmacen.cocincaCalienteEstructura.Add(datos.CocinaCalienteEstructura);
            CacheFormsAlmacen.cocinaCalienteLimpieza.Add(datos.CocinaCalienteLimpieza);
            CacheFormsAlmacen.camaraEstructura.Add(datos.CamaraEstructura);
            CacheFormsAlmacen.camaraLimpieza.Add(datos.CamaraLimpieza);
            CacheFormsAlmacen.almacenEstructura.Add(datos.AlmacenEstructura);
            CacheFormsAlmacen.almacenLimpieza.Add(datos.AlmacenLimpieza);
            CacheFormsAlmacen.areaPersonalEstructura.Add(datos.AreaPersonalEstructura);
            CacheFormsAlmacen.areaPersonalLimpieza.Add(datos.AreaPersonalLimpieza);
            CacheFormsAlmacen.cocinaFriaEstructura.Add(datos.CocinaFriaEstructura);
            CacheFormsAlmacen.cocinaFriaLimpieza.Add(datos.CocinaFriaLimpieza);
            CacheFormsAlmacen.cajasEstructura.Add(datos.CajasEstructura);
            CacheFormsAlmacen.cajasLimpieza.Add(datos.CajasLimpieza);
        }

        private void GuardarEnCacheRestaurante(DatosRestaurante datosFila)
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


            // Iterar sobre la cadena de dígitos
            for (int i = 0; i < datosFila.CalificacionProovedores.Length; i++)
            {
                // Convertir el carácter en entero
                if (int.TryParse(datosFila.CalificacionProovedores[i].ToString(), out int valor))
                {
                    // Comprobar si es el caso especial de "1" seguido de "0"
                    if (i < datosFila.CalificacionProovedores.Length - 1 &&
                        datosFila.CalificacionProovedores[i] == '1' && datosFila.CalificacionProovedores[i + 1] == '0')
                    {
                        CacheFormsRestaurante.calificacionProveedores.Add(10);
                        i++; // Saltar el siguiente elemento porque ya fue procesado como "10"
                    }
                    else
                    {
                        CacheFormsRestaurante.calificacionProveedores.Add(valor);
                    }
                }
                else
                {
                    // Manejar el caso en que el carácter no pueda ser convertido a int
                    Console.WriteLine($"Carácter inválido en la calificación: {datosFila.CalificacionProovedores[i]}");
                }
            }

            CacheFormsRestaurante.herramienta = datosFila.ExistenciaHerramienta.Select(c => int.Parse(c.ToString())).ToList();

            //for para guardar la temperatura de manera correcta y no indivualmente digito por digito
            if (!string.IsNullOrEmpty(datosFila.Temperatura) && datosFila.Temperatura.Length % 2 == 0)
            {
                for (int i = 0; i < datosFila.Temperatura.Length; i += 2) // Iterar de dos en dos
                {
                    // Combinar los caracteres consecutivos en un número de dos dígitos
                    string numero = $"{datosFila.Temperatura[i]}{datosFila.Temperatura[i + 1]}";

                    // Convertir el número a entero y agregarlo a la lista
                    CacheFormsRestaurante.temperatura.Add(int.Parse(numero));
                }
            }

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
            GenerarExcelRestaurante.ExcelTablaCompleta(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ExcelTablaDesglozada();
            GenerarExcelRestaurante.ExportarDatosExcel();
        }
        public void dobleClicAlmacen(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0)
            {
                    DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                DatosAlmacen datosAlmacen = new DatosAlmacen
                {
                    Id = TryConvertToInt(filaSeleccionada.Cells["id_auditoria"].Value)/*
                    Sucursal = filaSeleccionada.Cells["Sucursal"].Value?.ToString(),
                    Gerente = filaSeleccionada.Cells["Gerente"].Value?.ToString(),
                    Auditor = filaSeleccionada.Cells["Auditor"].Value?.ToString(),

                    // Manejo seguro de fecha
                    Fecha = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value),
                    Hora = filaSeleccionada.Cells["Hora"].Value.ToString(),
                    // Conversión segura a int
                    SalidaEstructura = TryConvertToInt(filaSeleccionada.Cells["SalidaEstructura"].Value),
                    SalidaLimpieza = TryConvertToInt(filaSeleccionada.Cells["SalidaLimpieza"].Value),
                    CocinaCalienteEstructura = TryConvertToInt(filaSeleccionada.Cells["CocinaCalienteEstructura"].Value),
                    CocinaCalienteLimpieza = TryConvertToInt(filaSeleccionada.Cells["CocinaCalienteLimpieza"].Value),
                    CamaraEstructura = TryConvertToInt(filaSeleccionada.Cells["CamaraEstructura"].Value),
                    CamaraLimpieza = TryConvertToInt(filaSeleccionada.Cells["CamaraLimpieza"].Value),
                    AlmacenEstructura = TryConvertToInt(filaSeleccionada.Cells["AlmacenEstructura"].Value),
                    AlmacenLimpieza = TryConvertToInt(filaSeleccionada.Cells["AlmacenLimpieza"].Value),
                    AreaPersonalEstructura = TryConvertToInt(filaSeleccionada.Cells["AreaPersonalEstructura"].Value),
                    AreaPersonalLimpieza = TryConvertToInt(filaSeleccionada.Cells["AreaPersonalLimpieza"].Value),
                    CocinaFriaEstructura = TryConvertToInt(filaSeleccionada.Cells["CocinaFriaEstructura"].Value),
                    CocinaFriaLimpieza = TryConvertToInt(filaSeleccionada.Cells["CocinaFriaLimpieza"].Value),
                    CajasEstructura = TryConvertToInt(filaSeleccionada.Cells["CajasEstructura"].Value),
                    CajasLimpieza = TryConvertToInt(filaSeleccionada.Cells["CajasLimpieza"].Value)*/
                };

                //GuardarEnCacheAlmacen(datosAlmacen);
                    // Configurar DataGridView2 para usar DataSource
                    //List<DatosAlmacen> listaDatos = new List<DatosAlmacen> { datosAlmacen };
                    //dataGridView2.DataSource = listaDatos;

                CargarAuditoriaYProductos(datosAlmacen.Id);
                panelDobleClick.Visible = true;
                    btnCerrar.Enabled = false;
                    btnBuscar.Enabled = false;
            }

        }
        private int TryConvertToInt(object value)
        {
            if (value == null) return 0;

            if (int.TryParse(value.ToString()?.Replace(",", ""), out int result))
            {
                return result;
            }

            return 0; // Retorna 0 si el valor no se puede convertir
        }
        private void CargarAuditoriaYProductos(int idAuditoria)
        {
            string query = @"
        SELECT r.*, p.id_producto, p.ProductosRevisados, p.EmpacadosCorrectamente, 
               p.CalidadCorrecta, p.Observaciones 
        FROM reporteAlmacen r
        LEFT JOIN productosAlmacen p ON r.id_auditoria = p.id_auditoria
        WHERE r.id_auditoria = @idAuditoria";

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idAuditoria", idAuditoria);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                }
            }
        }

        public void dobleClicRestaurante(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                DatosRestaurante datosRestaurante = new DatosRestaurante
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
                GuardarEnCacheRestaurante(datosRestaurante);
                // Configurar DataGridView2 para usar DataSource
                List<DatosRestaurante> listaDatos = new List<DatosRestaurante> { datosRestaurante };
                dataGridView2.DataSource = listaDatos;
                panelDobleClick.Visible = true;
                btnCerrar.Enabled = false;
                btnBuscar.Enabled = false;

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.Text == "Reporte de Restaurante")
            {
                dobleClicRestaurante(sender, e);
            } 
            else if (comboBox1.Text == "Reporte de Almacen")
            {
                dobleClicAlmacen(sender, e);

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panelDobleClick.Visible = false;
            CacheFormsRestaurante.LimpiarCache();
            btnCerrar.Enabled = true;
            btnBuscar.Enabled = true;

        }

        //Queda pendiente a mejorar ya que es un codigo pegado del antiguo proyecto.
        private void button3_Click(object sender, EventArgs e)
        {
            string encargado = txbGerente.Text;
            string sucursal = txbSucursal.Text;
            string fecha = txbFecha.Text;
            string auditor = txbAuditor.Text;
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // IF para buscar los cuatro datos
                if (string.IsNullOrEmpty(encargado) && string.IsNullOrEmpty(sucursal) &&
                string.IsNullOrEmpty(fecha) && string.IsNullOrEmpty(auditor))
                {
                    MessageBox.Show("Ingresa un dato.");
                    return;
                }
                if (txbGerente.Text != string.Empty && txbSucursal.Text != string.Empty && txbAuditor.Text != string.Empty)
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM reporteRestaurante WHERE Sucursal = @sucursal AND Encargado = @encargado AND Auditor = @auditor", conn);
                    cmd.Parameters.AddWithValue("@encargado", encargado);
                    cmd.Parameters.AddWithValue("@sucursal", sucursal);
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
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM reporteRestaurante WHERE Encargado = @encargado", conn);
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
                    SQLiteCommand cmd2 = new SQLiteCommand("SELECT * FROM reporteRestaurante WHERE Sucursal = @sucursal", conn);
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
                // IF para buscar solo auditor
                else if (!string.IsNullOrEmpty(auditor))
                {
                    conn.Open();
                    SQLiteCommand cmd2 = new SQLiteCommand("SELECT * FROM reporteRestaurante WHERE Auditor = @auditor", conn);
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
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine(string.Join(", ", CacheFormsRestaurante.temperatura));
            GenerarExcelRestaurante.ExcelTablaDesglozada();
        }
    }
}
