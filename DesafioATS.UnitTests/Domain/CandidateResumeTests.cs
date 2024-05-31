using DesafioATS.Domain.Entities;
using DesafioATS.Domain.Enums;
using DesafioATS.Domain.ValueObjects;
using Xunit;

namespace DesafioATS.UnitTests.Domain
{
    public class CandidateResumeTests
    {
        [Fact]
        public void CandidateResume_With_Valid_CandidateId_Gender_Address_Should_Be_Valid()
        {
            //Arrange
            Guid candidateId = Guid.NewGuid();
            Gender gender = Gender.Female;
            string address = "Av. Braz Leme, nº 1000";
            List<Education> education = new List<Education>();
            List<WorkExperience> workExperience = new List<WorkExperience>();
            List<Hobby> hobby = new List<Hobby>();

            //Act
            CandidateResume candidateResume = new CandidateResume(candidateId, gender, address, education, workExperience, hobby);

            //Assert
            Assert.True(candidateResume.Valid);
            Assert.Equal(gender, candidateResume.Gender);
            Assert.Equal(address, candidateResume.Address);
        }

        [Fact]
        public void CandidateResume_With_Valid_CandidateId_Gender_Address_And_Education_WorkExperience_HobbyShould_Be_Valid()
        {
            //Arrange
            Guid candidateId = Guid.NewGuid();
            Gender gender = Gender.Female;
            string address = "Av. Braz Leme, nº 1000";
            List<Education> education = new List<Education>() { new Education("Engenharia de Software", new DateTime(2009, 2, 1), new DateTime(2012, 12, 1), "FATEC") };
            List<WorkExperience> workExperience = new List<WorkExperience>() { new WorkExperience( "Analista de Sistemas", new DateTime(2013, 2, 1), null, "Totvs") };
            List<Hobby> hobby = new List<Hobby>() { new Hobby("Assistir TV"), new Hobby("Jogar futebol") };

            //Act
            CandidateResume candidateResume = new CandidateResume(candidateId, gender, address, education, workExperience, hobby);

            //Assert
            Assert.True(candidateResume.Valid);
            Assert.Contains(education, e => e.Description == "Engenharia de Software");
            Assert.Contains(workExperience, wE => wE.Description == "Analista de Sistemas");
            Assert.Contains(hobby, h => h.Description == "Assistir TV");
        }

        [Fact]
        public void CandidateResume_Without_CandidateId_Should_Be_Invalid()
        {
            //Arrange
            Guid candidateId = Guid.Empty;
            Gender gender = Gender.Female;
            string address = "";
            List<Education> education = new List<Education>();
            List<WorkExperience> workExperience = new List<WorkExperience>();
            List<Hobby> hobby = new List<Hobby>();

            //Act
            CandidateResume candidateResume = new CandidateResume(candidateId, gender, address, education, workExperience, hobby);

            //Assert
            Assert.False(candidateResume.Valid);
        }
    }
}
