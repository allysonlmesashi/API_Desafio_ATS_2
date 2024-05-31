using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Queries.Vacancy
{
    public class GetVacancyByIdQuery : IRequest<VacancyDTO>
    {
        public Guid Id { get; }

        public GetVacancyByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
