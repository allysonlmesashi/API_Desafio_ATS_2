namespace DesafioATS.Domain.ValueObjects
{
    public class Hobby 
    {
        public string Description { get; set; }

        public Hobby(string description)
        {
            Description = description;
        }
    }
}
