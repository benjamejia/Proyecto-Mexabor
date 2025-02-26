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

                            // Obtener la fecha y la hora en un solo instante
                            DateTime ahora = DateTime.Now;

                            // Extraer solo la parte de la fecha en formato "yyyy-MM-dd"
                            string soloFecha = ahora.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                            // Extraer solo la parte de la hora en formato "HH:mm:ss"
                            string soloHora = ahora.ToString("HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                            // Asignar los valores a los parámetros
                            cmd.Parameters.AddWithValue("@fecha", soloFecha);
                            cmd.Parameters.AddWithValue("@hora", soloHora);

                            //se convierte en string y se separa por comas cada dato
                            cmd.Parameters.AddWithValue("@salidaEstructura", string.Join(",", CacheFormsAlmacen.salidaEstructura.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@salidaLimpieza", string.Join(",", CacheFormsAlmacen.salidaLimpieza.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@cocinaCalienteEstructura", string.Join(",", CacheFormsAlmacen.cocincaCalienteEstructura.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@cocinaCalienteLimpieza", string.Join(",", CacheFormsAlmacen.cocinaCalienteLimpieza.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@camaraEstructura", string.Join(",", CacheFormsAlmacen.camaraEstructura.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@camaraLimpieza", string.Join(",", CacheFormsAlmacen.camaraLimpieza.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@almacenEstructura", string.Join(",", CacheFormsAlmacen.almacenEstructura.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@almacenLimpieza", string.Join(",", CacheFormsAlmacen.almacenLimpieza.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@areaPersonalEstructura", string.Join(",", CacheFormsAlmacen.areaPersonalEstructura.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@areaPersonalLimpieza", string.Join(",", CacheFormsAlmacen.areaPersonalLimpieza.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@cocinaFriaEstructura", string.Join(",", CacheFormsAlmacen.cocinaFriaEstructura.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@cocinaFriaLimpieza", string.Join(",", CacheFormsAlmacen.cocinaFriaLimpieza.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@cajasEstructura", string.Join(",", CacheFormsAlmacen.cajasEstructura.Select(x => x.ToString())));
                            cmd.Parameters.AddWithValue("@cajasLimpieza", string.Join(",", CacheFormsAlmacen.cajasLimpieza.Select(x => x.ToString())));


                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();
                        }
                        using (SQLiteCommand cmd = new SQLiteCommand("SELECT last_insert_rowid();", conn))
                        {
                            ConexionBD_Productos.idAuditoria = (long)cmd.ExecuteScalar();
                        }

                        Console.WriteLine($"ID de la auditoría insertada: {ConexionBD_Productos.idAuditoria}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al insertar datos: {ex.Message}");
                }
            }

        }
    }

