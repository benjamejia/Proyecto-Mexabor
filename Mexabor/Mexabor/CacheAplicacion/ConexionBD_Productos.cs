using Mexabor.Almacen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexabor.CacheAplicacion
{
    public class ConexionBD_Productos
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        //Datos obtenidos de RevisionDeProductos
        static public long idAuditoria;
        static public string observaciones;
        static public int productos;
        static public int empacado;
        static public int calidad;
        static public void SubirProductos()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(cadena))
                {
                    connection.Open();
                    string query = @"INSERT INTO productosAlmacen
                             (ProductosRevisados, EmpacadosCorrectamente, CalidadCorrecta, Observaciones, id_auditoria)
                             VALUES
                             (@productos, @empacado, @calidad, @observaciones, @idAuditoria)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@productos", productos);
                        cmd.Parameters.AddWithValue("@empacado", empacado);
                        cmd.Parameters.AddWithValue("@calidad", calidad);
                        cmd.Parameters.AddWithValue("@observaciones", observaciones);
                        cmd.Parameters.AddWithValue("@idAuditoria", idAuditoria);

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
