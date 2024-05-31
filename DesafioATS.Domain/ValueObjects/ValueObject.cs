using MongoDB.Bson.Serialization.Attributes;

namespace DesafioATS.Domain.ValueObjects
{
    public abstract class ValueObject
    {
        [BsonIgnoreIfNull]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? EndDate { get; set; }
    }
}
