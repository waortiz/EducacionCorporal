﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducacionCorporal
{
    public partial class FormularioPaciente : Form
    {
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
            cboTipoDocumento.DataSource = ObtenerTiposDocumento();
            cboTipoDocumento.DisplayMember = "Nombre";
        }

        /// <summary>
        /// Este método pernmite obtener la lista de los tipos de
        /// documento
        /// </summary>
        /// <returns>Lista de lis tipos de documento</returns>
        private List<TipoDocumento> ObtenerTiposDocumento()
        {
            //Lista de los tipos de documento
            var tiposDocumento = new List<TipoDocumento>();
            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cédula de Ciudadanía" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "Tarjeta de Identidad" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "Cédula de Extranjería" });

            /*Se retorna la lista*/
            return tiposDocumento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Try
                string primerNombre = txtPrimerNombre.Text;
                string segundoNombre = txtSegundoNombre.Text;
                decimal ingresoBase = Convert.ToDecimal(txtIngresoBase.Text);
                string error = string.Empty;

                if (string.IsNullOrEmpty(primerNombre))
                {
                    error = "El primer nombre no es correcto";
                    erpMensaje.SetError(txtPrimerNombre, error);
                }
                else
                {
                    erpMensaje.SetError(txtPrimerNombre, null);
                }

                if (error.Length > 0)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    //Guardamos al paciente
                    var mensaje = $"El ingreso es {ingresoBase.ToString("$#,###")}\n";
                    mensaje += $"La fecha de nacimiento es {dtpFechaNacimiento.Value.ToString("dd-MM-yyyy")}";
                    MessageBox.Show(mensaje);
;                }
                #endregion
            }
            catch (Exception ex) 
            { 
                //Log error
                MessageBox.Show("Te amamos mucho. Esperamos solucionar el inconveniente los mas pronto posible. Siempre pensamos en ti.");
            }
            finally
            {

            }
        }

        private void txtIngresoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= 48 && e.KeyChar <= 57 ))
            {
                e.Handled = true;
            }
        }

        private void txtIngresoBase_Validating(object sender, CancelEventArgs e)
        {
            erpMensaje.SetError(txtIngresoBase, null);
            if(decimal.Parse(txtIngresoBase.Text) > 20000000)
            {
                erpMensaje.SetError(txtIngresoBase, "El salairo base no puede ser mayor a $20 000 000");
            }

        }
    }
}