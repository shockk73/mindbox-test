using FigureCalculator;
using FigureCalculator.Consumer;

foreach (var figure in GetFigures(new FigureFactory()))
{
    Console.WriteLine($"{figure} Area is '{figure.CalculateArea()}'");
}

static IEnumerable<Figure> GetFigures(IFigureFactory factory)
{
    yield return factory.CreateCircle(1);
    yield return factory.CreateTriangle(3, 4, 5);
    yield return factory.CreateTriangle(1, 2, 3);
}