using DesafioATS.Domain.Validations;
using MongoDB.Bson.Serialization.Attributes;

namespace DesafioATS.Domain.Entities
{
    public class Vacancy : Entity
    {
        [BsonDefaultValue(null)]
        public string Description { get; set; }

        [BsonDefaultValue(null)]
        public decimal Salary { get; set; }

        public Vacancy(string description, decimal salary)
        {
            this.Description = description;
            this.Salary = salary;
            Validate();
        }

        public void Validate()
        {
            Validate(this, new VacancyValidator());
        }
    }
}
