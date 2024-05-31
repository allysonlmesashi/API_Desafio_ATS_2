using DesafioATS.Domain.Document;

namespace DesafioATS.Domain.RepositoriesContracts
{
    public interface IRepository<TDocument> where TDocument : class, IDbDocument<Guid>
    {
        Task CreateAsync(TDocument entity);

        Task UpdateAsync(Guid id, TDocument entity);

        Task DeleteAsync(Guid id);
    }

}
