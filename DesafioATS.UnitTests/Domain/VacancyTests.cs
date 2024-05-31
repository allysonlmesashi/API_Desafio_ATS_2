using DesafioATS.Domain.Entities;
using Xunit;

namespace DesafioATS.UnitTests.Domain
{
    public class VacancyTests
    {
        [Fact]
        public void Vacancy_Create_With_Valid_Description_And_Salary_Should_Be_Valid()
        {
            // Arrange
            string description = "Vaga Teste";
            decimal salary = 1000.99M;

            // Act
            Vacancy vacancy = new Vacancy(description, salary);

            //Assert
            Assert.True(vacancy.Valid);
            Assert.Equal(description, vacancy.Description);
        }

        [Fact]
        public void Vacancy_Create_Without_Description_Or_Salary_Should_Be_Invalid()
        {
            // Arrange
            string description = "";
            decimal salary = 0;

            // Act
            Vacancy vacancy = new Vacancy(description, salary);

            //Assert
            Assert.False(vacancy.Valid);
        }

        [Fact]
        public void Vacancy_Create_With_Invalid_Salary_Should_Be_Invalid()
        {
            // Arrange
            string description = "Vaga Teste";
            decimal salary = -10.00M;

            // Act
            Vacancy vacancy = new Vacancy(description, salary);

            //Assert
            Assert.False(vacancy.Valid);
        }
    }
}
