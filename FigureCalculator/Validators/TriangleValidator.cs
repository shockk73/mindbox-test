using FluentValidation;

namespace FigureCalculator.Validators
{
    /// <summary>
    /// Validator for the <see cref="Triangle"/> class.
    /// </summary>
    public sealed class TriangleValidator : AbstractValidator<Triangle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleValidator"/> class and defines the validation rules.
        /// </summary>
        public TriangleValidator()
        {
            RuleFor(triangle => triangle.SideA).GreaterThan(0);
            RuleFor(triangle => triangle.SideB).GreaterThan(0);
            RuleFor(triangle => triangle.SideC).GreaterThan(0);
            RuleFor(triangle => triangle).Must(BeValidTriangle).WithMessage("A triangle with such sides cannot exist");
        }

        private static bool BeValidTriangle(Triangle triangle)
        {
            return triangle.SideA + triangle.SideB > triangle.SideC
                && triangle.SideA + triangle.SideC > triangle.SideB
                && triangle.SideB + triangle.SideC > triangle.SideA;
        }
    }
}
