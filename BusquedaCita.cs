

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
    public partial class BusquedaCita : Form
    {
        public BusquedaCita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text) || String.IsNullOrWhiteSpace(txtNombreDoctor.Text))
            {
                MessageBox.Show("Hay uno o mas campos vacios");
            }
            else
            {
                dvgBuscar.DataSource = funciones.BuscarCita(txtNombrePaciente.Text, txtNombreDoctor.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recepcionistas NuevaVentana = new Recepcionistas();
            NuevaVentana.Show();
        }
    }
}
