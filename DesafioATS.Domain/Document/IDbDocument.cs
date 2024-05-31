namespace DesafioATS.Domain.Document
{
    public interface IDbDocument<TDocumentKey>
    {
        TDocumentKey Id { get; }
        DateTime DateCreated { get; }
        DateTime DateUpdated { get; }
        bool Active { get; }
    }

    public interface IDbDocument : IDbDocument<Guid> { }
}
