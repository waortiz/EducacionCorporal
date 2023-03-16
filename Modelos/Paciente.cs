using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdTipoDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public bool Titular { get; set; }
        public int IdSexo { get; set; }
        public string Celular { get; set; }
        public decimal IngresoBase { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual Sexo Sexo { get; set; }
    }
}
