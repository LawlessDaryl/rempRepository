using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Cargos = new HashSet<Cargo>();
        }

        public int Id { get; set; }
        public string NoombreDepartamento { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cargo> Cargos { get; set; }
    }
}
