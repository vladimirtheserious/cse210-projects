using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();

        int squareNumber = SquareNumber(userNum);
        DisplayResult(userName, squareNumber);


    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string enter = Console.ReadLine();
            return enter;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int enter = int.Parse(Console.ReadLine());
            return enter;
        }
        static int SquareNumber(int number)
        {
            number = number * 2;
            return number;
        }
        static void DisplayResult(string name, int square)
        {
            Console.Write($"{name}, the square of your number is {square}");
        }

}