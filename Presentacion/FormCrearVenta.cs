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
    public partial class FormCrearVenta : Form
    {
        ClienteService service;
        ProductoService productoService;
        Cliente cliente;
        Producto producto;


        DataTable table = new DataTable();
        public FormCrearVenta()
        {
            InitializeComponent();
           service = new ClienteService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);
            table.Columns.Add("Codigo producto");
            table.Columns.Add("Descripciòn");
            table.Columns.Add("Precio unitario");
            table.Columns.Add("Cantidad");
            table.Columns.Add(" sub Total");
            dataGVfactura.DataSource = table;
            InhabiltarText();

           

            LbelFechaFacturaVenta.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }
        void InhabiltarText()
        {
            txtNumFactura.Enabled = false;
            txtDireccion.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtTelefonoCliente.Enabled = false;
            txtApellido.Enabled = false;
            txtBarrioCliente.Enabled = false;

        }


        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnAgraegarCliente_Click(object sender, EventArgs e)
        {
          
            FormGestionCliente cliente = new FormGestionCliente();

            cliente.ShowDialog();
           
        }
        private void Limpiar()
        {
            txtNumeroDoc.Text = "";
            txtNombreCliente.Text = "";
            txtApellido.Text = "";
            txtBarrioCliente.Text = "";
            txtDireccion.Text = "";
            txtTelefonoCliente.Text = "";
            txtCodigoProd.Text = "";
            txtCantidad.Text = "";
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir de la Venta?", @"Atención",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
             
            
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (int.Parse(txtCantidad.Text) > 0)
                    {

                        int cantidad = int.Parse(txtCantidad.Text);
                        int precio = int.Parse(lblPrecioVenta.Text);
                        lblTotal.Text = (cantidad * precio).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cantidad incorrecta ", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
                catch { }
            }


        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            BusquedaClienteRespuesta consulta = new BusquedaClienteRespuesta();
            consulta = service.BuscarPorIdentificacion(txtNumeroDoc.Text);
            if (!consulta.Error)
            {
                cliente = consulta.Cliente;
                txtNombreCliente.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellidos;
                txtBarrioCliente.Text = cliente.Barrio;
                txtDireccion.Text = cliente.Direccion;
                txtTelefonoCliente.Text = cliente.Telefono;
            }
            else
            {
                MessageBox.Show("Cliente no esta registrado ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Limpiar();
            }

           
           
            

        }

        private void btnBuscarProduct_Click(object sender, EventArgs e)
        {
            
                Producto producto = new Producto();
                BusquedaProductoRespuesta pconsulta = new BusquedaProductoRespuesta();
               pconsulta = productoService.BuscarPorcodigo (txtCodigoProd.Text);
                if (!pconsulta.Error)
                {
                    producto = pconsulta.Producto;
                    lblDescripcion.Text = producto.Descripcion;
                    lblTalla.Text = producto.Talla;
                    lblColor.Text = producto.Color;
                    lblCantidad.Text= producto.Cantidad.ToString();
                    lblPrecioVenta.Text = producto.Precio.ToString(); 
                }
                else
                {
                    MessageBox.Show("Producto no existe", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Limpiar();
                }
            }

        private void BtnQuitarProducto_Click(object sender, EventArgs e)
        {

        }
    }
    }

