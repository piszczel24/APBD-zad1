namespace APBDzad1;

internal abstract class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello, World!");

        for (var i = 0; i < 10; i++) Console.Write($"{i} ");

        int[] arr = { 1, 2, 3, 4, 5 };
        foreach (var number in arr) Console.WriteLine($"{number * 2} ");
    }
}