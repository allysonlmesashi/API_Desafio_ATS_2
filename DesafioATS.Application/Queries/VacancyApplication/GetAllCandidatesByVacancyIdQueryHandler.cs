using AutoMapper;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Queries.VacancyApplication
{
    public class GetAllCandidatesByVacancyIdQueryHandler : IRequestHandler<GetAllCandidatesByVacancyIdQuery, IEnumerable<VacancyApplicationDTO>>
    {
        private readonly IVacancyApplicationRepository _vacancyApplicationRepository;
        private readonly IMapper _mapper;

        public GetAllCandidatesByVacancyIdQueryHandler(IVacancyApplicationRepository vacancyApplicationRepository, IMapper mapper)
        {
            _vacancyApplicationRepository = vacancyApplicationRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VacancyApplicationDTO>> Handle(GetAllCandidatesByVacancyIdQuery request, CancellationToken cancellationToken)
        {
            var vacancyApplication = await _vacancyApplicationRepository.GetAllCandidatesByVacancyId(request.Id);
            return _mapper.Map<IEnumerable<VacancyApplicationDTO>>(vacancyApplication);
        }
    }
}
