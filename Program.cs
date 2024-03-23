namespace APBDzad1;

internal abstract class Program
{
    private static void Main()
    {
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        Console.WriteLine(Average(array));
    }

    private static float Average(IReadOnlyCollection<int> numbers)
    {
        return (float)numbers.Sum() / numbers.Count;
    }
}