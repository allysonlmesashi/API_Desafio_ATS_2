namespace DesafioATS.Domain.ValueObjects
{
    public class Education : ValueObject
    {
        public string Institution { get; set; }

        public Education(string description, DateTime startDate, DateTime? endDate, string institution) 
        { 
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Institution = institution;
        }
  }
}
