using DesafioATS.Domain.Enums;
using DesafioATS.Domain.Validations;
using DesafioATS.Domain.ValueObjects;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DesafioATS.Domain.Entities
{
    public class CandidateResume : Entity
    {
        [BsonDefaultValue(null)]
        public Guid CandidateId { get; set; }
        [BsonRepresentation(BsonType.String)]
        public Gender Gender { get; set; }
        public string Address { get; set; }
        [BsonDefaultValue(null)]
        public List<Education>? Education { get; set; }
        [BsonDefaultValue(null)]
        public List<WorkExperience>? WorkExperience { get; set; }
        [BsonDefaultValue(null)]
        public List<Hobby>? Hobby { get; set; }

        public CandidateResume(Guid candidateId, Gender gender, string address, List<Education> education, List<WorkExperience> workExperience, List<Hobby> hobby)
        {
            this.CandidateId = candidateId;
            this.Gender = gender;
            this.Address = address;
            this.Education = education;
            this.WorkExperience = workExperience;
            this.Hobby = hobby;
            Validate();
        }

        public void Validate()
        {
            Validate(this, new CandidateResumeValidator());
        }
    }
}
