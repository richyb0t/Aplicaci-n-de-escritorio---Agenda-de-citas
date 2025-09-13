

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.mysql;

namespace Proyecto
{
    public partial class AltasCitas : Form
    {
        public AltasCitas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cita agregar = new Cita();
            agregar.dia = txtDia.Text;
            agregar.hora = txtHora.Text;
            agregar.nombreDoctor = txtNombreD.Text;
            agregar.nombrePaciente = txtNombreP.Text;
            
            int retorno = funciones.agregarCita(agregar);
            if (retorno > 0)
            {
                MessageBox.Show("Se agrego correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recepcionistas NuevaVentana = new Recepcionistas();
            NuevaVentana.Show();
        }
    }
}
