namespace APBDzad1;

internal abstract class Program
{
    private static void Main()
    {
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        Console.WriteLine(Average(array));
        Console.WriteLine(Max(array));
    }

    private static float Average(IReadOnlyCollection<int> numbers)
    {
        return (float)numbers.Sum() / numbers.Count;
    }

    private static float Max(IReadOnlyList<int> numbers)
    {
        var maxNumber = numbers[0];
        for (var i = 1; i < numbers.Count; i++)
            if (numbers[i] > maxNumber)
                maxNumber = numbers[i];

        return maxNumber;
    }
}