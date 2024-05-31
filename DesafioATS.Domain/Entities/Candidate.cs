using DesafioATS.Domain.Validations;
using MongoDB.Bson.Serialization.Attributes;

namespace DesafioATS.Domain.Entities
{
    public class Candidate : Entity
    {

        [BsonDefaultValue(null)]
        public string Name { get; set; }

        [BsonDefaultValue(null)]
        public string Email { get; set; }

        public Candidate(string name, string email)
        {
            this.Name = name;
            this.Email = email;
            Validate();
        }

        public void Validate()
        {
            Validate(this, new CandidateValidator());
        }

    }
}
