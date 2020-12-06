using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Movimientos
    {
        public Movimientos(string motivo, string descripcion, string observacion, Producto producto,
            int cantidad, DateTime fecha)
        {
            Motivo = motivo;
            Descripcion = descripcion;
            Codigo = producto.CodigoProducto;
            Cantidad = cantidad;
            Fecha = fecha;
            
        }

        public Movimientos()
        {

        }
        public string Codigo { get; set; }
        public string Motivo { get; set; }
        public string Descripcion { get; set; }
        
        
        
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        


    }
}
