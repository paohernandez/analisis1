using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Ventas
{
    public class Venta
    {
        public int idusuario { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "en el tipo de comprobante debe de haber al menos 10 caracteres")]
        public string tipoComprobante { get; set; }
        [Required]
        [StringLength(7, ErrorMessage = "la serie debe tener al menos 7 caracteres")]
        public string serieComprobante { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "el numero de comprobante debe tener al menos 10 y minimo de 8 caracteres")]
        public string numComprobante { get; set; }
        public string fecha { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public bool condicion { get; set; }

    }
}
