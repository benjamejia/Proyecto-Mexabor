using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexabor.CacheAplicacion
{
    public class DatosAlmacen
    {
        public int Id { get; set; }
        public string Sucursal { get; set; }
        public string Gerente { get; set; }
        public string Auditor { get; set; }
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public int SalidaEstructura { get; set; }
        public int SalidaLimpieza { get; set; }
        public int CocinaCalienteEstructura { get; set; }
        public int CocinaCalienteLimpieza { get; set; }
        public int CamaraEstructura { get; set; }
        public int CamaraLimpieza { get; set; }
        public int AlmacenEstructura { get; set; }
        public int AlmacenLimpieza { get; set; }
        public int AreaPersonalEstructura { get; set; }
        public int AreaPersonalLimpieza { get; set; }
        public int CocinaFriaEstructura { get; set; }
        public int CocinaFriaLimpieza { get; set; }
        public int CajasEstructura { get; set; }
        public int CajasLimpieza { get; set; }
    }
}
