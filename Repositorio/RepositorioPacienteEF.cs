using Modelos;

namespace Repositorio
{
    public class RepositorioPacienteEF : IRepositorioPaciente
    {
        private Contexto contexto = new Contexto();

        public void IngresarPaciente(Entidades.Paciente paciente)
        {
            var pacienteNuevo = new Paciente()
            {
                PrimerNombre = paciente.PrimerNombre,
                SegundoNombre = paciente.SegundoNombre,
                PrimerApellido = paciente.PrimerApellido,
                SegundoApellido = paciente.SegundoApellido,
                IdTipoDocumento = paciente.TipoDocumento.Id,
                NumeroDocumento = paciente.NumeroDocumento,
                IdSexo = paciente.Sexo.Id,
                FechaNacimiento = paciente.FechaNacimiento,
                Celular = paciente.Celular,
                IngresoBase = paciente.IngresoBase,
                Titular = paciente.Titular, 
            };

            contexto.Pacientes.Add(pacienteNuevo);
            contexto.SaveChanges();

            paciente.Id = pacienteNuevo.Id;
        }
    }
}
