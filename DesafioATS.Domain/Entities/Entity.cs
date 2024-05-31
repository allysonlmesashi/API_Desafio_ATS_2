using DesafioATS.Domain.Document;
using FluentValidation;
using FluentValidation.Results;
using MongoDB.Bson.Serialization.Attributes;

namespace DesafioATS.Domain.Entities
{
    public abstract class Entity : IDbDocument
    {
        private Guid _id;

        [BsonDefaultValue(null)]
        public Guid Id
        {
            get => _id;
            protected set
            {
                _id = value == default ? Guid.NewGuid() : value;
            }
        }
        private DateTime _dateCreated { get; set; }
        private DateTime _dateUpdated { get; set; }

        [BsonDefaultValue(null)]
        public bool Active { get; private set; } = true;

        [BsonDefaultValue(null)]
        public DateTime DateCreated
        {
            get => _dateCreated;
            protected set
            {
                _dateCreated = value == default ? DateTime.Now : value;
            }
        }

        [BsonDefaultValue(null)]
        public DateTime DateUpdated
        {
            get => _dateUpdated;
            protected set
            {
                _dateUpdated = value == default ? DateTime.Now : value;
            }
        }

        [BsonIgnore]
        public bool Valid { get; private set; }

        [BsonIgnore]
        public bool Invalid => !Valid;

        [BsonIgnore]
        public ValidationResult ValidationResult { get; private set; }

        protected Entity(Guid id)
        {
            Id = id;
        }

        protected Entity() : this(default)
        {
            this.SetCreateDate();
        }

        public void SetUpdateDate()
        {
            _dateUpdated = DateTime.Now;
        }

        public void SetCreateDate()
        {
            _dateCreated = DateTime.Now;
            _dateUpdated = DateTime.Now;
        }

        public void Delete()
        {
            Active = false;
        }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);
            return Valid = ValidationResult.IsValid;
        }
    }
}
