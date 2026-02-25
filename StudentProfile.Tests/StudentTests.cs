using Shouldly;
using StudentProfile.Core.Command;
using StudentProfile.Core.Entities;
using StudentProfile.Core.ValueObjects;

namespace StudentProfile.Tests
{
    public class StudentTests
    {
        private const string UrlValid = "https://instagram.com/";
        private const string EmailValid = "henrysantos@gmail.com";
        private const string ErrorMessage = "URL Invalid";

        [Fact]
        public void ShouldReturnSucessWhenUrlValid()
        {
            //Arrange
            var url = new Url(UrlValid);
            var email = new Email(EmailValid);

            //Act
            var student = new Student(url, email);

            //Assert
            var result = student.CreateUrl(url.Address, email.Value);
            result.IsSucess.ShouldBeTrue();
        }

        [Fact]
        public void ShouldReturnMessageTheErrorWhenUrlInvalid()
        {
            //Arrange
            var url = new Url(UrlValid);
            var email = new Email(EmailValid);

            //Act
            var student = new Student(url, email);

            //Assert
            var result = student.CreateUrl("https://google.com", "saulo@gmail.com");
            result.IsFailure.ShouldBeFalse();
            result.ErrorMessage.ShouldBe(ErrorMessage);
        }
    }
}
