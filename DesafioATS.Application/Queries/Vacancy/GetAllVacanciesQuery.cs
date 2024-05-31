using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Queries.Vacancy
{
    public class GetAllVacanciesQuery : IRequest<IEnumerable<VacancyDTO>>
    {
    }
}
