using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_2.CapaDatos
{
    // Clase para manejar datos de equipos
    public class CD_Equipo
    {
        // Propiedades que corresponden a la tabla Equipos
        public int EquipoID { get; set; }           // ID único del equipo
        public string TipoEquipo { get; set; }      // Ej: Laptop, Impresora, Desktop
        public string Modelo { get; set; }          // Modelo específico
        public int UsuarioID { get; set; }          // ID del dueño (relación con Usuarios)
    }
}