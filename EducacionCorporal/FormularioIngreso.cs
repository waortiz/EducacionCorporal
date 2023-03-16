using Negocio;

namespace EducacionCorporal
{
    public partial class FormularioIngreso : Form
    {
        IServicioSeguridad seguridad = new ServicioSeguridad();
        Color colorOriginal;

        public FormularioIngreso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controlador de evento del botón Ingresar
        /// </summary>
        /// <param name="sender">Control que genera el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            erpMensaje.SetError(txtUsuario, null);
            erpMensaje.SetError(txtContraseña, null);
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                erpMensaje.SetError(txtUsuario, "Ingrese el usuario");
            }
            else if (string.IsNullOrEmpty(contraseña))
            {
                erpMensaje.SetError(txtContraseña, "Ingrese la contraseña");
            }
            else
            {
                if (seguridad.ValidarUsuario(nombreUsuario, contraseña))
                {
                    var formulario = new FormularioPrincipal();
                    formulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos de ingreso no son válidos",
                        "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            this.btnIngresar.BackColor = Color.LightGray;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            this.btnIngresar.BackColor = colorOriginal;
        }

        private void FormularioIngreso_Load(object sender, EventArgs e)
        {
            colorOriginal = this.btnIngresar.BackColor;
        }
    }
}