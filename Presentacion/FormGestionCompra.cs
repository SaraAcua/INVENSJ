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
        public FormGestionCompra()
        {
            InitializeComponent();

            TxtTalla.Enabled = false;
            TxtColor.Enabled = false;
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
    }
}
