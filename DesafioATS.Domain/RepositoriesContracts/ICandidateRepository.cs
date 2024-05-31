using DesafioATS.Domain.Entities;

namespace DesafioATS.Domain.RepositoriesContracts
{
    public interface ICandidateRepository : IRepository<Candidate>
    {
        Task<Candidate> GetCandidateById(Guid id);
        Task<IEnumerable<Candidate>> GetAllCandidatesAsync();
    }
}
