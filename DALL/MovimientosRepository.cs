using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DALL
{
    public class MovimientosRepository
    {

        private readonly OracleConnection _connection;
        private readonly List<Movimientos> _movimientoss = new List<Movimientos>();
        public MovimientosRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }


        public int GuardarMovimiento(Movimientos movimientos)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = @"pr_insertar_movimiento";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("Motivo", OracleDbType.Varchar2).Value = movimientos.Motivo;
                command.Parameters.Add("Descripcion", OracleDbType.Varchar2).Value = movimientos.Descripcion;
                command.Parameters.Add("Codigo", OracleDbType.Varchar2).Value = movimientos.Codigo;
                command.Parameters.Add("Cantidad", OracleDbType.Int32).Value = movimientos.Cantidad;
                command.Parameters.Add("Fecha", OracleDbType.Date).Value = movimientos.Fecha;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


        public List<Movimientos> BuscarPorMotivo(string motivo)
        {
            OracleDataReader dataReader;
            List<Movimientos> movimientoss = new List<Movimientos>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"select * from movimientos where motivo=:Motivo";
                command.Parameters.Add("motivo", OracleDbType.Varchar2).Value = motivo;
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Movimientos movimientos = DataReaderMapToMovimientos(dataReader);
                        movimientoss.Add(movimientos);
                    }
                }
            }
            return movimientoss;
        }

        private Movimientos DataReaderMapToMovimientos(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Movimientos movimientos = new Movimientos();
            movimientos.Motivo = dataReader.GetString(1);
            movimientos.Descripcion = dataReader.GetString(2);
            movimientos.Codigo = dataReader.GetString(3);
            movimientos.Cantidad = dataReader.GetInt32(4);
            movimientos.Fecha = dataReader.GetDateTime(5);
            return movimientos;

        }

        public List<Movimientos> ConsultarTodos()
        {
            OracleDataReader dataReader;
            List<Movimientos> movimientos1 = new List<Movimientos>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from movimiento ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Movimientos movimientos = DataReaderMapToMovimientos(dataReader);
                        movimientos1.Add(movimientos);
                    }
                }
            }
            return movimientos1;
        }

        //public int Totalizar()
        //{

        //   // return BuscarPorMotivo(string motivo).Count();
        //}


    }
}
