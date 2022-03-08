using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePeliculas.Entidades
{
    //[Table("NombreTabla", Schema = "NombreSchema")]
    public class Genero
    {
        //[Key]
        public int Identificador { get; set; }
        //[MaxLength(150)] //Longitud maxima
        //[StringLength(150)] //Longitud maxima (Valida desde el servidor y el cliente... entrda de usuario)
        //[Required] //NOT NULL
        public string Nombre { get; set; }
        public HashSet<Pelicula> Peliculas { get; set; }
    }
}
