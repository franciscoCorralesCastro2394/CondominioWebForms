using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tarea_1_condominio.Models
{
    public class Recordatorio : Actividad
    {
        public string Descripcion { get; set; }

        public Recordatorio()
        {
            TipoActividad = "Recordatorio";
        }
    }
}