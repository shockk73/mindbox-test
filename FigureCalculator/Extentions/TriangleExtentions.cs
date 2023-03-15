namespace FigureCalculator.Extentions
{
    public static class TriangleExtentions
    {
        /// <summary>
        /// Determines whether the triangle is right angled using the Pythagorean theorem.
        /// </summary>
        /// <returns>True if the triangle is right angled, otherwise false.</returns>
        public static bool CalculateIsRightAngle(this Triangle triangle)
        {
            var a2 = triangle.SideA * triangle.SideA;
            var b2 = triangle.SideB * triangle.SideB;
            var c2 = triangle.SideC * triangle.SideC;

            return a2 + b2 == c2 || b2 + c2 == a2 || c2 + a2 == b2;
        }
    }
}
