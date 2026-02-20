using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tarea_1_condominio.Models
{
    public class ActividadSocial : Actividad
    {

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Ubicacion { get; set; }
        public string Formato { get; set; }
        public string Instrucciones { get; set; }

        public ActividadSocial()
        {
            TipoActividad = "Social";
        }
    }
}