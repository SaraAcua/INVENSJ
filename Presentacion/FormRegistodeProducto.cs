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
    public partial class FormRegistodeProducto : Form
    {
        DataTable table = new DataTable();
        public FormRegistodeProducto()
        {
            InitializeComponent();

            table.Columns.Add("Codigo");
            table.Columns.Add("Nombre");
            table.Columns.Add("Precio Compra");
            table.Columns.Add("Precio venta");
            table.Columns.Add("Talla");
            table.Columns.Add("Color");
            table.Columns.Add("Stock");
            table.Columns.Add("Marca");
            table.Columns.Add("Imagen");

            dataGvRegistroProd.DataSource = table;
           // dataGvRegistroProd.DataSource = service.ConsultarTodos().Personas;
            dataGvRegistroProd.Refresh();
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {

        }

        private void picAddColor_Click(object sender, EventArgs e)
        {
            FormRegistroColor form = new FormRegistroColor();
            form.ShowDialog();
        }

        private void picAddMarca_Click(object sender, EventArgs e)
        {
            FormRegistroMarca marca = new FormRegistroMarca();
            marca.ShowDialog();
        }
    }
}
