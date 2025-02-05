﻿using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Ciudad
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int? IdDepartamento { get; set; }

        public virtual Departamento? IdDepartamentoNavigation { get; set; }
    }
}
