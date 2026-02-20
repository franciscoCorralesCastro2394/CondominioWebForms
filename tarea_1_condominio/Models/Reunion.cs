using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tarea_1_condominio.Models
{
    public class Reunion : Actividad
    {
        public DateTime FechaHoraReunion { get; set; }
        public string DuracionEstimada { get; set; }
        public string Agenda { get; set; }
        public string UbicacionPresencial { get; set; }
        public string EnlaceVirtual { get; set; }

        public Reunion()
        {
            TipoActividad = "Reunion";
        }
    }
}