﻿using System;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void BtnRegsitrarCliente_Click(object sender, EventArgs e)
        {
            FormGestionCliente gestionCliente = new FormGestionCliente();
            gestionCliente.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FormGestionCliente gestionCliente = new FormGestionCliente();
            gestionCliente.ShowDialog();
        }
    }
}
