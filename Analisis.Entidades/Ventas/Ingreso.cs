using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Ventas
{
    public class Ingreso
    {

        public int idingreso { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 18, ErrorMessage = "el tipo comprobante debe tener al menos 18 caracteres")]
        public string tipoComprobante{ get; set; }
        [Required]
        [StringLength(7,  ErrorMessage = "la serie comprobante debe tener al menos 7 caracteres")]
        public string serieComprobante { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "el numero de comprobante debe tener al menos 7 caracteres")]
        public string numComprobante { get; set; }
        public string fecha { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public bool condicion { get; set; }

        public Almacen.Articulo Articulo
        {
            get => default;
            set
            {
            }
        }

        public Venta Venta
        {
            get => default;
            set
            {
            }
        }

        public DetalleIngreso DetalleIngreso
        {
            get => default;
            set
            {
            }
        }

        public DetalleIngreso DetalleIngreso1
        {
            get => default;
            set
            {
            }
        }

        public DetalleIngreso DetalleIngreso2
        {
            get => default;
            set
            {
            }
        }
    }
}
