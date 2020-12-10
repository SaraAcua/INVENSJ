using ENTITY;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(List<DetalleFacturaCompra> detalles, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion de inventario");
            document.Open();
            document.Add(new Paragraph("DETALLE FACTURA REGISTRADA"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("  SK SHOP TU TIENDA "));
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





    }
}
