using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percantage?");
        string text = Console.ReadLine();
        int percantage = int.Parse(text);

        if (percantage >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (percantage >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (percantage >= 70)
        {
            Console.WriteLine("Your grade is D");
        }
        else if (percantage < 60)
        {
            Console.WriteLine("Your grade is F");
        }
    }
}