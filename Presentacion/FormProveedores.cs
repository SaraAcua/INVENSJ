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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void BtnRegsitrarProv_Click(object sender, EventArgs e)
        {
            FormGestionProveedor gestionProveedor = new FormGestionProveedor();
            gestionProveedor.ShowDialog();
        }

        private void btnEditarProv_Click(object sender, EventArgs e)
        {
            FormGestionProveedor gestionProveedor = new FormGestionProveedor();
            gestionProveedor.ShowDialog();
        }
    }
}
