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
        public double ValorTotalFactura { get; set; }

        private List<DetalleFactura> Detalles;
        public string Tipo { get; set; }
        public Persona Persona { get; set; }

        
        public void AgregarDetalle(Producto producto, int cantidad)
        {
            DetalleFactura detalle = new DetalleFactura(this, producto, cantidad);
            Detalles.Add(detalle);
        }


        public void CalcularTotalFactura()
        {
            ValorTotalFactura = Detalles.Sum(d=>d.ValorTotal);
        }


        


    }
}
