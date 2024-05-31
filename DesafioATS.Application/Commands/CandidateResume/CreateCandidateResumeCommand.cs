using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Commands.CandidateResume
{
    public class CreateCandidateResumeCommand : IRequest<CandidateResumeDTO>
    {
        public CandidateResumeDTO CandidateResumeDTO { get; private set; }

        public CreateCandidateResumeCommand(CandidateResumeDTO candidateResumeDTO)
        {
            CandidateResumeDTO = candidateResumeDTO;
        }
    }
}
