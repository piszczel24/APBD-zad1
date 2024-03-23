namespace APBDzad1;

internal abstract class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello, World!");

        for (var i = 0; i < 10; i++) Console.Write($"{i} ");

        Console.WriteLine();

        foreach (var number in new[] { 1, 2, 3, 4, 5 })
            Console.Write($"{number * 2} ");
    }
}