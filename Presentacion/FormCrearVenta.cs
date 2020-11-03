using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
    
{
    public partial class FormCrearVenta : Form
    {
        DataTable table = new DataTable();
        public FormCrearVenta()
        {
            InitializeComponent();
            table.Columns.Add("Codigo producto");
            table.Columns.Add("Descripciòn");
            table.Columns.Add("Cantidad");
            table.Columns.Add("Precio unitario");
            table.Columns.Add("Iva");
            table.Columns.Add("Total");
            dataGVfactura.DataSource = table;
            InhabiltarText();

        }
        void InhabiltarText()
        {
            txtNumFactura.Enabled= false;
            txtDireccionCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtTelefonoCliente.Enabled = false;
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
