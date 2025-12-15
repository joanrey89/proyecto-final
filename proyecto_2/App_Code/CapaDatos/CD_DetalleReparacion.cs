using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace proyecto_2.CapaDatos
{
    // Clase para detalles de reparación
    public class CD_DetalleReparacion
    {
        public int DetalleID { get; set; }          // ID único del detalle
        public int ReparacionID { get; set; }       // ID de la reparación principal
        public string Descripcion { get; set; }     // Qué se hizo/reparó
        public DateTime? FechaInicio { get; set; }  // Cuándo empezó (puede ser null)
        public DateTime? FechaFin { get; set; }     // Cuándo terminó (puede ser null)
    }
}