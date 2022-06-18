using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class NivelSalarial
    {
        public NivelSalarial()
        {
            Cargos = new HashSet<Cargo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal? Monto { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cargo> Cargos { get; set; }
    }
}
