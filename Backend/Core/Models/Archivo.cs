﻿using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Archivo
    {
        public int Id { get; set; }
        public int? IdEspecialista { get; set; }
        public bool? FotoPerfil { get; set; }
        public byte[]? DataArchivo { get; set; }

        public virtual Especialista? IdEspecialistaNavigation { get; set; }
    }
}
