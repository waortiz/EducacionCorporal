using Entidades;

namespace Repositorio
{
    public class RepositorioMaestroEF : IRepositorioMaestro
    {
        private Modelos.Contexto contexto = new Modelos.Contexto();

        /// <summary>
        /// Este método pernmite obtener la lista de los tipos de
        /// documento
        /// </summary>
        /// <returns>Lista de lis tipos de documento</returns>
        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            return contexto.TiposDocumento.OrderBy(t => t.Nombre).Select(t => new Entidades.TipoDocumento()
            {
                Id = t.Id,
                Nombre = t.Nombre
            }).ToList();
        }
    }
}