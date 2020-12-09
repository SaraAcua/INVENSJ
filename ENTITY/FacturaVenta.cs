using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class FacturaVenta
    {
        public FacturaVenta(Cliente cliente, DateTime fecha, int valorTotalFactura)
        {
            
            Fecha = fecha;
            ValorTotalFactura = valorTotalFactura;
            IdCliente = cliente.Identificacion;
            
        }


        public FacturaVenta()
        {

        }

        public string CodigoFactura { get; set; }
        public string IdCliente { get; set; }    
        public DateTime Fecha { get; set; }
        public double ValorTotalFactura { get; set; }

        private List<DetalleFacturaVenta> Detalles;
        


        public void AgregarDetalle(Producto producto, int cantidad)
        {
            DetalleFacturaVenta detalle = new DetalleFacturaVenta(this, producto, cantidad);
            Detalles.Add(detalle);
        }


    }
}
