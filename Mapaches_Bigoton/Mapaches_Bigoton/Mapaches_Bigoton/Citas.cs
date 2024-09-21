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
    public partial class Citas : Form
    {
        private String nombre, telefono, hora, fecha, servicio;
        public String pnombre
        {
            set
            {
                nombre = value;
            }
        }
        public String ptelefono
        {
            set
            {
                telefono = value;
            }
        }
        public String phora
        {
            set
            {
                hora = value;
            }
        }
        public String pfecha
        {
            set
            {
                fecha = value;
            }
        }
        public String pservicio
        {
            set
            {
                servicio = value;
            }
        }
        public Citas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu main = new Menu();
            main.Show();
            this.Hide();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int renglon = dataGridView1.Rows.Add();

            dataGridView1.Rows[renglon].Cells["Nombre"].Value = nombre;
            dataGridView1.Rows[renglon].Cells["Telefono"].Value = telefono;
            dataGridView1.Rows[renglon].Cells["Hora"].Value = hora;
            dataGridView1.Rows[renglon].Cells["Fecha"].Value = fecha;
            dataGridView1.Rows[renglon].Cells["Servicio"].Value = servicio;

        }
    }
}
