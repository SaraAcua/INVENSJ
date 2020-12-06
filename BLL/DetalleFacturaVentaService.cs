﻿using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleFacturaVentaService
    {
        private readonly ConnectionManager conexion;
        private readonly DetalleFacturaVentaRepository repositorio;
        public DetalleFacturaVentaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DetalleFacturaVentaRepository(conexion);
        }

        public string GuardarDetalleCompra(DetalleFacturaVenta detalle)
        {
            try
            {
                conexion.Open();

                repositorio.GuardarDetalleFacturaVenta(detalle);

                return $"Se guardaron los datos de la factura satisfactoriamente";

            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


    }
}
