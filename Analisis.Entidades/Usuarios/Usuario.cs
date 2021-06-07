using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Usuarios
{
    public class Usuario
    {
        public int idusuario { get; set; }
        [Required]
        [StringLength (100, MinimumLength =12, ErrorMessage ="el nombre debe tener al menos 12 caracteres")]
        public string nombre { get; set; }
        public int tipoDocumento { get; set; }
        public int numDocumento { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 20, ErrorMessage = "la direccion debe tener al menos 20 caracteres")]
        public string direccion { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "el numero de telefono debe contenes por lo menos 20 dígitos")]
        public string telefono { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 20, ErrorMessage = "el correo debe tener al menos 20 caracteres")]
        public string gmail { get; set; }
        public string password_hash { get; set; }
        public string password_salt { get; set; }
        public bool condicion { get; set; }

        public Ventas.Ingreso Ingreso
        {
            get => default;
            set
            {
            }
        }
    }
}
