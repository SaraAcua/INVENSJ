using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class FacturaVentaRepository
    {

        private readonly OracleConnection _connection;
        private readonly List<FacturaCompra> _factura = new List<FacturaCompra>();
        public FacturaVentaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int GuardarFacturaVenta(FacturaVenta detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_insertar_venta";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("id_cliente", OracleDbType.Varchar2).Value = detalle.IdCliente;
                command.Parameters.Add("fecha", OracleDbType.Date).Value = detalle.Fecha;
                command.Parameters.Add("total", OracleDbType.Int32).Value = detalle.ValorTotalFactura;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


          
        public int ConsultarIdFactura()
        {
            OracleDataReader dataReader;
            int respuesta = 0;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT MAX(codigo_venta) FROM venta ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        respuesta = dataReader.GetInt32(0);

                    }
                }
            }
            return respuesta;
        }


        public List<FacturaVenta> ReporteFactura(DateTime fechaInicial, DateTime fechaFinal)
        {
            OracleDataReader dataReader;
            List<FacturaVenta> facturas = new List<FacturaVenta>();

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"SELECT *  FROM Venta   WHERE fecha  BETWEEN TO_DATE(:fechaInicial) AND TO_DATE(:fechaFinal) ORDER BY codigo_compra";
                command.Parameters.Add("fechaInicial", OracleDbType.Date).Value = fechaInicial;
                command.Parameters.Add("fechaFinal", OracleDbType.Date).Value = fechaFinal;
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        FacturaVenta facturaVenta = DataReaderMapToFactura(dataReader);
                        facturas.Add(facturaVenta);
                    }
                }
            }
            return facturas;
        }

        private FacturaVenta DataReaderMapToFactura(OracleDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            FacturaVenta factura = new FacturaVenta();
            factura.CodigoFactura = dataReader.GetString(0);
            factura.IdCliente = dataReader.GetString(1);
            factura.Fecha = dataReader.GetDateTime(2);
            factura.ValorTotalFactura = dataReader.GetInt32(3);
            return factura;

        }



    }
}
