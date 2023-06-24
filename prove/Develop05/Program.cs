using System;
using System.Collections.Generic;
class Program
{
    static int score = 0;
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        LoadGoals();

        while (true)
        {
            Console.WriteLine("==== Goal Tracker ====");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    ShowGoals();
                    break;
                case 4:
                    ShowScore();
                    break;
                case 5:
                    SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("==== Create New Goal ====");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type: ");

        int type = int.Parse(Console.ReadLine());
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal value: ");
        int value = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                goals.Add(new SimpleGoal(name, value));
                break;
            case 2:
                goals.Add(new EternalGoal(name, value));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus value: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, value, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal created successfully!");
    }
    static void ShowGoals()
    {
        Console.WriteLine("==== Goals ====");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.Name} {goal.GetStatus()}");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("==== Record Event ====");
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        Console.Write("Enter goal number: ");

        int goalNumber = int.Parse(Console.ReadLine());
        if (goalNumber >= 1 && goalNumber <= goals.Count)
        {
            Goal goal = goals[goalNumber - 1];
            goal.Complete();
            score += goal.Value;

            Console.WriteLine($"Event recorded for goal '{goal.Name}'. You earned {goal.Value} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    

    static void ShowScore()
    {
        Console.WriteLine($"Current Score: {score} points");
    }

    static void SaveGoals()
    {
    }

    static void LoadGoals()
    {
        goals.Add(new SimpleGoal("Run a Marathon", 1000));
        goals.Add(new EternalGoal("Read Scriptures", 100));
        goals.Add(new ChecklistGoal("Attend Temple", 50, 10, 500));
    }

}