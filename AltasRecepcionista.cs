

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
    public partial class AltasRecepcionista : Form
    {
        public AltasRecepcionista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador NuevaVentana = new MenuAdministrador();
            NuevaVentana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recepcionista agregar = new Recepcionista();
            agregar.nombre = txtNombre.Text;
            agregar.apellidoPaterno = txtApellidoP.Text;
            agregar.apellidoMaterno = txtApellidoM.Text;
            agregar.curp = txtCurp.Text;
            agregar.domicilio = txtDomicilio.Text;
            agregar.telefono = txtTelefono.Text;
            agregar.fechaNac = txtFechaNac.Text;
            agregar.fechaIng = txtFechaIng.Text;
            int retorno = funciones.agregarRecepcionista(agregar);
            if (retorno > 0)
            {
                MessageBox.Show("Se agrego correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
        }
    }
}
