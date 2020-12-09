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
        FacturaCompraService compraService;
        DetalleFacturaCompra detalle;
        DetalleFacturaCompraService detalleService;
        List<DetalleFacturaCompra> compras = new List<DetalleFacturaCompra>();
        List<Producto> productos = new List<Producto>();
        public FormGestionCompra()
        {
            InitializeComponent();
            service = new ProveedorService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);
            compraService = new FacturaCompraService(ConfigConnection.connectionString);
            detalleService = new DetalleFacturaCompraService(ConfigConnection.connectionString);
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
            lblColor.Text = "";
            lblDescripcion.Text = "";
            txtNombreCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtBarrio.Text = "";
            txtTelefonoCliente.Text = "";
            LblSubtotal.Text = "";
           

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
               
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
            if (txtCodigoProd.Text.Equals(""))
            {
                MessageBox.Show("Debe buscar un producto ", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtCantidad.Text ="";
            }
       
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


            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                   

                    if (int.Parse(txtCantidad.Text) > 0)
                    {

                        int cantidad = int.Parse(txtCantidad.Text);
                        int precio = int.Parse(txtPrecio.Text);
                        LblSubtotal.Text = (cantidad * precio).ToString();
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
                txtCantidad.Text = "";
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
                txtNitProveedor.Text = "";
            }
        }


        private void RegistrarFactura()
        {

            FacturaCompra compra = new FacturaCompra();
            compra.CodigoFactura = txtNumeroCompra.Text;
            compra.CodigoProveedor = txtNitProveedor.Text;
            compra.Fecha = DateTime.Parse( LbelFechaFacturaCompra.Text);
            compra.ValorTotalFactura = Double.Parse(lblPrecioTotalCompra.Text);
            compraService.GuardarFacturaCompra(compra);

            
            foreach (DetalleFacturaCompra detalle in compras)
            {
                
                detalle.CodigoCompra = txtNumeroCompra.Text;
            }

            foreach (DataGridViewRow row in dtgvCompra.Rows)
            {
                foreach (var item in compras)
                {
                    row.Cells["codigoCompra"].Value = item.CodigoCompra;
                    row.Cells["CodigoProducto"].Value = item.CodigoProducto;
                    row.Cells["CantidadProducto"].Value = item.CantidadProducto;
                    row.Cells["Valorunitario"].Value = item.Valorunitario;
                    row.Cells["ValorSubTotal"].Value = item.ValorSubTotal;
                }
            }
            detalleService.GuardarDetallesCompra(compras, productos);
      
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleFacturaCompra detalle = new DetalleFacturaCompra();
                detalle.CodigoCompra = txtNumeroCompra.Text;
                detalle.CodigoProducto = txtCodigoProd.Text;
                detalle.CantidadProducto = int.Parse(txtCantidad.Text);
                detalle.Valorunitario = int.Parse(txtPrecio.Text);
                detalle.ValorSubTotal = Double.Parse(LblSubtotal.Text);
                
                Producto producto = new Producto();
                producto.CodigoProducto = txtCodigoProd.Text;
                producto.Cantidad = int.Parse(txtCantidad.Text);
                producto.Costo = int.Parse(txtPrecio.Text);
                producto.Precio = int.Parse(txtPrecioventa.Text);
                productos.Add(producto);

                compras.Add(detalle);
                dtgvCompra.DataSource = null;
            }
            catch { }
           

            foreach (DataGridViewRow row in dtgvCompra.Rows)
            {
                foreach (var item in compras)
                {
                    row.Cells["codigoCompra"].Value = item.CodigoCompra;
                    row.Cells["CodigoProducto"].Value = item.CodigoProducto;
                    row.Cells["CantidadProducto"].Value = item.CantidadProducto;
                    row.Cells["Valorunitario"].Value = item.Valorunitario;
                    row.Cells["ValorSubTotal"].Value = item.ValorSubTotal;
                }

            }
            dtgvCompra.DataSource = compras;
            int total = 0;
            foreach (DataGridViewRow row in dtgvCompra.Rows)
            {
                total += Convert.ToInt32(row.Cells["ValorSubTotal"].Value);
            }
            lblPrecioTotalCompra.Text = (total).ToString();
        }

        private void btnGenerarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                int total = int.Parse(lblPrecioTotalCompra.Text);
                if (total > 0)
                {

                    RegistrarFactura();
                    MessageBox.Show("Compra registrada  con exito ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Guardar Informe";
                    saveFileDialog.InitialDirectory = @"c:/document";
                    saveFileDialog.DefaultExt = "pdf";
                    string filename = "";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                    {
                        filename = saveFileDialog.FileName;
                        if (filename != "" && compras.Count > 0)
                        {
                            string mensaje = compraService.GenerarPdf(compras, filename);

                            MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        Limpiar();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar productos ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            //    if (dtgvCompra.CurrentRow == null)
            //        return;

            //    dtgvCompra.Rows.Remove(dtgvCompra.CurrentRow);
            //try
            //{
            //    dtgvCompra.Rows.RemoveAt(dtgvCompra.CurrentRow.Index);
            //}
            //catch { }

            //for (int i = 0; i < compras.Count; i++)
            //{
            //    compras.RemoveAt(i);
            //}


        }
    }
}


