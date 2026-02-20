using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tarea_1_condominio.Models;

namespace tarea_1_condominio.Services
{
    public static class UsuarioService
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>();

        public static bool ExisteCorreo(string correo)
        {
            return ListaUsuarios.Any(u => u.Correo == correo);
        }

        static UsuarioService()
        {
            ListaUsuarios = new List<Usuario>();
            CargarUsuariosPrueba();
        }

        private static void CargarUsuariosPrueba()
        {
            ListaUsuarios.Add(new Usuario
            {
                TipoId = "Cedula",
                Identificacion = "101110111",
                Nombre = "Carlos",
                Apellidos = "Ramírez Soto",
                FechaNacimiento = new DateTime(1985, 5, 10),
                Filial = "A",
                TieneConstruccion = true,
                Correo = "corrales.castro.f55@gmail.com",
                Password = "123"
            });

            ListaUsuarios.Add(new Usuario
            {
                TipoId = "Cedula",
                Identificacion = "202220222",
                Nombre = "María",
                Apellidos = "López Vargas",
                FechaNacimiento = new DateTime(1990, 8, 22),
                Filial = "B",
                TieneConstruccion = false,
                Correo = "maria@condominio.com",
                Password = "1234"
            });

            ListaUsuarios.Add(new Usuario
            {
                TipoId = "Pasaporte",
                Identificacion = "P99887766",
                Nombre = "Juan",
                Apellidos = "Pérez Gómez",
                FechaNacimiento = new DateTime(1988, 3, 15),
                Filial = "C",
                TieneConstruccion = true,
                Correo = "juan@condominio.com",
                Password = "1234"
            });
        }

        public static Usuario UsuarioAuth(string correo, string pass)
        {
            return ListaUsuarios
                        .FirstOrDefault(u =>
                            u.Correo == correo &&
                            u.Password == pass);
        }

        public static void Agregar(Usuario usuario)
        {
            ListaUsuarios.Add(usuario);
        }

        public static string Registrar(Usuario usuario)
        {
            if (ExisteCorreo(usuario.Correo))
                return "El correo ya está registrado.";

            Agregar(usuario);
            return "Usuario registrado correctamente.";
        }

        public static string Utenticar(Usuario usuario)
        {
            Usuario encontrado = UsuarioAuth(usuario.Correo, usuario.Password);
            if (encontrado != null)
            {
                return "Login Exitoso Bienvenido " + encontrado.Nombre + " " + encontrado.Apellidos;
            }

            return "Error el usuario y/o la contraseña son inválidos, intente de nuevo";
        }
    }
}