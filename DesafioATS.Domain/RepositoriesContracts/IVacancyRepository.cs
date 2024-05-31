using DesafioATS.Domain.Entities;

namespace DesafioATS.Domain.RepositoriesContracts
{
    public interface IVacancyRepository : IRepository<Vacancy>
    {
        Task<Vacancy> GetVacancyById(Guid id);
        Task<IEnumerable<Vacancy>> GetAllVacanciesAsync();
    }
}
