namespace Negocio
{
    public class ServicioSeguridadExterna : IServicioSeguridad
    {
        private const string USUARIO = "wortiz";
        private const string CONTRASEÑA = "123456";

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            //Conectarse servicio externo

            return true;
        }
    }
}