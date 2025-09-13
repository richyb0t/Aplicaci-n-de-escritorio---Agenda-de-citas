

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
    public partial class ConsultasGenCitas : Form
    {
        public ConsultasGenCitas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = funciones.mostrarCita();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recepcionistas NuevaVentana = new Recepcionistas();
            NuevaVentana.Show();
        }
    }
}
