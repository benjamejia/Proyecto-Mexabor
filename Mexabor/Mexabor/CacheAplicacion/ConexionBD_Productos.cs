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
        static public void SubirProductos()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();

                    string insertQuery = @"INSERT INTO prodcutosAlmacen 
                            (Producto, Folio, Empacado, Calidad, CantidadIdeal, 
                            Observaciones)
                            VALUES 
                            (@producto, @folio, @empacado, @calidad, @cantidadIdeal,  
                            @observaciones)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@producto", CacheFormsAlmacen.sucursal);
                        cmd.Parameters.AddWithValue("@folio", CacheFormsAlmacen.gerente);
                        cmd.Parameters.AddWithValue("@empacado", CacheFormsAlmacen.auditor);
                        cmd.Parameters.AddWithValue("@calidad", CacheFormsAlmacen.sucursal);
                        cmd.Parameters.AddWithValue("@cantiadIdeal", CacheFormsAlmacen.gerente);
                        cmd.Parameters.AddWithValue("@observaciones", CacheFormsAlmacen.auditor);
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
