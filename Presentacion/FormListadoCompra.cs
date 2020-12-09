using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.IO;


namespace Presentacion
{
    public partial class FormListadoCompra : Form
    {
        FacturaCompraService compraService;
        public FormListadoCompra()
        {
            InitializeComponent();
            compraService = new FacturaCompraService(ConfigConnection.connectionString);
            dateTimeListadoCompra.Format = DateTimePickerFormat.Custom;
            dateTimeListadoCompra.CustomFormat = "dd/MM/yyyy";
            dateTimeListadoCompra1.Format = DateTimePickerFormat.Custom;
            dateTimeListadoCompra1.CustomFormat = "dd/MM/yyyy";
           

        }
        private void Limpiar()
        {
            dateTimeListadoCompra.CustomFormat = "";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta ();


            respuesta = compraService.BuscarReporte(DateTime.Parse(dateTimeListadoCompra.Text),DateTime.Parse( dateTimeListadoCompra1.Text));
            dtgvListadoCompra.DataSource = respuesta.Facturas;
            Limpiar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
