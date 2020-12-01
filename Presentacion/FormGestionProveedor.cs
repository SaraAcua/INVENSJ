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
    public partial class FormGestionProveedor : Form
    {
        public FormGestionProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del registro proveedor?", @"Atención",
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
