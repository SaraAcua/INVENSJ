using ENTITY;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = iTextSharp.text.Image;

namespace Infraestructura
{
    public class DocumentoPdf
    {
        Proveedor proveedor = new Proveedor();
        public void GuardarPdf(List<DetalleFacturaCompra> detalles, List<Proveedor> compras, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion de inventario");
            document.Open();
            document.Add(new Paragraph("DETALLE FACTURA REGISTRADA"));

            document.Add(new Paragraph("  SK SHOP TU TIENDA "));
            document.Add(new Paragraph("\n"));
            var imagepath = @"C:IMG-9593.PNG";
            FileStream stream1 = new FileStream(imagepath, FileMode.Open);
            {
                var png = Image.GetInstance(System.Drawing.Image.FromStream(stream1), ImageFormat.Png);
                png.ScalePercent(5f);
                png.SetAbsolutePosition(document.Left, document.Top);
                document.Add(png);
            }
            var spacer = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f,
            };
            document.Add(spacer);

            //var headerTable = new PdfPTable(new[] { .75f, 2f })
            //{
            //    HorizontalAlignment = Left,
            //    WidthPercentage = 75,
            //    DefaultCell = { MinimumHeight = 22f }
            //};


            //headerTable.AddCell("Fecha");
            //headerTable.AddCell(DateTime.Now.ToString());
            //headerTable.AddCell("Razon social");
            //headerTable.AddCell(proveedor.RazonSocial);
            //headerTable.AddCell("Telefono");
            //headerTable.AddCell(proveedor.Telefono);
            //headerTable.AddCell("Direccion");
            //headerTable.AddCell(proveedor.Direccion);




          
            document.Add(llenarTablaEncabezado(compras));
            document.Add(spacer);
            var columnWidths = new[] { 1f, 1f, 2f, 1f };
            document.Add(new Paragraph("                  LISTA DE PRODUCTOS"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(detalles));
            document.Close();
        }


        private PdfPTable LlenarTabla(List<DetalleFacturaCompra> detalles)
        {
            PdfPTable tabla = new PdfPTable(5);

            tabla.AddCell(new Paragraph("Codigo compra"));
            tabla.AddCell(new Paragraph("Codigo producto"));
            tabla.AddCell(new Paragraph("Cantidad"));
            tabla.AddCell(new Paragraph("Precio"));
            tabla.AddCell(new Paragraph("Subtotal"));

            foreach (var item in detalles)
            {
                tabla.AddCell(new Paragraph(item.CodigoCompra));
                tabla.AddCell(new Paragraph(item.CodigoProducto));
                tabla.AddCell(new Paragraph(item.CantidadProducto.ToString()));
                tabla.AddCell(new Paragraph(item.Valorunitario.ToString()));
                tabla.AddCell(new Paragraph(item.ValorSubTotal.ToString()));

            }
            return tabla;


        }
        private PdfPTable llenarTablaEncabezado(List<Proveedor> compras)
        {


            var headerTable = new PdfPTable(new[] { .76f, 2f })
            {
                // HorizontalAlignment = Left,
                WidthPercentage = 75,
                DefaultCell = { MinimumHeight = 22f }
            };

            headerTable.AddCell("Fecha");
            headerTable.AddCell(DateTime.Now.ToString());
            headerTable.AddCell("Nit");
            headerTable.AddCell("Razon social");
            headerTable.AddCell("Telefono");
            headerTable.AddCell("Direccion");
           


            foreach (var item in compras)
            {

                headerTable.AddCell(new Paragraph(item.Identificacion));
                headerTable.AddCell(new Paragraph(item.RazonSocial));
                headerTable.AddCell(new Paragraph(item.Telefono));
                headerTable.AddCell(new Paragraph(item.Direccion));


            }
            return headerTable;
        }
    }
}

