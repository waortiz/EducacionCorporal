using Negocio;

namespace EducacionCorporal
{
    public partial class FormularioIngreso : Form
    {
        IServicioSeguridad seguridad = new ServicioSeguridadExterna();
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
            {
                        }
                    {
                    }
            {
                {
                    }
                    {
            }

            return true;
        }


        /// <summary>
        /// Controlador de evento del botón Ingresar
        /// </summary>
        /// <param name="sender">Control que genera el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var formulario = new FormularioPrincipal();
            formulario.Show();
            this.Hide();
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