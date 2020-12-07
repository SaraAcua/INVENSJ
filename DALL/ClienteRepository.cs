using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class ClienteRepository
    {


        private readonly OracleConnection _connection;
        private readonly List<Cliente> _proveedores = new List<Cliente>();
        public ClienteRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarCliente(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_insertar_cliente";
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


        public int ModificarCliente(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_modificar_cliente";
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



        public Cliente BuscarPorIdentificacionCliente(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from cliente where id_cliente=:Identificacion";
                command.Parameters.Add("id_cliente", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Cliente cliente = DataReaderMapToCliente(dataReader);
                return cliente;
            }
        }

        private Cliente DataReaderMapToCliente(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.Identificacion = dataReader.GetString(0);
            cliente.TipoIdentificacion = dataReader.GetString(1);
            cliente.Nombre = dataReader.GetString(2);
            cliente.Apellidos = dataReader.GetString(3);
            cliente.Telefono = dataReader.GetString(4);
            cliente.Barrio = dataReader.GetString(5);
            cliente.Direccion = dataReader.GetString(6);
            cliente.Email = dataReader.GetString(7);
            return cliente;

        }

        public List<Cliente> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from cliente ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToCliente(dataReader);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

        public int Totalizar()
        {

            return ConsultarTodos().Count();
        }
        



    }
}
