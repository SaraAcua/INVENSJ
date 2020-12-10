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
                command.CommandText = @"PROYECTO_INSERTAR.pr_insertar_detalle_venta";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("codigo_venta", OracleDbType.Int32).Value = detalle.CodigoVenta;
                command.Parameters.Add("codigo_producto", OracleDbType.Varchar2).Value = detalle.CodigoProducto;
                command.Parameters.Add("cantidad", OracleDbType.Int32).Value = detalle.CantidadProducto;
                command.Parameters.Add("precio", OracleDbType.Int32).Value = detalle.Valorunitario;
                command.Parameters.Add("subtotal", OracleDbType.Int32).Value = detalle.ValorSubTotal;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


        public int ActualizarInventario(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"PROYECTO_INSERTAR.pr_actualizar_cantidad_producto";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("Acodigo", OracleDbType.Varchar2).Value = producto.CodigoProducto;
                command.Parameters.Add("Acantidad", OracleDbType.Varchar2).Value = producto.Cantidad;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }



    }
}
