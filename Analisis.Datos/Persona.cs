using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Datos
{
    public class Persona
    {
        public int idpersona { get; set; }
        public int tipoPersona { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "el nombre debe tener al menos 12 caracteres")]
        public string nombre { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccionPersona { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "el numero de telefono debe contenes por lo menos 20 dígitos")]
        public string telefonoPersona { get; set; }
        public string gmailPersona { get; set; }
    }
}
