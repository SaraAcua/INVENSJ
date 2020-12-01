using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DALL
{
    public class ProductoRepository
    {
        private readonly OracleConnection _connection;
        private readonly List<Producto> _productos = new List<Producto>();
        public ProductoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }



        public int GuardarProducto(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                
                command.CommandText = @"Insert Into producto 
                                      values (:CodigoProducto,:Descripcion,:Costo,:Precio,:Iva,:Talla,:Color,:Marca,:StockMinimo,:StockMaximo,:Cantidad)";
                command.Parameters.Add("CodigoProducto", OracleDbType.Varchar2).Value = producto.CodigoProducto;
                command.Parameters.Add("Descripcion", OracleDbType.Varchar2).Value = producto.Descripcion;
                command.Parameters.Add("Costo", OracleDbType.Int32).Value = producto.Costo;
                command.Parameters.Add("Precio", OracleDbType.Int32).Value = producto.Precio;
                command.Parameters.Add("Iva", OracleDbType.Int32).Value = producto.Iva;
                command.Parameters.Add("Talla", OracleDbType.Varchar2).Value = producto.Talla;
                command.Parameters.Add("Color", OracleDbType.Varchar2).Value = producto.Color;
                command.Parameters.Add("Marca", OracleDbType.Varchar2).Value = producto.Marca;
                command.Parameters.Add("StockMinimo", OracleDbType.Int32).Value = producto.StockMinimo;
                command.Parameters.Add("StockMaximo", OracleDbType.Int32).Value = producto.StockMaximo;
                command.Parameters.Add("Cantidad", OracleDbType.Int32).Value = producto.Cantidad;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


        public Producto BuscarPorCodigoProducto(string codigo)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from persona where codigo_producto=:codigo";
                command.Parameters.Add("codigo_producto", OracleDbType.Varchar2).Value = codigo;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Producto producto = DataReaderMapToProducto(dataReader);
                return producto;
            }
        }



        private Producto DataReaderMapToProducto(OracleDataReader dataReader)
        {
            
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            producto.CodigoProducto = dataReader.GetString(0);
            producto.Descripcion = dataReader.GetString(1);
            producto.Costo = dataReader.GetInt32(2);
            producto.Precio = dataReader.GetInt32(3);
            producto.Iva = dataReader.GetInt32(4);
            producto.Talla = dataReader.GetString(5);
            producto.Color = dataReader.GetString(6);
            producto.Marca = dataReader.GetString(7);
            producto.StockMinimo = dataReader.GetInt32(8);
            producto.StockMaximo = dataReader.GetInt32(9);
            producto.Cantidad = dataReader.GetInt32(10);
            return producto;

        }


    }
}
