
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Almacen
{
    public class Almacen
    {
        public int idcategoria {get; set; }
        [ Required]
        [StringLength (50, MinimumLength =3, ErrorMessage ="nombre no debe de tener mas de 5o caracteres") ]

        public string nombre { get; set; }
        [StringLength(256) ]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
