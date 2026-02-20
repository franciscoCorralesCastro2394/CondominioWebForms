using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tarea_1_condominio.Models
{
    public abstract class Actividad
    {
        public string Titulo { get; set; }
        public bool EsParaTodos { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaCierre { get; set; }

        public string TipoActividad { get; set; }
    }
}