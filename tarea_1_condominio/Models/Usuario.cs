using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tarea_1_condominio.Models
{
    public class Usuario
    {
        public string TipoId { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Filial { get; set; }
        public bool TieneConstruccion { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }

        public string rol { get; set; }
    }
}