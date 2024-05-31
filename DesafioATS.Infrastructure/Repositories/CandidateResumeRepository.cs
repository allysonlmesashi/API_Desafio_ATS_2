using DesafioATS.Domain.Entities;
using DesafioATS.Domain.RepositoriesContracts;
using DesafioATS.Infrastructure.Data;
using MongoDB.Driver;

namespace DesafioATS.Infrastructure.Repositories
{
    public class CandidateResumeRepository : ICandidateResumeRepository
    {
        private readonly IMongoCollection<CandidateResume> _candidateResumes;
        public CandidateResumeRepository(MongoDbContext context)
        {
            _candidateResumes = context.GetCollection<CandidateResume>("CandidateResumes");
        }

        public async Task CreateAsync(CandidateResume candidateResume)
        {
            await _candidateResumes.InsertOneAsync(candidateResume);
        }

        public async Task UpdateAsync(Guid id, CandidateResume candidateResume)
        {
            throw new NotImplementedException("Não é possível atualizar o currículo do candidato.");
        }

        public async Task DeleteAsync(Guid candidateId)
        {
            throw new NotImplementedException("Não é possível excluir ao currículo do candidato.");
        }
    }
}
