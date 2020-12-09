using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace Presentacion
{
    public partial class FormMovimientos : Form
    {
        MovimientosService movimientosService;
        Movimientos movimientos;
        Producto producto;
        ProductoService productoService;
        public FormMovimientos()
        {
            InitializeComponent();
            movimientosService = new MovimientosService(ConfigConnection.connectionString);
            productoService = new ProductoService(ConfigConnection.connectionString);
            Gestionar();
            LlenarCombo();
        }

        private void LlenarCombo()
        {
            cmboMotivo.Items.Add("AVERÍA");
            cmboMotivo.Items.Add("REGALO");
            cmboConsulta.Items.Add("AVERÍA");
            cmboConsulta.Items.Add("REGALO");

        }

        private void Gestionar()
        {
            LbelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmboConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboMotivo.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        private Movimientos MapearMovimiento()
        {
            movimientos = new Movimientos();
            movimientos.Motivo = cmboMotivo.Text;
            movimientos.Codigo = txtCodigo.Text;
            movimientos.Cantidad = int.Parse(txtCantidad.Text);
            movimientos.Fecha = DateTime.Parse(LbelFecha.Text);
            movimientos.Descripcion = txtObservacion.Text;
            return movimientos;

        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {


                int cantidad = int.Parse(lblCantidaInicial.Text);
                int cantidadDigitada = int.Parse(txtCantidad.Text);

                if (txtCodigo.Text.Equals("") || int.Parse(txtCantidad.Text) <= 0 || cmboMotivo.SelectedItem.Equals("")
                    || txtCantidad.Text.Equals(" ") || txtObservacion.Text.Equals(""))
                {

                    MessageBox.Show("Debe digitar los datos requeridos ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (cantidadDigitada > cantidad)
                {
                    MessageBox.Show(" Cantidad no disponible ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                else
                {
                    Movimientos movimientos = MapearMovimiento();
                    string mensaje = movimientosService.GuardarMovimiento(movimientos);
                    Producto producto1 = new Producto();
                    producto.CodigoProducto = txtCodigo.Text;
                    producto.Cantidad = int.Parse(txtCantidad.Text);

                    movimientosService.ActualizarInventario(producto);
                    MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


                    Limpiar();

                }
            }
            catch
            {
                MessageBox.Show("Debe digitar los datos requeridos ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtObservacion.Text = "";
            lblCantidaInicial.Text = "";
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {


            ConsultaMovimientosRespuesta respuesta = new ConsultaMovimientosRespuesta();

           
                respuesta = movimientosService.BuscarPorMotivo(cmboConsulta.Text);
                dtgvMovimientos.DataSource = respuesta.Movimientoss;
            LblTotal.Text = movimientosService.TotalizarTipo(cmboConsulta.Text).Cuenta.ToString();
            

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
            // only allow one decimal point if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; } }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show(@"Esta seguro que desea cancelar del registro de salida?", @"Atención",
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



        private void BtnBuscarCantidad_Click(object sender, EventArgs e)
        {
            BusquedaProductoRespuesta consulta = new BusquedaProductoRespuesta();
            consulta = productoService.BuscarPorcodigo(txtCodigo.Text);
            if (!consulta.Error)
            {
                producto = consulta.Producto;
                lblCantidaInicial.Text = producto.Cantidad.ToString();

            }
            else
            {
                MessageBox.Show("Producto no esta registrado ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }

        }
    }
}
    
  
        


