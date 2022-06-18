using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

#nullable disable

namespace remp.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Empleados = new HashSet<Empleado>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El nombre es obligatorio")]
        [MaxLength(200, ErrorMessage="Nombre max de 200")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="El apellido es obligatorio")]
        [MaxLength(200, ErrorMessage="apellido max de 200")]
        public string Apellido { get; set; }

        [Required(ErrorMessage="El telefono es obligatorio")]
        [MaxLength(200, ErrorMessage="telefono max de 200")]
        public int? Telefono { get; set; }

        [Required(ErrorMessage="El direccion es obligatorio")]
        [MaxLength(200, ErrorMessage="direccion max de 200")]
        public string Direccion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
