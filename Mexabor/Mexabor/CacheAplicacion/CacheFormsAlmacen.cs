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
        public static bool auditoriaEmpezada = false;

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
        public static List<int> productosRevisadosInventario = new List<int>();

        public static List<int> vajillas = new List<int>();

        public static int productosIncorrectosProductos = -1;
        public static int productosIncorrectosInventario = -1;

        public static string[] responsables = new string[8];
       
        public static string observaciones = "Sin Observaciones.";
        public static string observacionesInventario = "Sin Observaciones.";
        public static int id_auditoria;

        //Puntuaje que se le dara a las opciones de los prodcutos
        public static int ponderacionAlmacen = 10;
        public static int ponderacionProductos = 10;
        public static int ponderacionInventario = 10;

        public static void LimpiarCache()
        {
            sucursal = null;
            gerente = null;
            auditor = null;
            observaciones = null;
            observacionesInventario = "Sin Observaciones.";


            salidaEstructura.Clear();
            salidaLimpieza.Clear();

            cocincaCalienteEstructura.Clear();
            cocinaCalienteLimpieza.Clear();

            camaraEstructura.Clear();
            camaraLimpieza.Clear();

            almacenEstructura.Clear();
            almacenLimpieza.Clear();

            areaPersonalEstructura.Clear();
            areaPersonalLimpieza.Clear();

            cocinaFriaEstructura.Clear();
            cocinaFriaLimpieza.Clear();

            cajasEstructura.Clear();
            cajasLimpieza.Clear();

            personalCocinaCaliente.Clear();
            personalCocinaFria.Clear();
            personalCaja.Clear();
            productosRevisados.Clear();

            productosIncorrectosInventario = -1;
            productosIncorrectosProductos = -1;
        }

    }
}
