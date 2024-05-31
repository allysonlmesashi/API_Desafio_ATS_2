using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Commands.Candidate
{
    public class UpdateCandidateCommand : IRequest<CandidateDTO>
    {
        public CandidateDTO CandidateDTO { get; private set; }

        public Guid Id { get; }

        public UpdateCandidateCommand(Guid id, CandidateDTO candidateDTO)
        {
            Id = id;
            CandidateDTO = candidateDTO;
        }
    }
}
