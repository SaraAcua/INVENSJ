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


        /* public int GuardarDetalleFacturaVenta(DetalleFacturaVenta detalleFacturaVenta)
         {
             using (var command = _connection.CreateCommand())
             {
                 command.CommandText = @"pr_--------------------";
                 command.CommandType = System.Data.CommandType.StoredProcedure;
                 command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = cliente.Identificacion;
                 command.Parameters.Add("TipoIdentificacion", OracleDbType.Varchar2).Value = cliente.TipoIdentificacion;
                 command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = cliente.Nombre;
                 command.Parameters.Add("Apellidos", OracleDbType.Varchar2).Value = cliente.Apellidos;
                 command.Parameters.Add("Telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                 command.Parameters.Add("Barrio", OracleDbType.Varchar2).Value = cliente.Barrio;
                 command.Parameters.Add("Direccion", OracleDbType.Varchar2).Value = cliente.Direccion;
                 command.Parameters.Add("Email", OracleDbType.Varchar2).Value = cliente.Email;
                 var filas = command.ExecuteNonQuery();
                 return filas;
             }
         }
         */



    }
}
