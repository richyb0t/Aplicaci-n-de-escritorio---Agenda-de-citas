

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
    public partial class AltasPacientes : Form
    {
        public AltasPacientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paciente agregar = new Paciente();
            agregar.nombre = txtNombre.Text;
            agregar.apellidoPaterno = txtApellidoP.Text;
            agregar.apellidoMaterno = txtApellidoM.Text;
            agregar.curp = txtCurp.Text;
            agregar.domicilio = txtDomicilio.Text;
            agregar.telefono = txtTelefono.Text;
            agregar.fechaNac = txtFechaNac.Text;
            int retorno = funciones.agregar(agregar);
            if(retorno > 0)
            {
                MessageBox.Show("Se agrego correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recepcionistas NuevaVentana = new Recepcionistas();
            NuevaVentana.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AltasPacientes_Load(object sender, EventArgs e)
        {

        }
    }
}
