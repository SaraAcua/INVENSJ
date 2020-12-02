using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    class ProveedorRepository
    {

        private readonly OracleConnection _connection;
        private readonly List<Proveedor> _proveedores = new List<Proveedor>();
        public ProveedorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarProveedor(Proveedor proveedor)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = @"Insert Into proveedor 
                values(:Identificacion,:TipoIdentificacion,:RazonSocial,:Telefono,:Barrio,:Direccion,:Email)";
                command.Parameters.Add("Identificacion", OracleDbType.Varchar2).Value = proveedor.Identificacion;
                command.Parameters.Add("TipoIdentificacion", OracleDbType.Varchar2).Value = proveedor.TipoIdentificacion;
                command.Parameters.Add("RazonSocial", OracleDbType.Int32).Value = proveedor.RazonSocial;
                command.Parameters.Add("Telefono", OracleDbType.Int32).Value = proveedor.Telefono;
                command.Parameters.Add("Barrio", OracleDbType.Int32).Value = proveedor.Barrio;
                command.Parameters.Add("Direccion", OracleDbType.Varchar2).Value = proveedor.Direccion;
                command.Parameters.Add("Email", OracleDbType.Varchar2).Value = proveedor.Email;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


        public Proveedor BuscarPorIdentificacionProveedor(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from proveedor where id_proveedor=:Identificacion";
                command.Parameters.Add("id_proveedor", OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Proveedor proveedor = DataReaderMapToProveedor(dataReader);
                return proveedor;
            }
        }

        private Proveedor DataReaderMapToProveedor(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Proveedor provedor = new Proveedor();
            provedor.Identificacion = dataReader.GetString(0);
            provedor.TipoIdentificacion = dataReader.GetString(1);
            provedor.RazonSocial = dataReader.GetString(2);
            provedor.Telefono = dataReader.GetString(3);
            provedor.Barrio = dataReader.GetString(4);
            provedor.Direccion = dataReader.GetString(5);
            provedor.Email = dataReader.GetString(6);
            return provedor;

        }

        public List<Proveedor> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Proveedor> proveedores = new List<Proveedor>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from proveedor ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Proveedor proveedor = DataReaderMapToProveedor(dataReader);
                        proveedores.Add(proveedor);
                    }
                }
            }
            return proveedores;
        }

        public int Totalizar()
        {

            return ConsultarTodos().Count();
        }

    }
}
