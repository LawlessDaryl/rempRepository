using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class DescuentosSalarioEmpleado
    {
        public int Id { get; set; }
        public int? EmpleadoId { get; set; }
        public int? DescuentosSalarioId { get; set; }
        public string Observaciones { get; set; }

        public virtual DescuentosSalario DescuentosSalario { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
