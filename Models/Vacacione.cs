using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class Vacacione
    {
        public Vacacione()
        {
            VacacionesEmpleados = new HashSet<VacacionesEmpleado>();
        }

        public int Id { get; set; }
        public int? MinimoAnios { get; set; }
        public int? MaximoAnios { get; set; }
        public int? CantidadDias { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<VacacionesEmpleado> VacacionesEmpleados { get; set; }
    }
}
