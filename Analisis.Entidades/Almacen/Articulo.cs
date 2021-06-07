using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Almacen
{
   public class Articulo
    {
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 12, ErrorMessage = "el nombre debe tener al menos 12 caracteres")]
        public string codigo { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "el nombre debe tener al menos 12 caracteres")]
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        public Categoria Categoria
        {
            get => default;
            set
            {
            }
        }

        public Categoria Categoria1
        {
            get => default;
            set
            {
            }
        }

        public Categoria Categoria2
        {
            get => default;
            set
            {
            }
        }
    }
}
