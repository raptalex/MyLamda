class Program
{
    public static void Main()
    {
        Func<double, double, double> add = (a, b) => a + b;
        Func<double, double, double> mult = (a, b) => a * b;
        Func<double, double, double> min = (a, b) => a < b ? a : b;

        Console.Write("Enter first number: ");
        double.TryParse(Console.ReadLine(), out double val1);

        Console.Write("Enter second number: ");
        double.TryParse(Console.ReadLine(), out double val2);

        Console.WriteLine("ADD({0}, {1}) = {2}, MULT({0}, {1}) = {3}, MIN({0}, {1}) = {4}", val1, val2, add(val1, val2), mult(val1, val2), min(val1, val2));
    }
}