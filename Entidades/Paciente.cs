namespace Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public bool Titular { get; set; }
        public Sexo Sexo { get; set; }
        public string Celular { get; set; }
        public decimal IngresoBase { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
