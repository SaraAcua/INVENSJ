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

        }
        private void Limpiar()
        {
            dateTimeListadoCompra.CustomFormat = "";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();


           // respuesta = compraService.Busca();
            //dtgProducto.DataSource = respuesta.Productos;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
