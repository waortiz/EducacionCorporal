using Entidades;

namespace Repositorio
{
    public class RepositorioUsuarioEF : IRepositorioUsuario
    {
        private Modelos.Contexto contexto = new Modelos.Contexto();

        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            var usuarioActual = contexto.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            return new Usuario()
            {
                Clave = usuarioActual.Clave,
                Id = usuarioActual.Id,
                NombreUsuario = nombreUsuario
            };
        }
    }
}
