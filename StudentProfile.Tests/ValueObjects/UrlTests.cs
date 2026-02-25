using Shouldly;
using StudentProfile.Core.ValueObjects;

namespace StudentProfile.Tests.ValueObjects
{
    public class UrlTests
    {
        private const string ValidUrl = "https://www.google.com";
        private const string InvalidUrl = "htp:/invalid-url";
        private const string DefaultUrl = "Invalid URL";

        [Fact]
        public void ShouldReturnSucessWhenUrlIsValid()
        {
            // Arrange
            var url = ValidUrl;

            //Act
            var result = new Url(url).Create();

            // Assert
            result.IsSucess.ShouldBeTrue();
            result.ErrorMessage.ShouldBeNull();
        }

        [Fact]
        public void ShouldReturnFailureWhenUrlIsInvalid()
        {
            // Arrange
            var url = InvalidUrl;

            //Act
            var result = new Url(url).Create();

            // Assert
            result.IsFailure.ShouldBeFalse();
            result.ErrorMessage.ShouldBe(DefaultUrl);
        }
    }
}
