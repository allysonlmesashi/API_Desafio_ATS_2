namespace DesafioATS.Domain.ValueObjects
{
    public class WorkExperience : ValueObject
    {
        public string Company { get; set; }

        public WorkExperience(string description, DateTime startDate, DateTime? endDate, string company)
        {
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Company = company;
        }
    }
}
