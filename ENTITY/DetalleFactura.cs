using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class DetalleFactura 
    {
        public DetalleFactura(string codigoVenta, string codigoProducto, string nombreProducto, int cantidadProducto,
            string fechaVenta, int valorunitario)
        {
            CodigoVenta = codigoVenta;
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            CantidadProducto = cantidadProducto;
            FechaVenta = fechaVenta;
            Valorunitario = valorunitario;
            
            
        }
            
        public DetalleFactura()
        {
           
        }

        public string CodigoVenta { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadProducto { get; set; }
        public string FechaVenta { get; set; }
        public int Valorunitario { get; set; }
        


        public int CalcularTotalPorProducto(int valorUnitaio, int cantidad)
        {
            int totalPorPoroducto = 0;
            totalPorPoroducto = valorUnitaio * cantidad;
            return totalPorPoroducto;
        }

    }
}
