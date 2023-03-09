namespace Negocio
{
    public class ServicioSeguridad : IServicioSeguridad
    {
        private const string USUARIO = "wortiz";
        private const string CONTRASEÑA = "123456";

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            if (nombreUsuario == USUARIO &&
                    contraseña == CONTRASEÑA)
            {
                return true;
            }

            return false;
        }
    }
}