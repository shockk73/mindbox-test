using FluentValidation;

namespace FigureCalculator.Validators
{
    /// <summary>
    /// Validator for the <see cref="Circle"/> class.
    /// </summary>
    public sealed class CircleValidator : AbstractValidator<Circle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CircleValidator"/> class and defines the validation rules.
        /// </summary>
        public CircleValidator()
        {
            RuleFor(circle => circle.Radius).GreaterThan(0);
        }
    }
}
