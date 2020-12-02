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
            Tipo = "Movimiento";
        }

        public Movimientos()
        {

        }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Motivo { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }


    }
}
