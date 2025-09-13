


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
    public partial class AgregarExpedienteAltas : Form
    {
        public AgregarExpedienteAltas()
        {
            InitializeComponent();
        }

        private void BuscarPaciente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPaciente.Text))
            {
                MessageBox.Show("Hay un campo vacio");
            }
            else
            {
                this.Hide();
                AltasExpedientes NuevaVentana = new AltasExpedientes();
                NuevaVentana.txtNombreDoc.Text = txtDoctor.Text;
                NuevaVentana.txtNombreP.Text = txtPaciente.Text;
                NuevaVentana.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDoctor NuevaVentana = new MenuDoctor();
            NuevaVentana.textBox1.Text = txtDoctor.Text;
            NuevaVentana.Show();
        }
    }
}
