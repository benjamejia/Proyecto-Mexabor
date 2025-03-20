using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexabor.CacheAplicacion
{
    public class CacheFormsAlmacen
    {
        //Cache de los datos almacenados en los forms.

        public static DateTime hora;
        public static DateTime fecha;
        public static string? sucursal;
        public static string? gerente;
        public static string? auditor;

        public static List<int> salidaEstructura = new List<int>();
        public static List<int> salidaLimpieza = new List<int>();

        public static List<int> cocincaCalienteEstructura = new List<int>();
        public static List<int> cocinaCalienteLimpieza = new List<int>();

        public static List<int> camaraEstructura = new List<int>();
        public static List<int> camaraLimpieza = new List<int>();

        public static List<int> almacenEstructura = new List<int>();
        public static List<int> almacenLimpieza = new List<int>();

        public static List<int> areaPersonalEstructura = new List<int>();
        public static List<int> areaPersonalLimpieza = new List<int>();

        public static List<int> cocinaFriaEstructura = new List<int>();
        public static List<int> cocinaFriaLimpieza = new List<int>();

        public static List<int> cajasEstructura = new List<int>();
        public static List<int> cajasLimpieza = new List<int>();

        public static List<int> personalCocinaCaliente = new List<int>();
        public static List<int> personalCocinaFria = new List<int>();
        public static List<int> personalCaja = new List<int>();
        public static List<int> productosRevisados = new List<int>();

        public static int productosIncorrectos;

        public static string[] responsables = new string[8];
       
        public static string? observaciones;
        public static int id_auditoria;

        //Puntuaje que se le dara a las opciones de los prodcutos
        public static int ponderacion;   

    }
}
