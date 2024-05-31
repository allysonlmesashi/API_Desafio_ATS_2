using AutoMapper;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Queries.Vacancy
{
    public class GetAllVacanciesQueryHandler : IRequestHandler<GetAllVacanciesQuery, IEnumerable<VacancyDTO>>
    {
        private readonly IVacancyRepository _vacancyRepository;
        private readonly IMapper _mapper;

        public GetAllVacanciesQueryHandler(IVacancyRepository vacancyRepository, IMapper mapper)
        {
            _vacancyRepository = vacancyRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VacancyDTO>> Handle(GetAllVacanciesQuery request, CancellationToken cancellationToken)
        {
            var vacancies = await _vacancyRepository.GetAllVacanciesAsync();
            return _mapper.Map<IEnumerable<VacancyDTO>>(vacancies);
        }
    }
}
