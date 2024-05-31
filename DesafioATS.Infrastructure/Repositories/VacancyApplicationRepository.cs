using DesafioATS.Domain.Entities;
using DesafioATS.Domain.RepositoriesContracts;
using DesafioATS.Infrastructure.Data;
using MongoDB.Driver;

namespace DesafioATS.Infrastructure.Repositories
{
    public class VacancyApplicationRepository : IVacancyApplicationRepository
    {
        private readonly IMongoCollection<VacancyApplication> _vacancyApplications;
        public VacancyApplicationRepository(MongoDbContext context)
        {
            _vacancyApplications = context.GetCollection<VacancyApplication>("VacancyApplications");
        }

        public async Task<IEnumerable<VacancyApplication>> GetAllCandidatesByVacancyId(Guid id)
        {
            return await _vacancyApplications.Find(vA => vA.VacancyId == id && vA.Active).ToListAsync();
        }

        public async Task CreateAsync(VacancyApplication vacancyApplication)
        {
            await _vacancyApplications.InsertOneAsync(vacancyApplication);
        }

        public async Task UpdateAsync(Guid id, VacancyApplication vacancyApplication)
        {
            throw new NotImplementedException("Não é possível atualizar aplicação a uma vaga.");
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException("Não é possível excluir aplicação a uma vaga.");
        }
    }
}
