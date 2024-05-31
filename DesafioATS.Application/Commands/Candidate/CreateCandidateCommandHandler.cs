using AutoMapper;
using CandidateEntity = DesafioATS.Domain.Entities.Candidate;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Commands.Candidate
{
    public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommand, CandidateDTO>
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMapper _mapper;

        public CreateCandidateCommandHandler(ICandidateRepository candidateRepository, IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        public async Task<CandidateDTO> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidate = _mapper.Map<CandidateEntity>(request.CandidateDTO);
            await _candidateRepository.CreateAsync(candidate);
            return _mapper.Map<CandidateDTO>(candidate);
        }
    }
}
