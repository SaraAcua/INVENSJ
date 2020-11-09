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
            dataGvRegistroProd.Refresh();
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTalla.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Limpiar()
        {
            txtCodigoProd.Text = "";
            txtNombreProd.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtRutaImge.Text = "";
            cmbColor.Text = "Seleccione";
            cmbMarca.Text = "Seleccione";
            cmbTalla.Text = "Seleccione";

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

        private void picAgregarImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.InitialDirectory = "C:\\";
            //imagen.Filter = "Archivos de imagen(*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png|GIF(*.gif)*.gif";

            if (imagen.ShowDialog() == DialogResult.OK)
            {
                picImgen.ImageLocation = imagen.FileName;
                txtRutaImge.Text = imagen.FileName;
            }
            else
            {
                MessageBox.Show("No selecciono la imagen", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del registro de producto?", @"Atención",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Limpiar();

            }
            else
            {
                this.DialogResult = DialogResult.None;
                txtCodigoProd.Focus();
            }
        }
    }
}
