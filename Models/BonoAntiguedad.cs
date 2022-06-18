using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class BonoAntiguedad
    {
        public BonoAntiguedad()
        {
            BonoAntiguedadEmpleados = new HashSet<BonoAntiguedadEmpleado>();
        }

        public int Id { get; set; }
        public decimal? Minimo { get; set; }
        public decimal? Macimo { get; set; }
        public decimal? Porcentaje { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<BonoAntiguedadEmpleado> BonoAntiguedadEmpleados { get; set; }
    }
}
