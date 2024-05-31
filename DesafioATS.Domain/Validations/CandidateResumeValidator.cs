using DesafioATS.Domain.Entities;
using FluentValidation;

namespace DesafioATS.Domain.Validations
{
    public class CandidateResumeValidator : AbstractValidator<CandidateResume>
    {
        public CandidateResumeValidator()
        {
            RuleFor(cR => cR.CandidateId)
              .NotEmpty()
              .WithMessage("Deve ser informado o candidato.");
        }
    }
}
