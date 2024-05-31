using DesafioATS.Domain.Entities;
using DesafioATS.Domain.RepositoriesContracts;
using DesafioATS.Infrastructure.Data;
using MongoDB.Driver;

namespace DesafioATS.Infrastructure.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly IMongoCollection<Candidate> _candidates;

        public CandidateRepository(MongoDbContext context)
        {
            _candidates = context.GetCollection<Candidate>("Candidates");
        }

        public async Task<Candidate> GetCandidateById(Guid id)
        {
            return await _candidates.Find(c => c.Id == id && c.Active).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Candidate>> GetAllCandidatesAsync()
        {
            return await _candidates.Find(c => c.Active).ToListAsync();
        }

        public async Task CreateAsync(Candidate candidate)
        {
            await _candidates.InsertOneAsync(candidate);
        }

        public async Task UpdateAsync(Guid id, Candidate candidate)
        {
            var filter = Builders<Candidate>.Filter.Eq(c => c.Id, id);
            var update = Builders<Candidate>.Update
                .Set(c => c.Name, candidate.Name)
                .Set(c => c.Email, candidate.Email)
                .Set(c => c.DateUpdated, DateTime.Now);

            await _candidates.UpdateOneAsync(filter, update);
        }

        public async Task DeleteAsync(Guid id)
        {
            var filter = Builders<Candidate>.Filter.Eq(c => c.Id, id);
            var update = Builders<Candidate>.Update.Set(c => c.Active, false);

            await _candidates.UpdateOneAsync(filter, update);
        }

    }
}
