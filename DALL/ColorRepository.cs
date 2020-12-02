using ENTITY;
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
        private readonly List<Color> _colores = new List<Color>();
        public ColorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarColor(Color color)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into color 
                values(:Nombre)"; ;
                command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = color.Nombre;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


        public Color BuscarPorNombreColor(string nombre)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from color where nombre=:Nombre";
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Color color = DataReaderMapToColor(dataReader);
                return color;
            }
        }

        private Color DataReaderMapToColor(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Color color = new Color();
            color.Nombre = dataReader.GetString(1);
            return color;

        }




    }
}
