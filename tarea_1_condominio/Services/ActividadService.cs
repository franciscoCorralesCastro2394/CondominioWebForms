using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tarea_1_condominio.Models;

namespace tarea_1_condominio.Services
{
    public static class ActividadService
    {
        
        public static List<Actividad> ListaActividades = InitializeListaActividades();

        private static List<Actividad> InitializeListaActividades()
        {
            var lista = new List<Actividad>();
            CargarDatosPrueba(lista);
            return lista;
        }

        private static void CargarDatosPrueba(List<Actividad> lista)
        {
            lista.Add(new Reunion
            {
                Id = Guid.NewGuid().ToString(),
                Titulo = "Asamblea General",
                EsParaTodos = true,
                FechaPublicacion = DateTime.Now,
                FechaCierre = DateTime.Now.AddDays(7),
                FechaHoraReunion = DateTime.Now.AddDays(2),
                DuracionEstimada = "2 horas",
                Agenda = "Presupuesto anual",
                UbicacionPresencial = "Salón Comunal",
                EnlaceVirtual = "https://meet.com/asamblea",
                Creador = "corrales.castro.f55@gmail.com",
                estado = true
            });

            lista.Add(new ActividadSocial
            {
                Id = Guid.NewGuid().ToString(),
                Titulo = "Fiesta de Navidad",
                EsParaTodos = true,
                FechaPublicacion = DateTime.Now,
                FechaCierre = DateTime.Now.AddDays(10),
                FechaInicio = DateTime.Now.AddDays(15),
                FechaFin = DateTime.Now.AddDays(15).AddHours(5),
                Ubicacion = "Área BBQ",
                Formato = "Informal",
                Instrucciones = "Traer comida para compartir",
                Creador = "corrales.castro.f55@gmail.com",
                estado = true
            });

            lista.Add(new Recordatorio
            {
                Id = Guid.NewGuid().ToString(),
                Titulo = "Pago de cuota mensual",
                EsParaTodos = true,
                FechaPublicacion = DateTime.Now,
                FechaCierre = DateTime.Now.AddDays(5),
                Descripcion = "Recordatorio de pago antes del día 5.",
                Creador = "corrales.castro.f55@gmail.com",
                estado = true
            });
        }

        public static string AgregarActividad(Actividad actividad)
        {

            try {
                ListaActividades.Add(actividad);
                return "Se ha guardado con exito la Actividad ";
            } catch (Exception e) {
                return "Error " + e.Message;
            }

        }


        public static string EliminarActividad(string id)
        {
            var actividad = ListaActividades.FirstOrDefault(a => a.Id == id);

            if (actividad != null)
            {
                ListaActividades.Remove(actividad);
                return "Actividad eliminada correctamente.";
            }

            return "Error No se encontró la actividad con el ID proporcionado.";
        }
    }
}