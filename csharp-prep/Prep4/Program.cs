using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   int num = -1;
        int count = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (num != 0)
        {
        Console.WriteLine("Enter number:");
        string enter = Console.ReadLine();
        num = int.Parse(enter);
        List <int> numbers = new List<int>();
        numbers.Add(num);
        if (num == 0)
        {
            int res = numbers.Sum();
            Console.WriteLine(res);
        }
        }


    

        
    }
}