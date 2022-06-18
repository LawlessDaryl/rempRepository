using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public int? DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public int? NivelSalarialId { get; set; }
        public string Descripcion { get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual NivelSalarial NivelSalarial { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
