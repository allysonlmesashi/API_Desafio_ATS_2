using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Commands.Candidate
{
    public class CreateCandidateCommand : IRequest<CandidateDTO>
    {
        public CandidateDTO CandidateDTO { get; private set; }

        public CreateCandidateCommand(CandidateDTO candidateDTO)
        {
            CandidateDTO = candidateDTO;
        }
    }
}
