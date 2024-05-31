using AutoMapper;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Queries.Vacancy
{
    public class GetVacancyByIdQueryHandler : IRequestHandler<GetVacancyByIdQuery, VacancyDTO>
    {
        private readonly IVacancyRepository _vacancyRepository;
        private readonly IMapper _mapper;

        public GetVacancyByIdQueryHandler(IVacancyRepository vacancyRepository, IMapper mapper)
        {
            _vacancyRepository = vacancyRepository;
            _mapper = mapper;
        }

        public async Task<VacancyDTO> Handle(GetVacancyByIdQuery request, CancellationToken cancellationToken)
        {
            var vacancy = await _vacancyRepository.GetVacancyById(request.Id);
            return _mapper.Map<VacancyDTO>(vacancy);
        }
    }
}
