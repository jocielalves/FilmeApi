using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {

        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
    }
}
