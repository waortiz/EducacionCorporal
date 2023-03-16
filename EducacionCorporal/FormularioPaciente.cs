using Entidades;
using Negocio;
using System.ComponentModel;

namespace EducacionCorporal
{
    public partial class FormularioPaciente : Form
    {
        private IServicioMaestro servicioMaestro = new ServicioMaestro();
        private IServicioPaciente servicioPaciente = new ServicioPaciente();
        public FormularioPaciente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Load
        /// </summary>
        /// <param name="sender">Elemento que genera el evento</param>
        /// <param name="e">Parámetros del evento</param>
        private void FormularioPaciente_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.DataSource = servicioMaestro.ObtenerTiposDocumento();
            cboTipoDocumento.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Try
                if (!ValidarDatos())
                {
                    MessageBox.Show("Por favor verifique los datos ingresados");
                }
                else
                {
                    //Guardamos al paciente
                    var paciente = new Paciente()
                    {
                        PrimerNombre = txtPrimerNombre.Text,
                        SegundoNombre = txtSegundoNombre.Text,
                        PrimerApellido = txtPrimerApellido.Text,
                        SegundoApellido = txtSegundoApellido.Text,
                        NumeroDocumento = txtNumeroDocumento.Text,
                        TipoDocumento = cboTipoDocumento.SelectedItem as TipoDocumento,

                        Titular = chkTitular.Checked,
                        Sexo = new Sexo() { Id = rdbFemenino.Checked ? (int)TipoSexo.Femenino : (int)TipoSexo.Masculino },
                        Celular = txtCelular.Text,
                        IngresoBase = Convert.ToDecimal(txtIngresoBase.Text),
                        FechaNacimiento = dtpFechaNacimiento.Value
                    };

                    servicioPaciente.IngresarPaciente(paciente);

                    var mensaje = $"El paciente se ha ingresado correctamente";
                    MessageBox.Show(mensaje);
                    ;
                }
                #endregion
            }
            catch
            {
                //Log error
                MessageBox.Show("Te amamos mucho. Esperamos solucionar el inconveniente los mas pronto posible. Siempre pensamos en ti.");
            }
            finally
            {

            }
        }

        private bool ValidarDatos()
        {
            string error = string.Empty;

            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                error = "El primer nombre no es correcto";
                erpMensaje.SetError(txtPrimerNombre, error);
            }
            else
            {
                erpMensaje.SetError(txtPrimerNombre, null);
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                error = "El primer apellido no es correcto";
                erpMensaje.SetError(txtPrimerApellido, error);
            }
            else
            {
                erpMensaje.SetError(txtPrimerApellido, null);
            }
            if (cboTipoDocumento.SelectedItem == null)
            {
                error = "El tipo de documento no es correcto";
                erpMensaje.SetError(cboTipoDocumento, error);
            }
            else
            {
                erpMensaje.SetError(cboTipoDocumento, null);
            }
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                error = "El número de documento no es correcto";
                erpMensaje.SetError(txtNumeroDocumento, error);
            }
            else
            {
                erpMensaje.SetError(txtNumeroDocumento, null);
            }
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                error = "La fecha de nacimiento no puede ser mayor a la fecha actual";
                erpMensaje.SetError(dtpFechaNacimiento, error);
            }
            else
            {
                erpMensaje.SetError(dtpFechaNacimiento, null);
            }
            if (rdbFemenino.Checked && rdbMasculino.Checked)
            {
                error = "Seleccione el sexo";
                erpMensaje.SetError(rdbFemenino, error);
            }
            else
            {
                erpMensaje.SetError(rdbFemenino, null);
            }
            if (string.IsNullOrEmpty(txtIngresoBase.Text))
            {
                error = "El ingreso base no es correcto";
                erpMensaje.SetError(txtIngresoBase, error);
            }
            else
            {
                erpMensaje.SetError(txtIngresoBase, null);
            }
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                error = "El número de celular no es correcto";
                erpMensaje.SetError(txtCelular, error);
            }
            else
            {
                erpMensaje.SetError(txtCelular, null);
            }

            return error.Length == 0;
        }

        private void txtIngresoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = true;
            }
        }

        private void txtIngresoBase_Validating(object sender, CancelEventArgs e)
        {
            erpMensaje.SetError(txtIngresoBase, null);
            if (decimal.Parse(txtIngresoBase.Text) > 20000000)
            {
                erpMensaje.SetError(txtIngresoBase, "El salairo base no puede ser mayor a $20 000 000");
            }

        }
    }
}
