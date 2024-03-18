// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

public static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.", nameof(numbers));
    
    double total = 0;
    foreach (int num in numbers)
    {
        total += num;
    }
    return total / numbers.Length;
}

public static int FindMaximum(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.", nameof(numbers));
    
    int max = numbers[0];
    foreach (int num in numbers)
    {
        if (num > max)
            max = num;
    }
    return max;
}

