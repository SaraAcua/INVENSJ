using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class MarcaRepository
    {
        private readonly OracleConnection _connection;
        private readonly List<Marca> _colores = new List<Marca>();
        public MarcaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarMarca(Marca marca)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_insertar_marca";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = marca.Nombre;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


        public Marca BuscarPorNombreMarca(string nombre)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from marca where nombre=:Nombre";
                command.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Marca marca = DataReaderMapToMarca(dataReader);
                return marca;
            }
        }

        private Marca DataReaderMapToMarca(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Marca marca = new Marca();
            marca.Nombre = dataReader.GetString(0);
            return marca;

        }



        public int ConsultarIdMarca(string nombreR)
        {
            OracleDataReader dataReader;
            int respuesta = 0;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select codigo_marca from marca where Nombre =  :nombreR ";
                command.Parameters.Add("nombreR", OracleDbType.Varchar2).Value = nombreR;
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



        public List<Marca> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Marca> marcas = new List<Marca>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select nombre from marca ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Marca marca = DataReaderMapToMarca(dataReader);
                        marcas.Add(marca);
                    }
                }
            }
            return marcas;
        }

    }
}
