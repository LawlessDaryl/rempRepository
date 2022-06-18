using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public int? EmpleadoId { get; set; }
        public string Usuario1 { get; set; }
        public string Password { get; set; }
        public string Observaciones { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
