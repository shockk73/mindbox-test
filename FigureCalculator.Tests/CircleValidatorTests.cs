using FigureCalculator.Validators;
using FluentAssertions;
using FluentValidation;

namespace FigureCalculator.Tests
{
    public class CircleValidatorTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public void Validate_ShouldBeValidResult_WhenValidRadius(double radius)
        {
            // Arrange
            var circle = new Circle(radius);
            var validator = new CircleValidator();

            // Act
            var result = validator.Validate(circle);

            // Assert
            result.IsValid.Should().BeTrue();
        }

        [Theory]
        [InlineData(-100)]
        [InlineData(double.MinValue)]
        [InlineData(0)]
        public void Validate_ShouldThrowException_WhenInvalidRadius(double radius)
        {
            // Arrange
            var circle = new Circle(radius);
            var validator = new CircleValidator();

            // Act & Assert
            Assert.Throws<ValidationException>(() => validator.ValidateAndThrow(circle));
        }
    }
}
