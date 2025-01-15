using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexabor.CacheAplicacion
{
    internal class CacheUsuario
    {
        public static string usuario { get; set; }
        public static string tipoUsuario { get; set; }

        static public void LimpiarDatos() 
        {
            usuario = string.Empty;
            tipoUsuario = string.Empty;
        }
    }
}
