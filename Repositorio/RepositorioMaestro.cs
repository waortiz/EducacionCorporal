using EducacionCorporal.Entidades;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        /// <summary>
        /// Este método pernmite obtener la lista de los tipos de
        /// documento
        /// </summary>
        /// <returns>Lista de lis tipos de documento</returns>
        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            //Lista de los tipos de documento
            var tiposDocumento = new List<TipoDocumento>();
            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cédula de Ciudadanía" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "Tarjeta de Identidad" });
            tiposDocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Cédula de Extranjería" });
            tiposDocumento.Add(new TipoDocumento() { Id = 4, Nombre = "Permiso Especial" });

            /*Se retorna la lista*/
            return tiposDocumento.OrderBy(t => t.Nombre).ToList();
        }
    }
}