using System;

class Program
{
    static void Main(string[] args)
    {
        // string text;
        string guessText;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        
        // Console.WriteLine("What is the magic number");
        // text = Console.ReadLine();
        // int magicNumber = int.Parse(text);
        do 
        {
        Console.WriteLine("What is your guess?");
        guessText = Console.ReadLine();
        int guessNumber = int.Parse(guessText);

        {
        if (number > guessNumber)
        {
            Console.WriteLine("Higher");
            continue;
        }
        else if (number < guessNumber)
        {
            Console.WriteLine("Lower");
            continue;
        }
        else
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        }
        } while (number != int.Parse(guessText)); 
    }   
}
