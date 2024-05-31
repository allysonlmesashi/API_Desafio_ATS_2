using DesafioATS.Domain.Entities;
using FluentValidation;

namespace DesafioATS.Domain.Validations
{
    public class VacancyApplicationValidator : AbstractValidator<VacancyApplication>
    {
        public VacancyApplicationValidator() 
        { 
            RuleFor(a => a.CandidateId)
              .NotEmpty()
              .WithMessage("Deve ser informado o candidato.");
            RuleFor(a => a.VacancyId)
              .NotEmpty()
              .WithMessage("Deve ser informado a vaga.");
        }
    }
}
