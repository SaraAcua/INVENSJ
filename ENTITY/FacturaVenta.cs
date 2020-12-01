using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class FacturaVenta
    {
        public FacturaVenta(Persona persona, string fecha, int valorTotalFactura)
        {
            
            Fecha = fecha;
            ValorTotalFactura = valorTotalFactura;
            Tipo = "Venta";
        }


        public FacturaVenta()
        {

        }

        public string CodigoFactura { get; set; }
        public string Fecha { get; set; }
        public double ValorTotalFactura { get; set; }

        private List<DetalleFacturaVenta> Detalles;
        public string Tipo { get; set; }
        public Persona Persona { get; set; }


        public void AgregarDetalle(Producto producto, int cantidad)
        {
            DetalleFacturaVenta detalle = new DetalleFacturaVenta(this, producto, cantidad);
            Detalles.Add(detalle);
        }


    }
}
