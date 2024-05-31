using DesafioATS.Domain.Entities;
using FluentValidation;

namespace DesafioATS.Domain.Validations
{
    public class VacancyValidator : AbstractValidator<Vacancy>
    {
        public VacancyValidator()
        {
            RuleFor(j => j.Description)
              .NotEmpty()
              .WithMessage("Deve ser informado a decrição da vaga.")
              .MaximumLength(100)
              .WithMessage("A decrição deve ter no máximo 100 caracteres.");
            RuleFor(j => j.Salary)
              .GreaterThan(0)
              .WithMessage("Deve ser informado o salário da vaga.");
        }
    }
}
