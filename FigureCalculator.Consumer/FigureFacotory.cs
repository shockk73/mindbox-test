using FigureCalculator.Validators;
using FluentValidation;

namespace FigureCalculator.Consumer
{
    public interface IFigureFactory
    {
        Figure CreateCircle(double radius);
        Figure CreateTriangle(double sideA, double sideB, double sideC);
    }

    public class FigureFactory : IFigureFactory
    {
        public Figure CreateCircle(double radius)
        {
            var circle = new Circle(radius);
            var validator = new CircleValidator();
            validator.ValidateAndThrow(circle);
            return circle;
        }

        public Figure CreateTriangle(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var validator = new TriangleValidator();
            validator.ValidateAndThrow(triangle);
            return triangle;
        }
    }
}
