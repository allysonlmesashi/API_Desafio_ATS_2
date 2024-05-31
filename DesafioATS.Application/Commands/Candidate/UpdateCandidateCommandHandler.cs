using AutoMapper;
using CandidateEntity = DesafioATS.Domain.Entities.Candidate;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Commands.Candidate
{
    public class UpdateCandidateCommandHandler : IRequestHandler<UpdateCandidateCommand, CandidateDTO>
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IMapper _mapper;

        public UpdateCandidateCommandHandler(ICandidateRepository candidateRepository, IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }

        public async Task<CandidateDTO> Handle(UpdateCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidate = _mapper.Map<CandidateEntity>(request.CandidateDTO);
            await _candidateRepository.UpdateAsync(request.Id, candidate);
            return _mapper.Map<CandidateDTO>(candidate);
        }
    }
}
