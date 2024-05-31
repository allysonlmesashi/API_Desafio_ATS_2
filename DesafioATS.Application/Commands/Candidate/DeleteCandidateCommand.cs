using MediatR;

namespace DesafioATS.Application.Commands.Candidate
{
    public class DeleteCandidateCommand : IRequest<bool>
    {
        public Guid Id { get; }

        public DeleteCandidateCommand(Guid id)
        {
            Id = id;
        }
    }
}
