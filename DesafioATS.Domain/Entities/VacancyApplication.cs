using DesafioATS.Domain.Validations;
using MongoDB.Bson.Serialization.Attributes;

namespace DesafioATS.Domain.Entities
{
    public class VacancyApplication : Entity
    {
        [BsonDefaultValue(null)]
        public Guid CandidateId { get; set; }
        [BsonDefaultValue(null)]
        public Guid VacancyId { get; set; }

        public VacancyApplication(Guid candidateID, Guid vacancyID)
        {
            this.CandidateId = candidateID;
            this.VacancyId = vacancyID;
            Validate();
        }

        public void Validate()
        {
            Validate(this, new VacancyApplicationValidator());
        }
    }
}
