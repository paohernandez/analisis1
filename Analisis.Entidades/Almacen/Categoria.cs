
using System.ComponentModel.DataAnnotations;

namespace Analisis.Entidades.Almacen
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 18, ErrorMessage = "el nombre debe tener al menos 18 caracteres")]
        public string nombreCategoria { get; set; }
        public string descripcionCategoria { get; set; }
        public bool condicionCategoria { get; set; }
    }
}
