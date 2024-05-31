using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Commands.Vacancy
{
    public class CreateVacancyCommand : IRequest<VacancyDTO>
    {
        public VacancyDTO VacancyDTO { get; private set; }

        public CreateVacancyCommand(VacancyDTO vacancyDTO)
        {
            VacancyDTO = vacancyDTO;
        }
    }
}
