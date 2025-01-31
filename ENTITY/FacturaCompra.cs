﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class FacturaCompra
    {
        public FacturaCompra(Proveedor proveedor, string codigoFactura, DateTime fecha, int valorTotalFactura)
        {
            CodigoFactura = codigoFactura;
            Fecha = fecha;
            ValorTotalFactura = valorTotalFactura;
            CodigoProveedor = proveedor.Identificacion;
        }

        public FacturaCompra()
        {

        }

        public string CodigoFactura { get; set; }
        public string CodigoProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public double ValorTotalFactura { get; set; }

        private List<DetalleFacturaCompra> Detalles;
        

        
        public void AgregarDetalle(Producto producto, int cantidad)
        {
            DetalleFacturaCompra detalle = new DetalleFacturaCompra(this, producto, cantidad);
            Detalles.Add(detalle);
        }


        public void CalcularTotalFactura()
        {
            ValorTotalFactura = Detalles.Sum(d=>d.ValorSubTotal);
        }


        


    }
}
