using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class DashboardRepository
    {
        private readonly OracleConnection _connection;
        
        public DashboardRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public string ConsultarCliente()
        {
            string Datos="";
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"select count (id_cliente) from CLIENTE";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                { 
                        Datos= (dataReader.GetString(0));                
                }
            }
            return Datos;
        }


        public string ConsultarTotalVentas()
        {
            string Datos = "";
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"select sum(total) from VENTA";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    Datos = (dataReader.GetString(0));
                }
            }
            return Datos;
        }

        public string ConsultarProveedores()
        {
            string Datos = "";
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"select count (id_proveedor)  from PROVEEDOR";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    Datos = (dataReader.GetString(0));
                }
            }
            return Datos;
        }




    }
}
