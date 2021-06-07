using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Info
{
    public class Telefonos
    {
        public int idcTelefonos { get; set; }
        public string tipoTelefono { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "el numero debe tener al menos 8 caracteres")]
        public string numTelefono { get; set; }
    }
}
