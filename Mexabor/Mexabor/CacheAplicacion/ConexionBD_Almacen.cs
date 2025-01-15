using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexabor.CacheAplicacion
{
    public class ConexionBD_Almacen
    {
            private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            static public void SubirDatos()
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(cadena))
                    {
                        conn.Open();

                        string insertQuery = @"INSERT INTO reporteAlmacen 
                        (Sucursal, Gerente, Auditor, Fecha, Hora, 
                        SalidaEstructura, SalidaLimpieza, 
                        CocinaCalienteEstructura, CocinaCalienteLimpieza, 
                        CamaraEstructura, CamaraLimpieza, 
                        AlmacenEstructura, AlmacenLimpieza, 
                        AreaPersonalEstructura, AreaPersonalLimpieza, 
                        CocinaFriaEstructura, CocinaFriaLimpieza, 
                        CajasEstructura, CajasLimpieza)
                        VALUES 
                        (@sucursal, @gerente, @auditor, @fecha, @hora,  
                        @salidaEstructura, @salidaLimpieza, 
                        @cocinaCalienteEstructura, @cocinaCalienteLimpieza, 
                        @camaraEstructura, @camaraLimpieza, 
                        @almacenEstructura, @almacenLimpieza, 
                        @areaPersonalEstructura, @areaPersonalLimpieza, 
                        @cocinaFriaEstructura, @cocinaFriaLimpieza, 
                        @cajasEstructura, @cajasLimpieza)";

                        using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                        {
                            // Agregar los valores básicos
                            cmd.Parameters.AddWithValue("@sucursal", CacheFormsAlmacen.sucursal);
                            cmd.Parameters.AddWithValue("@gerente", CacheFormsAlmacen.gerente);
                            cmd.Parameters.AddWithValue("@auditor", CacheFormsAlmacen.auditor);

                            // Extraer solo la parte de la fecha como cadena en formato "yyyy-MM-dd"
                            DateTime ahoraFecha = DateTime.Now;
                            string soloFecha = ahoraFecha.ToString("yyyy-MM-dd"); // Formato de solo fecha
                            cmd.Parameters.AddWithValue("@fecha", soloFecha);

                            // Extraer solo la parte de la hora como cadena
                            DateTime ahora = DateTime.Now;
                            string soloHora = ahora.ToString("HH:mm:ss");  // Convertir a string
                            cmd.Parameters.AddWithValue("@hora", soloHora);

                            // Contar los valores 1 en cada lista antes de insertarlos
                            cmd.Parameters.AddWithValue("@salidaEstructura", CacheFormsAlmacen.salidaEstructura.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@salidaLimpieza", CacheFormsAlmacen.salidaLimpieza.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@cocinaCalienteEstructura", CacheFormsAlmacen.cocincaCalienteEstructura.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@cocinaCalienteLimpieza", CacheFormsAlmacen.cocinaCalienteLimpieza.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@camaraEstructura", CacheFormsAlmacen.camaraEstructura.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@camaraLimpieza", CacheFormsAlmacen.camaraLimpieza.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@almacenEstructura", CacheFormsAlmacen.almacenEstructura.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@almacenLimpieza", CacheFormsAlmacen.almacenLimpieza.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@areaPersonalEstructura", CacheFormsAlmacen.areaPersonalEstructura.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@areaPersonalLimpieza", CacheFormsAlmacen.areaPersonalLimpieza.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@cocinaFriaEstructura", CacheFormsAlmacen.cocinaFriaEstructura.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@cocinaFriaLimpieza", CacheFormsAlmacen.cocinaFriaLimpieza.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@cajasEstructura", CacheFormsAlmacen.cajasEstructura.Count(x => x == 1));
                            cmd.Parameters.AddWithValue("@cajasLimpieza", CacheFormsAlmacen.cajasLimpieza.Count(x => x == 1));

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al insertar datos: {ex.Message}");
                }
            }

        }
    }

