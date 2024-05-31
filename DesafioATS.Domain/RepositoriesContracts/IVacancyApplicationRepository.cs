using DesafioATS.Domain.Entities;

namespace DesafioATS.Domain.RepositoriesContracts
{
    public interface IVacancyApplicationRepository : IRepository<VacancyApplication>
    {
        Task<IEnumerable<VacancyApplication>> GetAllCandidatesByVacancyId(Guid id);
    }
}
