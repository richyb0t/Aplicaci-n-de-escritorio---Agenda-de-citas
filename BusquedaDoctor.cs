

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class BusquedaDoctor : Form
    {
        public BusquedaDoctor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador NuevaVentana = new MenuAdministrador();
            NuevaVentana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtCurp.Text))
            {
                MessageBox.Show("Hay uno o mas campos vacios");
            }
            else
            {
                dvgBuscar.DataSource = funciones.BuscarDoctor(txtNombre.Text, txtCurp.Text);
            }
        }
    }
}
