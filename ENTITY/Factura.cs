using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Factura
    {
        public Factura(string codigoFactura, string fecha)
        {
            CodigoFactura = codigoFactura;
            Fecha = fecha;
        }

        public Factura()
        {

        }

        public string CodigoFactura { get; set; }
        public string Fecha { get; set; }
    }
}
