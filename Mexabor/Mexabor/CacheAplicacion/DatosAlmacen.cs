using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexabor.CacheAplicacion
{
    public class DatosAlmacen
    {
        public string Id { get; set; }
        public string Sucursal { get; set; }
        public string Gerente { get; set; }
        public string Auditor { get; set; }
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public string SalidaEstructura { get; set; }
        public string SalidaLimpieza { get; set; }
        public string CocinaCalienteEstructura { get; set; }
        public string CocinaCalienteLimpieza { get; set; }
        public string CamaraEstructura { get; set; }
        public string CamaraLimpieza { get; set; }
        public string AlmacenEstructura { get; set; }
        public string AlmacenLimpieza { get; set; }
        public string AreaPersonalEstructura { get; set; }
        public string AreaPersonalLimpieza { get; set; }
        public string CocinaFriaEstructura { get; set; }
        public string CocinaFriaLimpieza { get; set; }
        public string CajasEstructura { get; set; }
        public string CajasLimpieza { get; set; }
        public string PersonalCocinaCaliente { get; set; }
        public string PersonalCocinaFria { get; set; }
        public string PersonalCajas { get; set; }
        public string ProductosRevisados { get; set; }
        public string ProductosInventario { get; set;}
        public string Vajilla { get; set; }
        public string Responsables { get; set;}
        public string observacionProductos { get; set; }
        public string observacionInventario { get; set; }

    }
}
