using System;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class DescuentosSalario
    {
        public DescuentosSalario()
        {
            DescuentosSalarioEmpleados = new HashSet<DescuentosSalarioEmpleado>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal? Porcentaje { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<DescuentosSalarioEmpleado> DescuentosSalarioEmpleados { get; set; }
    }
}
