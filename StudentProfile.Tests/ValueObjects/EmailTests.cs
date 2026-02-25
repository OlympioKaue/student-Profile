using Shouldly;
using StudentProfile.Core.ValueObjects;

namespace StudentProfile.Tests.ValueObjects
{
    public class EmailTests
    {
        private const string DefaultEmail = "Invalid email";
        private const string ValidEmail = "rogerflit@gmail.com";
        private const string UserSplit = "rogerflit";
        private const string InvalidEmail = "roger.flit.com";
        private const string InvalidLenghtEmail = "r@gmail.com";

        [Fact]
        public void ShouldReturnSucessWhenEmailIsValid()
        {
            // Arrange
            var email = new Email(ValidEmail);

            // Act
            var result = email.Create();

            // Assert
            result.IsSucess.ShouldBeTrue();
            result.ErrorMessage.ShouldBeNull();
        }

        [Theory]
        [InlineData(InvalidEmail)]
        [InlineData(InvalidLenghtEmail)]
        public void ShouldReturnFailureWhenEmailIsInvalid(string value)
        {
            // Arrange
            var email = new Email(value);

            // Act
            var result = email.Create();

            // Assert
            result.IsFailure.ShouldBeFalse();
            result.ErrorMessage.ShouldBe(DefaultEmail);
        }

        [Fact]
        public void ShouldReturnFirstNameWhenEmail()
        {
            //Arrange
            var email = new Email(ValidEmail);

            //Act
            var result = email.User;

            //Assert
            result.ShouldBe(UserSplit);
        }
    }
}
