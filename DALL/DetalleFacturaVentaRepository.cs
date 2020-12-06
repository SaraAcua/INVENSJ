using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class DetalleFacturaVentaRepository
    {

        private readonly OracleConnection _connection;
        private readonly List<DetalleFacturaVenta> _factura = new List<DetalleFacturaVenta>();
        public DetalleFacturaVentaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarDetalleFacturaVenta(DetalleFacturaVenta detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_insertar_detalle_venta";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("codigo_venta", OracleDbType.Varchar2).Value = detalle.CodigoVenta;
                command.Parameters.Add("codigo_producto", OracleDbType.Varchar2).Value = detalle.CodigoProducto;
                command.Parameters.Add("cantidad", OracleDbType.Varchar2).Value = detalle.CantidadProducto;
                command.Parameters.Add("precio", OracleDbType.Varchar2).Value = detalle.Valorunitario;
                command.Parameters.Add("subtotal", OracleDbType.Varchar2).Value = detalle.ValorTotal;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        

    }
}
