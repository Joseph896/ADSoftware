﻿using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Busqueda = new HashSet<Busqueda>();
            Ciudades = new HashSet<Ciudad>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Busqueda> Busqueda { get; set; }
        public virtual ICollection<Ciudad> Ciudades { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
