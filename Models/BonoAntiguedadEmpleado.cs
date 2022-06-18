using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class BonoAntiguedadEmpleado
    {
        public int Id { get; set; }
        public int? EmpleadoId { get; set; }
        public int? BonoId { get; set; }
        public string Nombre { get; set; }
        public decimal? Monto { get; set; }
        public string Descripcion { get; set; }

        public virtual BonoAntiguedad Bono { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
