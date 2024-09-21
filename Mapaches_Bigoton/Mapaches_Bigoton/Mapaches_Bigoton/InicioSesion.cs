using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mapaches_Bigoton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Aquí puedes definir tus usuarios y contraseñas válidos
            string usuarioValido = "admin";
            string contraseñaValida = "1234";

            if (usuario == usuarioValido && contraseña == contraseñaValida)
            {
                MessageBox.Show("Usuario validado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Abrir el nuevo formulario
                menu.Show(); // Muestra el formulario menu
                this.Hide(); // (Opcional) Oculta el formulario actual si no deseas que siga visible
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // No deshabilites el botón de validación
                // btnIniciar.Enabled = false; // Esta línea se ha comentado o eliminado
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

