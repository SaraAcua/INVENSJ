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
        private readonly ArrayList Datos = new ArrayList();
        public DashboardRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public ArrayList ConsultarDatos()
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"DashboardDatos";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Datos.Add ( dataReader.GetInt32(0));

                    }
                }
            }
            return Datos;
        }



    }
}
