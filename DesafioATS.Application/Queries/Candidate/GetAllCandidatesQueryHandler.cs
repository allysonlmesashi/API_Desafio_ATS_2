using AutoMapper;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Queries.Candidate
{
    public class GetAllCandidatesQueryHandler : IRequestHandler<GetAllCandidatesQuery, IEnumerable<CandidateDTO>>
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMapper _mapper;

        public GetAllCandidatesQueryHandler(ICandidateRepository candidateRepository, IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CandidateDTO>> Handle(GetAllCandidatesQuery request, CancellationToken cancellationToken)
        {
            var candidates = await _candidateRepository.GetAllCandidatesAsync();
            return _mapper.Map<IEnumerable<CandidateDTO>>(candidates);
        }
    }
}
