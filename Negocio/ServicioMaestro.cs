using EducacionCorporal.Entidades;
using Repositorio;

public class ServicioMaestro : IServicioMaestro
{
    private IRepositorioMaestro repositorioMaestro;
    
    public ServicioMaestro()
    {
        repositorioMaestro = new RepositorioMaestro();
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