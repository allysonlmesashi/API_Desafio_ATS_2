using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Queries.VacancyApplication
{
    public class GetAllCandidatesByVacancyIdQuery : IRequest<IEnumerable<VacancyApplicationDTO>>
    {
        public Guid Id { get; }
        public GetAllCandidatesByVacancyIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
