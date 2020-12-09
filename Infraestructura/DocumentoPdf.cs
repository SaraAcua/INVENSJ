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
        public void GuardarPdf(List<FacturaCompra> facturas, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion Pulsacion");
            document.Open();
            document.Add(new Paragraph("INFORME DE FACTURAS REGISTRADAS"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(facturas));
            document.Close();
        }


        private PdfPTable LlenarTabla(List<FacturaCompra> facturas)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Codigo_Factura"));
            tabla.AddCell(new Paragraph("Id_Proveedor"));
            tabla.AddCell(new Paragraph("Fecha"));
            tabla.AddCell(new Paragraph("Total"));
            
            foreach (var item in facturas)
            {
                tabla.AddCell(new Paragraph(item.CodigoFactura));
                tabla.AddCell(new Paragraph(item.CodigoProveedor));
                tabla.AddCell(new Paragraph(item.Fecha.ToString()));
                tabla.AddCell(new Paragraph(item.ValorTotalFactura.ToString()));
                

            }
            return tabla;

        }





    }
}
