using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class VacacionesEmpleado
    {
        public int Id { get; set; }
        public int? EmpleadoId { get; set; }
        public int? VacacionesId { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaRegreso { get; set; }
        public string Observaciones { get; set; }

        public virtual Empleado Empleado { get; set; }
        public virtual Vacacione Vacaciones { get; set; }
    }
}
