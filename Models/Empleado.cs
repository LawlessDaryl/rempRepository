using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            BonoAntiguedadEmpleados = new HashSet<BonoAntiguedadEmpleado>();
            DescuentosSalarioEmpleados = new HashSet<DescuentosSalarioEmpleado>();
            Usuarios = new HashSet<Usuario>();
            VacacionesEmpleados = new HashSet<VacacionesEmpleado>();
        }

        public int Id { get; set; }
        public int? PersonaId { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public int? CargoId { get; set; }

        public virtual Cargo Cargo { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<BonoAntiguedadEmpleado> BonoAntiguedadEmpleados { get; set; }
        public virtual ICollection<DescuentosSalarioEmpleado> DescuentosSalarioEmpleados { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<VacacionesEmpleado> VacacionesEmpleados { get; set; }
    }
}
