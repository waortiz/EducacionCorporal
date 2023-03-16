using Entidades;

namespace Repositorio
{
    public interface IRepositorioUsuario
    {
        Usuario ObtenerUsuario(string nombreUsuario);
    }
}