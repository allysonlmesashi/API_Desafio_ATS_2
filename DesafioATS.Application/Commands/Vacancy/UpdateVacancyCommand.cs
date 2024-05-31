using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Commands.Vacancy
{
    public class UpdateVacancyCommand : IRequest<VacancyDTO>
    {
        public VacancyDTO VacancyDTO { get; private set; }
        public Guid Id { get; }

        public UpdateVacancyCommand(Guid id, VacancyDTO vacancyDTO)
        {
            Id = id;
            VacancyDTO = vacancyDTO;
        }
    }
}
