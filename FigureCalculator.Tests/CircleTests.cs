using FluentAssertions;

namespace FigureCalculator.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(5, 78.5398)]
        [InlineData(10, 314.1592)]
        public void CalculateArea_ShouldReturnCorrectArea_WhenValidRadius(double radius, double expectedArea)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var result = circle.CalculateArea();

            // Assert
            result.Should().BeApproximately(expectedArea, 0.0001);
        }
    }
}
