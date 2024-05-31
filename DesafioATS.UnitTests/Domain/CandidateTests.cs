using DesafioATS.Domain.Entities;
using Xunit;

namespace DesafioATS.UnitTests.Domain
{
    public class CandidateTests
    {
        [Fact]
        public void Candidate_Create_With_Valid_Name_And_Email_Should_Be_Valid()
        {
            // Arrange
            string name = "Candidato Teste";
            string email = "email@totvs.com.br";

            // Act
            Candidate candidate = new Candidate(name, email);

            //Assert
            Assert.True(candidate.Valid);
            Assert.Equal(name, candidate.Name);
        }
        
        [Fact]
        public void Candidate_Create_Without_Name_Or_Email_Should_Be_Invalid()
        {
            // Arrange
            string name = "";
            string email = "";

            // Act
            Candidate candidate = new Candidate(name, email);

            //Assert
            Assert.False(candidate.Valid);
        }

        [Fact]
        public void Candidate_Create_With_Invalid_Email_Should_Be_Invalid()
        {
            // Arrange
            string name = "Candidato Teste";
            string email = "teste";

            // Act
            Candidate candidate = new Candidate(name, email);

            //Assert
            Assert.False(candidate.Valid);
        }
    }
}