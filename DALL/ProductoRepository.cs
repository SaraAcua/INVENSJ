using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

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


        
        public int GuardarProducto(Producto producto, int cod_color, int cod_marca)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = @"pr_insertar_producto";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("codigo_producto", OracleDbType.Varchar2).Value = producto.CodigoProducto;
                command.Parameters.Add("Descripcion", OracleDbType.Varchar2).Value = producto.Descripcion;
                command.Parameters.Add("Costo", OracleDbType.Int32).Value = producto.Costo;
                command.Parameters.Add("Precio", OracleDbType.Int32).Value = producto.Precio;
                command.Parameters.Add("Iva", OracleDbType.Int32).Value = producto.Iva;
                command.Parameters.Add("Talla", OracleDbType.Varchar2).Value = producto.Talla;
                command.Parameters.Add("codigo_color ", OracleDbType.Int32).Value = cod_color;
                command.Parameters.Add("codigo_marca ", OracleDbType.Int32).Value = cod_marca;
                command.Parameters.Add("stock_minimo ", OracleDbType.Int32).Value = producto.StockMinimo;
                command.Parameters.Add("stock_maximo ", OracleDbType.Int32).Value = producto.StockMaximo;
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
                command.CommandText = "SELECT  p.codigo_producto,p.descripcion,p.costo,p.precio,p.iva, p.talla,c.nombre, m.nombre,stock_minimo,stock_maximo,cantidad FROM producto P JOIN color C ON p.codigo_color = c.codigo_color JOIN marca m ON p.codigo_marca = m.codigo_marca AND codigo_producto =: codigo ";
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
