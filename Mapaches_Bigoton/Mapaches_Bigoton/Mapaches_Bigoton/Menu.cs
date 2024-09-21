using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapaches_Bigoton
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            AgendarCita main = new AgendarCita();
            this.Hide();

            main.Show();

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            Citas cita = new Citas();
            this.Hide();
            cita.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 sesion = new Form1();
            this.Hide();
            sesion.Show();

        }
    }
}
