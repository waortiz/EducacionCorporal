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
        /// Controlador de evento del bot�n Ingresar
        /// </summary>
        /// <param name="sender">Control que genera el evento</param>
        /// <param name="e">Par�metros del evento</param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contrase�a = txtContrase�a.Text;
            erpMensaje.SetError(txtUsuario, null);
            erpMensaje.SetError(txtContrase�a, null);
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                erpMensaje.SetError(txtUsuario, "Ingrese el usuario");
            }
            else if (string.IsNullOrEmpty(contrase�a))
            {
                erpMensaje.SetError(txtContrase�a, "Ingrese la contrase�a");
            }
            else
            {
                if (seguridad.ValidarUsuario(nombreUsuario, contrase�a))
                {
                    var formulario = new FormularioPrincipal();
                    formulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos de ingreso no son v�lidos",
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