namespace FigureCalculator
{
    /// <summary>
    /// Represents a circle with a given radius.
    /// </summary>
    public sealed record Circle(double Radius) : Figure
    {
        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
