using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class DetalleFacturaCompraRepository
    {
        private readonly OracleConnection _connection;
        private readonly List<DetalleFacturaCompra> _factura = new List<DetalleFacturaCompra>();
        public DetalleFacturaCompraRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarDetalleFacturaCompra(DetalleFacturaCompra detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_insertar_detalle_venta";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("codigo_compra", OracleDbType.Varchar2).Value = detalle.CodigoCompra;
                command.Parameters.Add("codigo_producto", OracleDbType.Varchar2).Value = detalle.CodigoProducto;
                command.Parameters.Add("cantidad", OracleDbType.Varchar2).Value = detalle.CantidadProducto;
                command.Parameters.Add("precio", OracleDbType.Varchar2).Value = detalle.Valorunitario;
                command.Parameters.Add("subtotal", OracleDbType.Varchar2).Value = detalle.ValorSubTotal;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


        public int ActualizarInventario(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_actualizar_producto";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("Acosto", OracleDbType.Int32).Value = producto.Costo;
                command.Parameters.Add("Aprecio", OracleDbType.Varchar2).Value = producto.Precio;
                command.Parameters.Add("Acodigo", OracleDbType.Varchar2).Value = producto.CodigoProducto;
                command.Parameters.Add("Acantidad", OracleDbType.Varchar2).Value = producto.Cantidad;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }





    }
}
