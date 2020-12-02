using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
        public OracleDataReader ora_DataReader;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection("Data Source = localhost:1521 / xepdb1; User Id = invensj; Password = invensj"))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión válida ");
                }
                catch (Exception exception)
                {
                   MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
