using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Movimientos
    {
        public Movimientos(string motivo, string observacion, Producto producto,
            int cantidad, DateTime fecha)
        {
            Motivo = motivo;
            Observacion = observacion;
            Producto = producto;
            Cantidad = cantidad;
            Fecha = fecha;
            Tipo = "Movimiento";
        }

        public Movimientos()
        {

        }


        public string Motivo { get; set; }
        public string Observacion { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }


    }
}
