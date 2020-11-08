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
           
        }

        private void btnRegsitroProv_Click(object sender, EventArgs e)
        {
            FormGestionProveedor form = new FormGestionProveedor();
            form.ShowDialog();
                
        }

        private void FormGestionCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
