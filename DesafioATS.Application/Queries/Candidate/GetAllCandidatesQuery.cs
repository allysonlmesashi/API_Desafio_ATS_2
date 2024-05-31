using DesafioATS.Application.DTOs;
using MediatR;

namespace DesafioATS.Application.Queries.Candidate
{
    public class GetAllCandidatesQuery : IRequest<IEnumerable<CandidateDTO>>
    {
    }
}
