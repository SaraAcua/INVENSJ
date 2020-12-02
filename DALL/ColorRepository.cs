using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class ColorRepository
    {
        private readonly OracleConnection _connection;
        public ColorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarColor(string nombreColor)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into color (Nombre) 
                                      values (:Nombre)";
                command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = nombreColor;
               
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }




    }
}
