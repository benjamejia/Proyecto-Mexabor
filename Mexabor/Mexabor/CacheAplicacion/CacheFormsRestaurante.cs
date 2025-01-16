using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mexabor.CacheAplicacion
{
    public class CacheFormsRestaurante
    {
        //Cache de los datos alaamcenados en los forms.

        public static DateTime hora;
        public static DateTime fecha;
        public static string? sucursal;
        public static string? gerente;
        public static string? auditor;

        public static List<int> estacionamientoEstructura = new List<int>();
        public static List<int> estacionamientoLimpieza = new List<int>();

        public static List<int> comedorEstructura = new List<int>();
        public static List<int> comedorLimpieza = new List<int>();

        public static List<int> barraEstructura = new List<int>();
        public static List<int> barraLimpieza = new List<int>();

        public static List<int> tortillasEstructura = new List<int>();
        public static List<int> tortillasLimpieza = new List<int>();

        public static List<int> serviciosEstructura = new List<int>();
        public static List<int> serviciosLimpieza = new List<int>();

        public static List<int> planchasEstructura = new List<int>();
        public static List<int> planchasLimpieza = new List<int>();

        public static List<int> lozaEstructura = new List<int>();
        public static List<int> lozaLimpieza = new List<int>();

        public static List<int> bañosEstructura = new List<int>();
        public static List<int> bañosLimpieza = new List<int>();

        public static List<int> juegosEstructura = new List<int>();
        public static List<int> juegosLimpieza = new List<int>();

        public static List<int> personalPlanchas = new List<int>();
        public static List<int> personalAseo = new List<int>();
        public static List<int> personalLoza = new List<int>();
        public static List<int> personalTortillas = new List<int>();

        public static List<int> personalBarra = new List<int>();
        public static List<int> personalServicios = new List<int>();
        public static List<int> personalMesas = new List<int>();

        public static List<int> documentos = new List<int>();
        public static List<int> almacen = new List<int>();
        public static List<int> caja = new List<int>();
        public static List<int> ambiente = new List<int>();

        public static List<int> calificacionProveedores = new List<int>();
        public static List<int> herramienta = new List<int>();

        public static List<int> temperatura = new List<int>();
        public static List<int> sabor = new List<int>();

        public static int cloracion;

        public static int traposCocina;
        public static int traposMesas;
        public static int traposBanios;
        public static int traposCaja;

        public static Dictionary<string, int[]> temperaturasIdeales = new Dictionary<string, int[]>
        {
            { "1.- Jugo de Carne (Olla Grande)", new int[] { 55, 75 } },
            { "2.- Jugo de Carne (Olla Chica)", new int[] { 55, 88 } },
            { "3.- Frijol de la Olla (Baño María)", new int[] { 55, 90 } },
            { "4.- Tortillas", new int[] { 40, 99 } },
            { "5.- Cebollita Cocida", new int[] { 55, 90 } },
            { "6.- Frijol Frito", new int[] { 40, 67 } }
        };

        public static List<string> observaciones = new List<string>()
        {
            "Sin Observacion", // observacionGas
            "Sin Observacion", // observacionFumigacion
            "Sin Observacion", // observacionTrampa
            "Sin Observacion", // observacionFilete
            "Sin Observacion", // observacionMasa
            "Sin Observacion", // observacionPostres
            "Sin Observacion", // observacionRefresco
            "Sin Observacion", // observacionCerveza
            "Sin Observacion", // observacionAlmacen
            "Sin Observacion", // observacionBasura
            "Sin Observacion"  // observacionMantenimiento
        };
        public static void LimpiarCache()
        {
            // Limpiar las variables de tipo string
            sucursal = null;
            gerente = null;
            auditor = null;
            // Agrupar todas las listas en una sola colección
            var listas = new List<List<int>>()
            {
                estacionamientoEstructura, estacionamientoLimpieza,
                comedorEstructura, comedorLimpieza,
                barraEstructura, barraLimpieza,
                tortillasEstructura, tortillasLimpieza,
                serviciosEstructura, serviciosLimpieza,
                planchasEstructura, planchasLimpieza,
                lozaEstructura, lozaLimpieza,
                bañosEstructura, bañosLimpieza,
                juegosEstructura, juegosLimpieza,
                personalPlanchas, personalAseo, personalLoza, personalTortillas,
                personalBarra, personalServicios, personalMesas,
                documentos, almacen, caja, ambiente,
                calificacionProveedores, herramienta,
                temperatura, sabor
            };

            // Limpiar cada lista
            foreach (var lista in listas)
            {
                lista.Clear();
            }
            // Limpiar las variables de tipo int
            cloracion = 0;
            traposCocina = 0;
            traposMesas = 0;
            traposBanios = 0;
            traposCaja = 0;
            //Limpiar observaciones
            for (int i = 0; i < observaciones.Count; i++)
            {
                observaciones[i] = "Sin Observacion";
            }
        }

    }
}
