using OfficeOpenXml;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace App
{
    public partial class FormAgua : Form
    {
        public string rutaArchivo;
        public bool Checado = false;
        public bool SegundoChecado = false;
        public bool TercerChecado = false;
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public FormAgua()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            InitializeComponent();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            Sabor();
            Temperatura();
            Cloracion();
            if (Checado == true && SegundoChecado == true && TercerChecado == true)
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(cadena))
                    {
                        conn.Open();

                        string insertQuery = @"INSERT INTO reporte 
                        (Sucursal, Encargado, Fecha, Hora, Auditor, 
                        EstacionamientoEstructura, EstacionamientoLimpieza, 
                        ComedorEstructura, ComedorLimpieza, 
                        BarraEstructura, BarraLimpieza, 
                        TortillasLimpieza, TortillaEstructura, 
                        ServiciosEstructura, ServiciosLimpieza, 
                        PlanchaEstrctura, PlanchasLimpieza, 
                        LozaEstructura, LozaLimpieza, 
                        BanioEstructura, BanioLimpieza, 
                        JuegosEstructura, JuegosLimpieza, 
                        PersonalPlanchas, PersonalLoza, PersonalAseo, PersonalTortillas, 
                        PersonalBarra, PersonalMesa, PersonalServicio, 
                        Documentos, Caja, Almacen, 
                        Ambiente, Proveedores, Herramienta, 
                        CloracionDeAgua, Temperaturas, Sabor,ObservacionGas,
                        ObservacionFumigacion,ObservacionTrampa,ObservacionFilete,
                        ObservacionMasa,ObservacionPostres,ObservacionRefresco,
                        ObservacionCerveza,ObservacionAlmacen,ObservacionBasura,observacionMantenimiento) 
                        VALUES 
                        (@sucursal, @encargado, @fecha, @hora, @auditor, 
                        @estacionamiento, @estacionamientoLimpieza, 
                        @comedorEstructura, @comedorLimpieza, 
                        @barraEstructura, @barraLimpieza, 
                        @tortillaLimpieza, @tortillaEstructura, 
                        @serviciosEstructura, @serviciosLimpieza, 
                        @planchaEstructura, @planchasLimpieza, 
                        @lozaEstructura, @lozaLimpieza, 
                        @bañoEstructura, @bañoLimpieza, 
                        @juegosEstructura, @juegosLimpieza, 
                        @personalPlanchas, @personalLoza, @personalAseo, @personalTortillas, 
                        @personalBarra, @personalMesa, @personalServicio, 
                        @documentos, @caja, @almacen, 
                        @ambiente, @proveedores, @herramienta, 
                        @cloracionDeAgua, @temperaturas, @sabor,@observacionGas,
                        @observacionFumigacion,@observacionTrampa,@observacionFilete,
                        @observacionMasa,@observacionPostres,@observacionRefresco,
                        @observacionCerveza,@observacionAlmacen,@observacionBasura,@observacionMantenimiento)";

                        using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@sucursal", DataForms.sucursal);
                            cmd.Parameters.AddWithValue("@encargado", DataForms.encargado);

                            // Extraer solo la parte de la fecha como cadena en formato "yyyy-MM-dd"
                            DateTime ahoraFecha = DateTime.Now;
                            string soloFecha = ahoraFecha.ToString("yyyy-MM-dd"); // Formato de solo fecha
                            cmd.Parameters.AddWithValue("@fecha", soloFecha);


                            // Extraer solo la parte de la hora como cadena
                            DateTime ahora = DateTime.Now;
                            string soloHora = ahora.ToString("HH:mm:ss");  // Convertir a string
                            cmd.Parameters.AddWithValue("@hora", soloHora);


                            cmd.Parameters.AddWithValue("@auditor", DataForms.auditor);

                            // Estacionamiento
                            cmd.Parameters.AddWithValue("@estacionamiento", string.Join("", DataForms.estacionamientoEstructura.Take(10)));
                            cmd.Parameters.AddWithValue("@estacionamientoLimpieza", string.Join("", DataForms.estacionamientoLimpieza.Take(10)));

                            // Comedor
                            cmd.Parameters.AddWithValue("@comedorEstructura", string.Join("", DataForms.comedorEstructura.Take(14)));
                            cmd.Parameters.AddWithValue("@comedorLimpieza", string.Join("", DataForms.comedorLimpieza.Take(13)));

                            // Barra
                            cmd.Parameters.AddWithValue("@barraEstructura", string.Join("", DataForms.barraEstructura.Take(8)));
                            cmd.Parameters.AddWithValue("@barraLimpieza", string.Join("", DataForms.barraLimpieza.Take(8)));

                            // Tortillas
                            cmd.Parameters.AddWithValue("@tortillaLimpieza", string.Join("", DataForms.tortillasLimpieza.Take(13)));
                            cmd.Parameters.AddWithValue("@tortillaEstructura", string.Join("", DataForms.tortillasEstructura.Take(13)));

                            // Servicios
                            cmd.Parameters.AddWithValue("@serviciosEstructura", string.Join("", DataForms.serviciosEstructura.Take(9)));
                            cmd.Parameters.AddWithValue("@serviciosLimpieza", string.Join("", DataForms.serviciosLimpieza.Take(9)));

                            // Planchas
                            cmd.Parameters.AddWithValue("@planchaEstructura", string.Join("", DataForms.planchasEstructura.Take(12)));
                            cmd.Parameters.AddWithValue("@planchasLimpieza", string.Join("", DataForms.planchasLimpieza.Take(12)));

                            // Lozas
                            cmd.Parameters.AddWithValue("@lozaEstructura", string.Join("", DataForms.areaLozaEstructura.Take(8)));
                            cmd.Parameters.AddWithValue("@lozaLimpieza", string.Join("", DataForms.areaLozaLimpieza.Take(7)));

                            // Baños
                            cmd.Parameters.AddWithValue("@bañoEstructura", string.Join("", DataForms.bañosEstructura.Take(13)));
                            cmd.Parameters.AddWithValue("@bañoLimpieza", string.Join("", DataForms.bañosLimpieza.Take(12)));

                            // Juegos
                            cmd.Parameters.AddWithValue("@juegosEstructura", string.Join("", DataForms.juegosEstructura.Take(6)));
                            cmd.Parameters.AddWithValue("@juegosLimpieza", string.Join("", DataForms.juegosLimpieza.Take(4)));

                            // Personal planchas
                            cmd.Parameters.AddWithValue("@personalPlanchas", string.Join("", DataForms.personalPlanchas.Take(7)));
                            cmd.Parameters.AddWithValue("@personalLoza", string.Join("", DataForms.personalLoza.Take(7)));

                            // Personal Aseo
                            cmd.Parameters.AddWithValue("@personalAseo", string.Join("", DataForms.personaAseo.Take(7)));
                            cmd.Parameters.AddWithValue("@personalTortillas", string.Join("", DataForms.personalTortilla.Take(7)));

                            // Personal Barra
                            cmd.Parameters.AddWithValue("@personalBarra", string.Join("", DataForms.personalBarra.Take(7)));
                            cmd.Parameters.AddWithValue("@personalMesa", string.Join("", DataForms.personalMesas.Take(7)));

                            // Personal Servicio
                            cmd.Parameters.AddWithValue("@personalServicio", string.Join("", DataForms.personalServicios.Take(7)));

                            // Documentos
                            cmd.Parameters.AddWithValue("@documentos", string.Join("", DataForms.documentos.Take(6)));

                            // Caja
                            cmd.Parameters.AddWithValue("@caja", string.Join("", DataForms.caja.Take(10)));

                            // Almacén
                            cmd.Parameters.AddWithValue("@almacen", string.Join("", DataForms.almacen.Take(8)));

                            // Ambiente
                            cmd.Parameters.AddWithValue("@ambiente", string.Join("", DataForms.ambiente.Take(3)));

                            // Proveedores
                            cmd.Parameters.AddWithValue("@proveedores", string.Join("", DataForms.calificacionProovedores.Take(10)));

                            // Herramienta
                            cmd.Parameters.AddWithValue("@herramienta", string.Join("", DataForms.herramienta));

                            // Cloración de Agua
                            cmd.Parameters.AddWithValue("@cloracionDeAgua", DataForms.cloracion);

                            // Temperaturas
                            cmd.Parameters.AddWithValue("@temperaturas", string.Join("", DataForms.temperatura.Take(6)));

                            // Sabor
                            cmd.Parameters.AddWithValue("@sabor", string.Join("", DataForms.sabor.Take(6)));

                            cmd.Parameters.AddWithValue("@observacionGas", DataForms.observacionGas);
                            cmd.Parameters.AddWithValue("@observacionFumigacion", DataForms.observacionFumigacion);
                            cmd.Parameters.AddWithValue("@observacionTrampa", DataForms.observacionTrampa);
                            cmd.Parameters.AddWithValue("@observacionFilete", DataForms.observacionFilete);
                            cmd.Parameters.AddWithValue("@observacionMasa", DataForms.observacionMasa);
                            cmd.Parameters.AddWithValue("@observacionPostres", DataForms.observacionPostres);
                            cmd.Parameters.AddWithValue("@observacionRefresco", DataForms.observacionRefresco);
                            cmd.Parameters.AddWithValue("@observacionCerveza", DataForms.observacionCerveza);
                            cmd.Parameters.AddWithValue("@observacionAlmacen", DataForms.observacionAlmacen);
                            cmd.Parameters.AddWithValue("@observacionBasura", DataForms.observacionBasura);
                            cmd.Parameters.AddWithValue("@observacionMantenimiento", DataForms.observacionMantenimiento);

                            foreach (SQLiteParameter parameter in cmd.Parameters)
                            {
                                Console.WriteLine(parameter.ParameterName + ": " + (parameter.Value ?? "NULL").ToString());
                            }

                            int rowsAffected = cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                        Btn_guardar.Enabled = false;
                        MessageBox.Show("Reporte Finalizado con Exito.");
                        this.Hide();
                        DataForms.Contador();
                        FormExportacion formExportacion = new FormExportacion();
                        formExportacion.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Hay opciones sin seleccionar.");
            }
        }


        public void Temperatura()
        {
            ComboBox[] cmb = { cb1, cb2, cb3, cb4, cb5, cb6 };
            for (int i = 0; i < cmb.Length; i++)
            {
                if (cmb[i].Text != string.Empty)
                {
                    DataForms.temperatura[i] = cmb[i].Text;
                    Checado = true;
                }
                else
                {
                    Checado = false;
                    break;
                }
            }
        }
        public void Cloracion()
        {
            if (rSi.Checked)
            {
                DataForms.cloracion = 1;
                TercerChecado = true;
            }
            else
            if (rNo.Checked)
            {
                DataForms.cloracion = 0;
                TercerChecado = true;
            }
            else
            {
                TercerChecado = false;
            }
        }
        public void Sabor()
        {
            RadioButton[] radioButtons = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12 };
            for (int i = 0; i < radioButtons.Length; i += 2)
            {
                if (radioButtons[i].Checked || radioButtons[i + 1].Checked)
                {
                    int index = i / 2;
                    if (radioButtons[i].Checked)
                    {
                        DataForms.sabor[index] = "1";
                    }
                    else
                    {
                        DataForms.sabor[index] = "0";
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

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            FormProveedoresHerramientas formProveedoresHerramientas = new FormProveedoresHerramientas();
            formProveedoresHerramientas.Show();
            this.Hide();
        }

        private void FormAgua_FormClosing(object sender, FormClosingEventArgs e)
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
        private void Cb1_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;
        }
        
        private void FormAgua_Load(object sender, EventArgs e)
        {
            ComboBox[] comboBoxes = { cb1, cb2, cb3, cb4, cb5, cb6 };
            RadioButton[] radioButtons = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, rSi, rNo };
            System.Windows.Forms.GroupBox[] groupBoxes = { g1, g2, g3, g4, g5, g6, g7 };
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].TabIndex = i;
            }
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].TabIndex = i;
            }
            for (int i = 0; i < groupBoxes.Length; i++)
            {
                groupBoxes[i].TabIndex = i;
            }
        }
    }
}
