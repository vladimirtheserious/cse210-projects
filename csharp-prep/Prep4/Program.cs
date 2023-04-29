using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int lastNumber = 0;
        int numbers = -1;

        List<int> num = new List<int>();

        while (lastNumber != numbers)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            numbers = int.Parse(Console.ReadLine());
            num.Add(numbers);
        }
        int res = num.AsQueryable().Sum();
        Console.WriteLine($"The sum is: {res}");
        double average = num.Average();
        Console.WriteLine($"The average is: {average}");
        int maxValue = num.Max();
        Console.WriteLine($"The largest number: {maxValue}");

    }
}