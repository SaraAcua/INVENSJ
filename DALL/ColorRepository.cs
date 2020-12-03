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
                command.CommandText = @"pr_insertar_color";
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
                command.CommandText = "select codigo_color from color where nombre=:Nombre";
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Color color = DataReaderMapToColor(dataReader);
                return color;
            }
        }

        public string ConsultarIdColor(string nombreR)
        {
            OracleDataReader dataReader;
            string respuesta="";
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select codigo_color from color where Nombre=  nombreR ";
                command.Parameters.Add("nombreR", OracleDbType.Varchar2).Value = nombreR;
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        respuesta = DataReaderMapToIdColor(dataReader);

                    }
                }
            }
            return respuesta;
        }



        private Color DataReaderMapToColor(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Color color = new Color();
            color.Nombre = dataReader.GetString(0);
            return color;

        }


        private string DataReaderMapToIdColor(OracleDataReader dataReader)
        {
            string respuesta;
            if (!dataReader.HasRows) return null;

            respuesta = dataReader.GetString(0);
            return respuesta;

        }



        public List<Color> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Color> proveedores = new List<Color>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select nombre from color ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Color color = DataReaderMapToColor(dataReader);
                        proveedores.Add(color);
                    }
                }
            }
            return proveedores;
        }


    }
}
