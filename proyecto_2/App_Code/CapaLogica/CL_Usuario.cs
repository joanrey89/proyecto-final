using System;
using proyecto_2.CapaDatos;

namespace proyecto_2.CapaLogica
{
    public class CL_Usuario
    {
        public static bool ValidarUsuario(string usuario, string clave)
        {
            return CD_Usuario.Validar(usuario, clave);
        }
    }
}