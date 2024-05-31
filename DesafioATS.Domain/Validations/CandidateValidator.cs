using DesafioATS.Domain.Entities;
using FluentValidation;

namespace DesafioATS.Domain.Validations
{
    public class CandidateValidator : AbstractValidator<Candidate>
    {
        public CandidateValidator() 
        {
            RuleFor(c => c.Name)
              .NotEmpty()
              .WithMessage("Deve ser informado o nome do candidato.")
              .MaximumLength(70)
              .WithMessage("O nome deve ter no máximo 70 caracteres.");
            RuleFor(c => c.Email)
              .NotEmpty()
              .WithMessage("Deve ser informado o e-mail do candidato.")
              .MaximumLength(70)
              .WithMessage("O e-mail deve ter no máximo 70 caracteres.")
              .EmailAddress()
              .WithMessage("O e-mail informado não é válido.");
        }
    }
}
