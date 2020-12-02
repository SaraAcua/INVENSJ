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
    public partial class FormGestionCliente : Form
    {
        ClienteRepository cliente = new ClienteRepository();
        public FormGestionCliente()
        {
            InitializeComponent();
         
        }
        private void inhhabilitar()
        {

        }
      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del registro cliente?", @"Atención",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
              
            }
            else
            {
                this.DialogResult = DialogResult.None;
                //btnCancelar.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtId.Text=
        }
    }
}
