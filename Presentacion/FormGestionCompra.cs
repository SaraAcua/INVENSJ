using BLL;
using ENTITY;
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
    public partial class FormGestionCompra : Form
    {
        ProveedorService service;
        ProductoService productoService;
        public FormGestionCompra()
        {
            InitializeComponent();
            service = new ProveedorService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);

            LbelFechaFacturaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btnRegsitroProv_Click(object sender, EventArgs e)
        {
            FormGestionProveedor form = new FormGestionProveedor();
            form.ShowDialog();

        }

        private void FormGestionCompra_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtNumeroCompra.Text = "";
            LbelFechaFacturaCompra.Text = "";
            txtNitProveedor.Text = "";
            txtCodigoProd.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del registro de compra?", @"Atención",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Limpiar();

            }
            else
            {
                this.DialogResult = DialogResult.None;
                //btnCancelar.Focus();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                   e.KeyChar != (char)Keys.Back &&
                   e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Contains('.'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Contains('.'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
            }
        }

        private void txtNitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '-')
                {
                    if (((TextBox)sender).Text.Contains('-'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
            }
        }

       

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            BusquedaProductoRespuesta pconsulta = new BusquedaProductoRespuesta();
            pconsulta = productoService.BuscarPorcodigo(txtCodigoProd.Text);
            if (!pconsulta.Error)
            {
                producto = pconsulta.Producto;
                lblDescripcion.Text = producto.Descripcion;
                lblTalla.Text = producto.Talla;
                lblColor.Text = producto.Color;
                
            }
            else
            {
                MessageBox.Show("Producto no existe", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Limpiar();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            BusquedaProveedorRespuesta consulta = new BusquedaProveedorRespuesta();
            consulta = service.BuscarPorIdentificacion(txtNitProveedor.Text);
            if (!consulta.Error)
            {
                proveedor = consulta.Proveedor;
                txtNombreCliente.Text = proveedor.RazonSocial;
                txtBarrio.Text = proveedor.Barrio;
                txtDireccionCliente.Text = proveedor.Direccion;
                txtTelefonoCliente.Text = proveedor.Telefono;
            }
            else
            {
                MessageBox.Show("Proveedor no esta registrado ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            



        }
    }
}
