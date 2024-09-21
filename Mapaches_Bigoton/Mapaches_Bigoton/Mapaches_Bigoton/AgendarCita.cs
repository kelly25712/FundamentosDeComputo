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
    public partial class AgendarCita : Form


    {
    Citas enviar = new Citas();
        public AgendarCita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtFecha.Clear();
            txtTelefono.Clear();
            cmbHora.ResetText();
            cmbServicio.ResetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            enviar.pnombre = txtNombre.Text;
            enviar.ptelefono = txtFecha.Text;
            enviar.phora = txtTelefono.Text;
            enviar.pservicio = txtTelefono.Text;

            txtFecha.Text = monthCalendar1.SelectionRange.Start.ToString();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu main = new Menu();
            main.Show();
            this.Hide();


        }
    }
}
