using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Analisis.Entidades.Info
{
    public class Cliente
    {
        public int idcliente { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "el nombre debe tener al menos 12 caracteres")]
        public string nombreCliente { get; set; }
        public string tipoCliente { get; set; }
        public string direccionCliente { get; set; }
        public string gmailCliente { get; set; }

        public Telefonos Telefonos
        {
            get => default;
            set
            {
            }
        }

        public Telefonos Telefonos1
        {
            get => default;
            set
            {
            }
        }

        public Telefonos Telefonos2
        {
            get => default;
            set
            {
            }
        }
    }
}
