using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tarea_1_condominio.Models;

namespace tarea_1_condominio.Services
{
    public class UsuarioService
    {
        public static List<Usuario> Usuarios = new List<Usuario>();

        public bool ExisteCorreo(string correo)
        {
            return Usuarios.Any(u => u.Correo == correo);
        }

        public Usuario UsuarioAuth(string correo, string pass)
        {
            return Usuarios
                        .FirstOrDefault(u =>
                            u.Correo == correo &&
                            u.Password == pass);
        }

        public void Agregar(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public string Registrar(Usuario usuario)
        {
            if (ExisteCorreo(usuario.Correo))
                return "El correo ya está registrado.";

            this.Agregar(usuario);
            return "Usuario registrado correctamente.";
        }

        public string Utenticar(Usuario usuario)
        {
            Usuario encontrado = this.UsuarioAuth(usuario.Correo, usuario.Password);
            if (encontrado != null)
            {
                return "Login Exitoso Bienvenido " + encontrado.Nombre + " " + encontrado.Apellidos;
            }

            return "Error en autenticación usuario no existe";
        }
    }
}