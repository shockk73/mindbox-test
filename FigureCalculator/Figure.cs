namespace FigureCalculator
{
    /// <summary>
    /// Represents a two-dimensional geometric figure.
    /// </summary>
    public abstract record Figure
    {
        /// <summary>
        /// Calculates the area of the figure.
        /// </summary>
        public abstract double CalculateArea();
    }
}