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
        DetalleFacturaVenta detalle;
        FacturaVentaService VentaService;
        DetalleFacturaVentaService detalleFactura;

        List<DetalleFacturaVenta> ventas = new List<DetalleFacturaVenta>(); 
        List<Producto> productos = new List<Producto>();
        DataTable table = new DataTable();
        public FormCrearVenta()
        {
            InitializeComponent();
            service = new ClienteService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);
            VentaService = new FacturaVentaService(ConfigConnection.connectionString);
            detalleFactura = new DetalleFacturaVentaService(ConfigConnection.connectionString);

            //txtNumFactura.Text = VentaService.ConsultarIdFactura().ToString();


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
            try
            {
                int total = int.Parse(lblTotalFactura.Text);
                if (total > 0)
                {
                    RegistrarFactura();
                    MessageBox.Show("Venta realizada con exito ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar(); 
                }
               // dtgvFactura.Rows.Clear();
                //dtgvFactura.Refresh();


            }
            catch 
            {
                MessageBox.Show("Debe ingresar productos ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

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
            txtNumFactura.Text = "";


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
                int cantidaInicial = int.Parse(lblCantidad.Text);
                int cantidadDigitada = int.Parse(txtCantidad.Text);
                try
                {
                    if (cantidadDigitada > 0 && cantidadDigitada<=cantidaInicial)
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
            if (txtCodigoProd.Text.Equals(""))
            {
                MessageBox.Show("Debe buscar un producto ", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtCantidad.Text ="";
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
                txtNumeroDoc.Text = "";
            }

        }

        private void btnBuscarProduct_Click(object sender, EventArgs e)
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
                lblCantidad.Text = producto.Cantidad.ToString();
                lblPrecioVenta.Text = producto.Precio.ToString();
            }
            else
            {
                MessageBox.Show("Producto no existe", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Limpiar();
            }
        }
        private void RegistrarFactura()
        {

            FacturaVenta venta = new FacturaVenta();
            venta.CodigoFactura = txtNumFactura.Text;
            venta.IdCliente = txtNumeroDoc.Text;
            venta.Fecha = DateTime.Parse( LbelFechaFacturaVenta.Text);
            venta.ValorTotalFactura = Double.Parse(lblTotalFactura.Text);
            VentaService.GuardarFacturaVenta(venta);

            txtNumFactura.Text = VentaService.ConsultarIdFactura().ToString();

            foreach (DetalleFacturaVenta detalle in ventas)
            {
                detalle.CodigoVenta = txtNumFactura.Text;
            }

                foreach (DataGridViewRow row in dtgvFactura.Rows)
            {
                foreach (var item in ventas)
                {
                    row.Cells["codigoVenta"].Value = item.CodigoVenta;
                    row.Cells["CodigoProducto"].Value = item.CodigoProducto;
                    row.Cells["CantidadProducto"].Value = item.CantidadProducto;
                    row.Cells["Valorunitario"].Value = item.Valorunitario;
                    row.Cells["ValorSubTotal"].Value = item.ValorSubTotal;
                }
            }
            detalleFactura.GuardarDetallesVenta(ventas,productos);
            
        }
           

        private void BtnQuitarProducto_Click(object sender, EventArgs e)
        {

        }

       
        private void btnAgregar_Click(object sender, EventArgs e)
        {


            try
            {
                DetalleFacturaVenta detalle = new DetalleFacturaVenta();
                detalle.CodigoVenta = txtNumFactura.Text;
                detalle.CodigoProducto = txtCodigoProd.Text;
                detalle.CantidadProducto = int.Parse(txtCantidad.Text);
                detalle.Valorunitario = int.Parse(lblPrecioVenta.Text);
                detalle.ValorSubTotal = Double.Parse(lblTotal.Text);
                Producto producto = new Producto();
                producto.CodigoProducto = txtCodigoProd.Text;
                producto.Cantidad = int.Parse(txtCantidad.Text);

                productos.Add(producto);
                ventas.Add(detalle);
                dtgvFactura.DataSource = null;
            }
            catch { }
          

            foreach (DataGridViewRow row in dtgvFactura.Rows)
            {
                foreach (var item in ventas)
                {
                    row.Cells["codigoVenta"].Value = item.CodigoVenta;
                    row.Cells["CodigoProducto"].Value = item.CodigoProducto;
                    row.Cells["CantidadProducto"].Value = item.CantidadProducto;
                    row.Cells["Valorunitario"].Value = item.Valorunitario;
                    row.Cells["ValorSubTotal"].Value = item.ValorSubTotal;
                }
              
            }
            dtgvFactura.DataSource = ventas;
            int total = 0;
            foreach (DataGridViewRow row in dtgvFactura.Rows)
            {
                total += Convert.ToInt32(row.Cells["ValorSubTotal"].Value);
            }
            lblTotalFactura.Text = (total).ToString();
        }
       
    }
}


