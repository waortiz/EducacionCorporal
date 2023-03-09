namespace Negocio
{
    public interface IServicioSeguridad
    {
        bool ValidarUsuario(string nombre, string contraseña);
    }
}