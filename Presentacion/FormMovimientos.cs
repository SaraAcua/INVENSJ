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
    public partial class FormMovimientos : Form
    {
        public FormMovimientos()
        {
            InitializeComponent();
            LbelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {

        }
    }
}
