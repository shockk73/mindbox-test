namespace FigureCalculator
{
    /// <summary>
    /// Represents a triangle with three given sides.
    /// </summary>
    public sealed record Triangle(double SideA, double SideB, double SideC) : Figure
    {
        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public override double CalculateArea()
        {
            var hp = CalculatePerimeter() / 2;

            // Heron's formula
            return Math.Sqrt(hp * (hp - SideA) * (hp - SideB) * (hp - SideC));
        }
        private double CalculatePerimeter() => SideA + SideB + SideC;
    }
}
