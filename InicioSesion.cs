

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int band1 = 0, band2 = 0, band3 = 0;

            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=hospital;Uid=root;pwd=1234");
            MySqlConnection cono = new MySqlConnection("server=127.0.0.1;database=hospital;Uid=root;pwd=1234");
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=hospital;Uid=root;pwd=1234");

            conectar.Open();
            cono.Open();
            con.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlCommand code = new MySqlCommand();
            MySqlCommand us = new MySqlCommand();
            MySqlConnection conectamos = new MySqlConnection();
            codigo.Connection = conectar;
            code.Connection = cono;
            us.Connection = con;

            codigo.CommandText = ("select * from doctor where nombre = '" + Usuario.Text + "'");
            code.CommandText = ("select * from recepcionista where nombre = '" + Usuario.Text + "'");
            us.CommandText = ("select *from usuarios where nombre = '" + Usuario.Text + "'and password = '" + Contraseña.Text + "' ");

            MySqlDataReader leer = codigo.ExecuteReader();
            MySqlDataReader lea = code.ExecuteReader();
            MySqlDataReader l = us.ExecuteReader();

            if (leer.Read())
            {
                band1 = 1;
            }

            if (lea.Read())
            {
                band2 = 1;
            }

            if (l.Read())
            {
                band3 = 1;
            }

            if ((band1 == 1) && (Contraseña.Text == "1234"))
            {
                this.Hide();
                MenuDoctor NuevaVentana = new MenuDoctor();
                NuevaVentana.textBox1.Text = Usuario.Text;
                NuevaVentana.Show();
            }
            else if ((band2 == 1) && (Contraseña.Text == "1234"))
            {
                this.Hide();
                Recepcionistas NuevaVentana = new Recepcionistas();
                NuevaVentana.Show();
            }
            else if (band3 == 1)
            {
                this.Hide();
                MenuAdministrador NuevaVentana = new MenuAdministrador();
                NuevaVentana.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            cono.Close();
            conectar.Close();
            con.Close();
        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {
            Contraseña.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su estadia");
            Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
