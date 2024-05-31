using AutoMapper;
using CandidateResumeEntity = DesafioATS.Domain.Entities.CandidateResume;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.RepositoriesContracts;
using MediatR;

namespace DesafioATS.Application.Commands.CandidateResume
{
    public class CreateCandidateResumeCommandHandler : IRequestHandler<CreateCandidateResumeCommand, CandidateResumeDTO>
    {
        private readonly ICandidateResumeRepository _candidateResumeRepository;
        private readonly IMapper _mapper;

        public CreateCandidateResumeCommandHandler(ICandidateResumeRepository candidateResumeRepository, IMapper mapper)
        {
            _candidateResumeRepository = candidateResumeRepository;
            _mapper = mapper;
        }

        public async Task<CandidateResumeDTO> Handle(CreateCandidateResumeCommand request, CancellationToken cancellationToken)
        {
            var candidateResume = _mapper.Map<CandidateResumeEntity>(request.CandidateResumeDTO);
            await _candidateResumeRepository.CreateAsync(candidateResume);
            return _mapper.Map<CandidateResumeDTO>(candidateResume);
        }
    }
}
