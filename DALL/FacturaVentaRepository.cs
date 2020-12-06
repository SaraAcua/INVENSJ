﻿using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class FacturaVentaRepository
    {

        private readonly OracleConnection _connection;
        private readonly List<FacturaCompra> _factura = new List<FacturaCompra>();
        public FacturaVentaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public int GuardarFacturaVenta(FacturaVenta detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"pr_insertar_venta";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("id_cliente", OracleDbType.Varchar2).Value = detalle.CodigoFactura;
                command.Parameters.Add("fecha", OracleDbType.Date).Value = detalle.Fecha;
                command.Parameters.Add("total", OracleDbType.Int32).Value = detalle.ValorTotalFactura;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


    }
}
