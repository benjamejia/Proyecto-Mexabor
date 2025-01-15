using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mexabor.CacheAplicacion
{
    public class ConexionBD_Restaruante
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public static void SubirDatos()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();

                    // Insertar los datos
                    string insertQuery = @"INSERT INTO reporteRestaurante 
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
                    @estacionamientoEstructura, @estacionamientoLimpieza, 
                    @comedorEstructura, @comedorLimpieza, 
                    @barraEstructura, @barraLimpieza, 
                    @tortillasLimpieza, @tortillaEstructura, 
                    @serviciosEstructura, @serviciosLimpieza, 
                    @planchaEstructura, @planchasLimpieza, 
                    @lozaEstructura, @lozaLimpieza, 
                    @banioEstructura, @banioLimpieza, 
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
                        cmd.Parameters.AddWithValue("@sucursal", CacheFormsRestaurante.sucursal ?? "");
                        cmd.Parameters.AddWithValue("@encargado", CacheFormsRestaurante.gerente ?? "");
                        cmd.Parameters.AddWithValue("@auditor", CacheFormsRestaurante.auditor ?? "");
                        cmd.Parameters.AddWithValue("@fecha", CacheFormsRestaurante.fecha.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@hora", CacheFormsRestaurante.hora.ToString("HH:mm:ss"));

                        // Procesar listas como el conteo de los valores "1"
                        cmd.Parameters.AddWithValue("@estacionamientoEstructura", string.Join(",", CacheFormsRestaurante.estacionamientoEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@estacionamientoLimpieza", string.Join(",", CacheFormsRestaurante.estacionamientoLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@comedorEstructura", string.Join(",", CacheFormsRestaurante.comedorEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@comedorLimpieza", string.Join(",", CacheFormsRestaurante.comedorLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@barraEstructura", string.Join(",", CacheFormsRestaurante.barraEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@barraLimpieza", string.Join(",", CacheFormsRestaurante.barraLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@tortillasLimpieza", string.Join(",", CacheFormsRestaurante.tortillasLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@tortillaEstructura", string.Join(",", CacheFormsRestaurante.tortillasEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@serviciosEstructura", string.Join(",", CacheFormsRestaurante.serviciosEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@serviciosLimpieza", string.Join(",", CacheFormsRestaurante.serviciosLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@planchaEstructura", string.Join(",", CacheFormsRestaurante.planchasEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@planchasLimpieza", string.Join(",", CacheFormsRestaurante.planchasLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@lozaEstructura", string.Join(",", CacheFormsRestaurante.lozaEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@lozaLimpieza", string.Join(",", CacheFormsRestaurante.lozaLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@banioEstructura", string.Join(",", CacheFormsRestaurante.bañosEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@banioLimpieza", string.Join(",", CacheFormsRestaurante.bañosLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@juegosEstructura", string.Join(",", CacheFormsRestaurante.juegosEstructura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@juegosLimpieza", string.Join(",", CacheFormsRestaurante.juegosLimpieza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@personalPlanchas", string.Join(",", CacheFormsRestaurante.personalPlanchas.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@personalAseo", string.Join(",", CacheFormsRestaurante.personalAseo.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@personalLoza", string.Join(",", CacheFormsRestaurante.personalLoza.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@personalTortillas", string.Join(",", CacheFormsRestaurante.personalTortillas.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@personalBarra", string.Join(",", CacheFormsRestaurante.personalBarra.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@personalMesa", string.Join(",", CacheFormsRestaurante.personalMesas.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@personalServicio", string.Join(",", CacheFormsRestaurante.personalServicios.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@documentos", string.Join(",", CacheFormsRestaurante.documentos.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@caja", string.Join(",", CacheFormsRestaurante.caja.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@almacen", string.Join(",", CacheFormsRestaurante.almacen.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@ambiente", string.Join(",", CacheFormsRestaurante.ambiente.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@proveedores", string.Join(",", CacheFormsRestaurante.calificacionProveedores.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@herramienta", string.Join(",", CacheFormsRestaurante.herramienta.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@temperaturas", string.Join(",", CacheFormsRestaurante.temperatura.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@sabor", string.Join(",", CacheFormsRestaurante.sabor.Select(x => x.ToString())));
                        cmd.Parameters.AddWithValue("@cloracionDeAgua", CacheFormsRestaurante.cloracion);
                        cmd.Parameters.AddWithValue("@observacionGas", CacheFormsRestaurante.observaciones[0]);
                        cmd.Parameters.AddWithValue("@observacionFumigacion", CacheFormsRestaurante.observaciones[1]);
                        cmd.Parameters.AddWithValue("@observacionTrampa", CacheFormsRestaurante.observaciones[2]);
                        cmd.Parameters.AddWithValue("@observacionFilete", CacheFormsRestaurante.observaciones[3]);
                        cmd.Parameters.AddWithValue("@observacionMasa", CacheFormsRestaurante.observaciones[4]);
                        cmd.Parameters.AddWithValue("@observacionPostres", CacheFormsRestaurante.observaciones[5]);
                        cmd.Parameters.AddWithValue("@observacionRefresco", CacheFormsRestaurante.observaciones[6]);
                        cmd.Parameters.AddWithValue("@observacionCerveza", CacheFormsRestaurante.observaciones[7]);
                        cmd.Parameters.AddWithValue("@observacionAlmacen", CacheFormsRestaurante.observaciones[8]);
                        cmd.Parameters.AddWithValue("@observacionBasura", CacheFormsRestaurante.observaciones[9]);
                        cmd.Parameters.AddWithValue("@observacionMantenimiento", CacheFormsRestaurante.observaciones[10]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos: " + ex.Message);
            }
        }


    }
}
