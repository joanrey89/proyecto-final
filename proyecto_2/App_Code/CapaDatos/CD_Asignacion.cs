using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace proyecto_2.CapaDatos
{
    // Clase para asignar técnicos a reparaciones
    public class CD_Asignacion
    {
        public int AsignacionID { get; set; }       // ID único de asignación
        public int ReparacionID { get; set; }       // ID de reparación
        public int TecnicoID { get; set; }          // ID del técnico asignado
        public DateTime FechaAsignacion { get; set; } // Cuándo se asignó
    }
}