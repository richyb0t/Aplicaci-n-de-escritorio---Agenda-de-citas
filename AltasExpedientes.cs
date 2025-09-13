

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
using MySql.Data.MySqlClient;
namespace Proyecto
{
    public partial class AltasExpedientes : Form
    {
        public AltasExpedientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expediente agregar = new Expediente();
            agregar.nombreD = txtNombreDoc.Text;
            agregar.nombreP = txtNombreP.Text;
            agregar.apellidoPaternoP = txtApellidoPaternoP.Text;
            agregar.apellidoMaternoP = txtApellidoMaternoP.Text;
            agregar.curpP = txtCurp.Text;
            agregar.domicilioP = txtDomicilioP.Text;
            agregar.telefonoP = txtTelefonoP.Text;
            agregar.fechaNacP = txtFechaNacP.Text;
            agregar.padecimiento = txtPadecimiento.Text;
            agregar.comentario = txtComentario.Text;

            int retorno = funciones.agregarExpediente(agregar);
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
            MenuDoctor NuevaVentana = new MenuDoctor();
            NuevaVentana.textBox1.Text = txtNombreDoc.Text;
            NuevaVentana.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string paciente = txtNombreP.Text;

            MySqlConnection cono = new MySqlConnection("server=LocalHost;database=hospital;Uid=root;pwd=1234");
            cono.Open();
            MySqlCommand code = new MySqlCommand();
            code.Connection = cono;
            code.CommandText = ("select * from paciente where nombre = '" + paciente + "' ");
            MySqlDataReader lea = code.ExecuteReader();

            while (lea.Read())
            {
                Paciente c = new Paciente();

                c.apellidoPaterno = lea.GetString(1);
                c.apellidoMaterno = lea.GetString(2);
                c.curp = lea.GetString(3);
                c.domicilio = lea.GetString(4);
                c.telefono = lea.GetString(5);
                c.fechaNac = lea.GetString(6);

                string apellidoPaterno = c.apellidoPaterno;
                string apellidoMaterno = c.apellidoMaterno;
                string curp = c.curp;
                string domicilio = c.domicilio;
                string telefono = c.telefono;
                string fechaNac = c.fechaNac;
                string fechas = fechaNac.Remove(10, 15);
                DateTime dateValues = DateTime.ParseExact(fechas, "dd/MM/yyyy", null);
                string DIASql = dateValues.ToString("yyyy-MM-dd");



                txtApellidoMaternoP.Text = apellidoMaterno;
                txtApellidoPaternoP.Text = apellidoPaterno;
                txtCurp.Text = curp;
                txtDomicilioP.Text = domicilio;
                txtTelefonoP.Text = telefono;
                txtFechaNacP.Text = DIASql;
            }
            cono.Close();
        }

        private void txtApellidoPaternoP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
