using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class FacturaCompraRepository
    {

        private readonly OracleConnection _connection;
        private readonly List<FacturaCompra> _factura = new List<FacturaCompra>();
        public FacturaCompraRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarFacturaCompra(FacturaCompra detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_insertar_compra";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("codigo_compra", OracleDbType.Varchar2).Value = detalle.CodigoFactura;
                command.Parameters.Add("id_proveedor", OracleDbType.Varchar2).Value = detalle.CodigoProveedor;
                command.Parameters.Add("fecha", OracleDbType.Date).Value = detalle.Fecha;
                command.Parameters.Add("total", OracleDbType.Int32).Value = detalle.ValorTotalFactura;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

        public List<FacturaCompra> ReporteFactura(DateTime fechaInicial, DateTime fechaFinal)
        {
            OracleDataReader dataReader;
            List<FacturaCompra> facturas = new List<FacturaCompra>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_consultar_lista_compras";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("fechaInicial", OracleDbType.Varchar2).Value = fechaInicial;
                command.Parameters.Add("fechaFinal", OracleDbType.Varchar2).Value = fechaFinal;
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        FacturaCompra facturaCompra = DataReaderMapToFactura(dataReader);
                        facturas.Add(facturaCompra);
                    }
                }
            }
            return facturas;
        }



        private FacturaCompra DataReaderMapToFactura(OracleDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            FacturaCompra factura = new FacturaCompra();
            factura.CodigoFactura = dataReader.GetString(0);
            factura.CodigoProveedor = dataReader.GetString(1);
            factura.Fecha = dataReader.GetString(2);
            factura.ValorTotalFactura = dataReader.GetInt32(3);
            return factura;

        }










    }
}
