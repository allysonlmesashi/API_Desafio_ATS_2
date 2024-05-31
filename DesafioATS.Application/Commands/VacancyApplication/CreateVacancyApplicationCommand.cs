using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Commands.VacancyApplication
{
    public class CreateVacancyApplicationCommand : IRequest<VacancyApplicationDTO>
    {
        public VacancyApplicationDTO VacancyApplication { get; set; }

        public CreateVacancyApplicationCommand(VacancyApplicationDTO vacancyApplication)
        {
            VacancyApplication = vacancyApplication;
        }
    }
}
