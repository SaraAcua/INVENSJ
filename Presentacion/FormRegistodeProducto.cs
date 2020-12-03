using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;


namespace Presentacion
{
    public partial class FormRegistodeProducto : Form
    {
        ProductoService productoService ;
        Producto producto;
     

        DataTable table = new DataTable();
        public FormRegistodeProducto()
        {


            InitializeComponent();
            productoService = new ProductoService(ConfigConnection.connectionString);
            llenarComboColor();
           
            LlenarComboTalla();

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
         void llenarComboColor()
        {
            
           ColorService colorService= new ColorService(ConfigConnection.connectionString);
            cmbColor.DataSource = colorService.ConsultarColor();
            cmbColor.Refresh();
 
        }
        void LlenarComboMarca()
        {
            MarcaService marcaService = new MarcaService(ConfigConnection.connectionString);
            cmbColor.DataSource = marcaService.ConsultarTodos();
            cmbColor.Refresh();
        }

        private void Limpiar()
        {
            txtCodigoProd.Text = "";
            txtDescripcionProd.Text = "";
            txtCostoCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";
            txtRutaImge.Text = "";
            cmbColor.Text = "SELECCIONE";
            cmbMarca.Text = "SELECCIONE";
            cmbTalla.Text = "SELECCIONE";
            picImgen.Visible= false;

        }
        private void LlenarComboTalla()
        {
            cmbTalla.Items.Add("S");
            cmbTalla.Items.Add("XS");
            cmbTalla.Items.Add("XXS");
            cmbTalla.Items.Add("M");
            cmbTalla.Items.Add("L");
            cmbTalla.Items.Add("XL");
            cmbTalla.Items.Add("XXL");
          
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {

        }

        private void picAddColor_Click(object sender, EventArgs e)
        {
            FormRegistroColor form = new FormRegistroColor();
            form.ShowDialog();
            llenarComboColor();
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
        private Producto MapearProducto()
        {
          producto = new Producto();
            producto.CodigoProducto = txtCodigoProd.Text;
            producto.Descripcion = txtDescripcionProd.Text;
            producto.Costo = int.Parse( txtCostoCompra.Text);
            producto.Precio = int.Parse(txtCodigoProd.Text);
            producto.Iva = int.Parse(txtIva.Text);
            producto.Talla = cmbColor.Text;
            producto.Color = cmbColor.Text;
            producto.Marca = cmbMarca.Text;
            producto.StockMinimo = int.Parse(txtStockMinimo.Text);
            producto.StockMaximo= int.Parse(txtStockMaximo.Text);
            producto.Cantidad= int.Parse(txtCantidad.Text);
            return producto;

        }
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            //Producto producto = MapearProducto();
            // string mensaje = productoService.GuardarProducto(producto);
            // MessageBox.Show(mensaje, "Infomacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            // Limpiar();

   
        }

    }
    }

