using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos
{
    public class Rol
    {
        public int idrol { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 18, ErrorMessage = "el nombre debe tener al menos 18 caracteres")]
        public string nombreRol { get; set; }
        public string descripcionRol { get; set; }
        public bool condicionRol { get; set; }

    }

}