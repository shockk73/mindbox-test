using FigureCalculator.Extentions;
using FluentAssertions;

namespace FigureCalculator.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(5, 5, 5, 10.8)]
        public void CalculateArea_ShouldReturnCorrectArea_WhenValidSides(double sideA, double sideB, double sideC, double expectedArea)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            area.Should().BeApproximately(expectedArea, 2);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(7, 24, 25)]
        public void CalculateIsRightAngle_ShouldReturnTrue_WhenRightAngled(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var isRectangular = triangle.CalculateIsRightAngle();

            // Assert
            isRectangular.Should().BeTrue();
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 5)]
        [InlineData(5, 6, 7)]
        public void CalculateIsRightAngle_ShouldReturnFalse_WhenNotRightAngled(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var isRectangular = triangle.CalculateIsRightAngle();

            // Assert
            isRectangular.Should().BeFalse();
        }
    }
}