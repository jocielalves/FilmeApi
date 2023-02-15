using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class FilmeDto
    {
       
        [Required(ErrorMessage = " O titulo do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O Gênero não pode ter mais que 50 caractere")]
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O genero do filme deve ser informado.")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "O campo de duração é obrigatório")]
        [Range(1, 360, ErrorMessage = "A duração mínima é 1 minuto enquanto a máxima é 6 horas")]
        public int Duracao { get; set; }
    }
}
