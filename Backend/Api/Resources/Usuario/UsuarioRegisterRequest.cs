﻿namespace Api.Resources.Usuario
{
    public class UsuarioRegisterRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public int IdDepartamento { get; set; }
    }
}
