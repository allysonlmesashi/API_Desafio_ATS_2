using DesafioATS.Domain.Entities;
using Xunit;

namespace DesafioATS.UnitTests.Domain
{
    public class VacancyApplicationTests
    {
        [Fact]
        public void VacancyApplication_Create_With_Valid_CandidateId_And_VacancyId_Should_Be_Valid()
        {
            // Arrange
            Guid candidateId = Guid.NewGuid();
            Guid vacancyId = Guid.NewGuid();

            // Act
            VacancyApplication vacancyApplication = new VacancyApplication(candidateId, vacancyId);

            //Assert
            Assert.True(vacancyApplication.Valid);
            Assert.Equal(candidateId, vacancyApplication.CandidateId);
            Assert.Equal(vacancyId, vacancyApplication.VacancyId);
        }

        [Fact]
        public void VacancyApplication_Create_Without_CandidateId_Or_VacancyId_Should_Be_Invalid()
        {
            // Arrange
            Guid candidateId = Guid.Empty;
            Guid vacancyId = Guid.Empty;

            // Act
            VacancyApplication vacancyApplication = new VacancyApplication(candidateId, vacancyId);

            //Assert
            Assert.False(vacancyApplication.Valid);
        }

        [Fact]
        public void VacancyApplication_Create_With_Invalid_VacancyId_Should_Be_Invalid()
        {
            // Arrange
            Guid candidateId = Guid.NewGuid();
            Guid vacancyId = Guid.Empty;

            // Act
            VacancyApplication vacancyApplication = new VacancyApplication(candidateId, vacancyId);

            //Assert
            Assert.False(vacancyApplication.Valid);
        }
    }
}
