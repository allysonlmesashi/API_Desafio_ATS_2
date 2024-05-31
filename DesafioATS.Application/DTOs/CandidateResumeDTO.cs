using DesafioATS.Domain.Enums;
using DesafioATS.Domain.ValueObjects;

namespace DesafioATS.Application.DTOs
{
    public class CandidateResumeDTO
    {
        public Guid Id { get; set; }
        public Guid CandidateId { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public List<Education>? Education { get; set; }
        public List<WorkExperience>? WorkExperience { get; set; }
        public List<Hobby>? Hobby { get; set; }
    }
}
