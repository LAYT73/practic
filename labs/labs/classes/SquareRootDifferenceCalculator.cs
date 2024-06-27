namespace labs.classes;

public class SquareRootDifferenceCalculator : DifferenceCalculator
{
    public double CalculateSquareRootDifference(int a, int b)
    {
        int difference = base.CalculateDifference(a, b); // Вызов метода базового класса
        return Math.Sqrt(Math.Abs(difference)); // Вычисление квадратного корня из абсолютного значения разности
    }
}