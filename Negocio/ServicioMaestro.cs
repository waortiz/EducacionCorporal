using Entidades;
using Repositorio;

namespace Negocio
{
    public class ServicioMaestro : IServicioMaestro
    {
        private IRepositorioMaestro repositorioMaestro;

        public ServicioMaestro()
        {
            repositorioMaestro = new RepositorioMaestroEF();
        }

        public ServicioMaestro(IRepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            return repositorioMaestro.ObtenerTiposDocumento();
        }
    }
}