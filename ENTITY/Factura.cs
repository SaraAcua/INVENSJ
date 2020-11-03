using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Factura
    {
        public Factura(string codigoFactura, string fecha, int valorTotalFactura)
        {
            CodigoFactura = codigoFactura;
            Fecha = fecha;
            ValorTotalFactura = valorTotalFactura;
        }

        public Factura()
        {

        }

        public string CodigoFactura { get; set; }
        public string Fecha { get; set; }
        public int ValorTotalFactura { get; set; }

        

        public void CalcularTotalFactura(int valorTotalProductos)
        {
            ValorTotalFactura = ValorTotalFactura + valorTotalProductos;
        }


        //public void CalcularTotalFacturaEliminarproducto(int valorTotalProductos)
        //{
        //    ValorTotalFactura = ValorTotalFactura - valorTotalProductos;
        //}


    }
}
