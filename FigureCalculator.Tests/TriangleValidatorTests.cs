using FigureCalculator.Validators;
using FluentAssertions;
using FluentValidation;

namespace FigureCalculator.Tests
{
    public class TriangleValidatorTests
    {
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(7, 9, 12)]
        [InlineData(5, 5, 5)]
        public void Validate_ShouldBeValidResult_WhenValidSides(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);
            var validator = new TriangleValidator();

            // Act
            var result = validator.Validate(triangle);

            // Assert
            result.IsValid.Should().BeTrue();
        }

        [Theory]
        [InlineData(0, 7, 8)]
        [InlineData(-3, 4, 5)]
        [InlineData(4, 8, 16)]
        public void Validate_ShouldThrowException_WhenInvalidSides(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);
            var validator = new TriangleValidator();

            // Act & Assert
            Assert.Throws<ValidationException>(() => validator.ValidateAndThrow(triangle));
        }
    }
}
