using Entidades;
using Repositorio;

namespace Negocio
{
    public class ServicioPaciente : IServicioPaciente
    {
        IRepositorioPaciente repositorioPaciente;
        public ServicioPaciente(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }

        public ServicioPaciente()
        {
            this.repositorioPaciente = new RepositorioPacienteEF();
        }

        public void IngresarPaciente(Paciente paciente)
        {
            //Aplicar reglas de negocio

            //Guardamos en el repositorio
            repositorioPaciente.IngresarPaciente(paciente);
        }
    }
}
