using System.Data;
using proyecto_2.CapaDatos;

namespace proyecto_2.CapaLogica
{
    public class CL_Reparacion
    {
        public static DataTable Listar()
        {
            return CD_Reparacion.Listar();
        }
    }
}
