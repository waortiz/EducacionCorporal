using Repositorio;

namespace Negocio
{
    public class ServicioSeguridad : IServicioSeguridad
    {
        private IRepositorioUsuario repositorioUsuario;

        public ServicioSeguridad()
        {
            repositorioUsuario = new RepositorioUsuarioEF();
        }

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            var usuario = repositorioUsuario.ObtenerUsuario(nombreUsuario);
            if (nombreUsuario == usuario.NombreUsuario &&
                    contraseña == usuario.Clave)
            {
                return true;
            }

            return false;
        }
    }
}