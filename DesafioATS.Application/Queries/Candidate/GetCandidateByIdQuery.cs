using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Queries.Candidate
{
    public class GetCandidateByIdQuery : IRequest<CandidateDTO>
    {
        public Guid Id { get; }

        public GetCandidateByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
