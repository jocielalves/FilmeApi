using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required( ErrorMessage =" O titulo do filme é obrigatório")]
        [MaxLength(50, ErrorMessage ="O título não pode ter mais que 50 caractere")]
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O genero do filme deve ser informado.")]
        public string Genero { get; set; }
        [Required( ErrorMessage = "O campo de duração é obrigatório")]
        [Range( 1 , 360, ErrorMessage ="A duração mínima é 1 minuto enquanto a máxima é 6 horas")]
        public int Duracao { get; set; }
    }
}
