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
    public partial class Recepcionistas : Form
    {
        public Recepcionistas()
        {
            InitializeComponent();
        }

       

        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion NuevaVentana = new InicioSesion();
            NuevaVentana.Show();
        }

        private void Recepcionista_Load(object sender, EventArgs e)
        {

        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltasCitas NuevaVentana = new AltasCitas();
            NuevaVentana.Show();
        } 

        private void altasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltasPacientes NuevaVentana = new AltasPacientes();
            NuevaVentana.Show();
        }

        private void individualesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_Paciente NuevaVentana = new Busqueda_Paciente();
            NuevaVentana.Show();
        }

        private void generalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultasGenPacientes NuevaVentana = new ConsultasGenPacientes();
            NuevaVentana.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void individualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaCita NuevaVentana = new BusquedaCita();
            NuevaVentana.Show();
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultasGenCitas NuevaVentana = new ConsultasGenCitas();
            NuevaVentana.Show();
        }
    }
}
