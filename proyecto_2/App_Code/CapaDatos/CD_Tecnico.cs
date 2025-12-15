using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_2.CapaDatos
{
    // Clase para manejar datos de técnicos
    public class CD_Tecnico
    {
        public int TecnicoID { get; set; }          // ID único del técnico
        public string Nombre { get; set; }          // Nombre completo
        public string Especialidad { get; set; }    // Área de especialización
    }
}