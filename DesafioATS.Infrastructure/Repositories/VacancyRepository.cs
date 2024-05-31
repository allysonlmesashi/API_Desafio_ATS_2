using DesafioATS.Domain.Entities;
using DesafioATS.Domain.RepositoriesContracts;
using DesafioATS.Infrastructure.Data;
using MongoDB.Driver;

namespace DesafioATS.Infrastructure.Repositories
{
    public class VacancyRepository : IVacancyRepository
    {
        private readonly IMongoCollection<Vacancy> _vacancies;

        public VacancyRepository(MongoDbContext context)
        {
            _vacancies = context.GetCollection<Vacancy>("Vacancies");
        }

        public async Task<Vacancy> GetVacancyById(Guid id)
        {
            return await _vacancies.Find(v => v.Id == id && v.Active).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Vacancy>> GetAllVacanciesAsync()
        {
            return await _vacancies.Find(c => c.Active).ToListAsync();
        }

        public async Task CreateAsync(Vacancy vacancy)
        {
            await _vacancies.InsertOneAsync(vacancy);
        }

        public async Task UpdateAsync(Guid id, Vacancy vacancy)
        {
            var filter = Builders<Vacancy>.Filter.Eq(v => v.Id, id);
            var update = Builders<Vacancy>.Update
                .Set(v => v.Description, vacancy.Description)
                .Set(v => v.Salary, vacancy.Salary)
                .Set(v => v.DateUpdated, DateTime.Now);

            await _vacancies.UpdateOneAsync(filter, update);
        }

        public async Task DeleteAsync(Guid id)
        {
            var filter = Builders<Vacancy>.Filter.Eq(v => v.Id, id);
            var update = Builders<Vacancy>.Update.Set(v => v.Active, false);

            await _vacancies.UpdateOneAsync(filter, update);
        }
    }
}
