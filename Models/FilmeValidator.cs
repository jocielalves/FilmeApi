using FluentValidation;

namespace FilmesApi.Models
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator() {

            RuleFor(filme => filme.Titulo).NotEmpty().WithMessage("O título do filme é obrigatório").Length(100).WithMessage("O título não pode ter mais que 100 caracteres");
            RuleFor(filme => filme.Genero).NotEmpty().WithMessage("O gênero do filme deve ser informado.").Length(50).WithMessage("O gênero não pode ter mais que 50 caracteres");
            RuleFor(filme => filme.Diretor).NotEmpty().WithMessage("Informe o nome do diretor");
            RuleFor(filme => filme.Duracao).NotEmpty().WithMessage("Informe uma duração").InclusiveBetween(60, 360).WithMessage("A duração não pode ser menor que 60 minutos nem maior que 6 horas");
        }
    }
}
