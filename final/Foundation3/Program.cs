namespace Program;
using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        
        while (choice != "4")
        {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Clear();        
        Console.WriteLine("Thank you for coming to the UNSC Lecture Series!");
        choice = Console.ReadLine();

        
        Lecture a1 = new Lecture("Master Chief 117", "State of the UNSC");
        Console.WriteLine(a1.GetSummary());

        
        ReceptionAssignment a2 = new ReceptionAssignment("RSVP", "Registration", "Email", "Flyer");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetReceptionList());

    
        GatheringAssignment a3 = new GatheringAssignment("Indoor Gathering", "Outdoor Gathering", "Weather", "Number of attendees.");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(value: a3.GetGatheringInformation());
        Console.WriteLine("Thank you for coming to the UNSC Lecture Series, we'll see you next year!");      
        choice = Console.ReadLine();
        }
    }
}

internal class GatheringAssignment
{
    private string v1;
    private string v2;
    private string v3;

    public GatheringAssignment(string v1, string v2, string v3, string v)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    internal bool GetGatheringInformation()
    {
        throw new NotImplementedException();
    }

    internal bool GetSummary()
    {
        throw new NotImplementedException();
    }
}

internal class ReceptionAssignment
{
    private string v1;
    private string v2;
    private string v3;
    private string v4;

    public ReceptionAssignment(string v1, string v2, string v3, string v4)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
    }

    internal bool GetReceptionList()
    {
        throw new NotImplementedException();
    }

    internal bool GetSummary()
    {
        throw new NotImplementedException();
    }
}

internal class Lecture
{
    private string v1;
    private string v2;

    public Lecture(string v1, string v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    internal bool GetSummary()
    {
        throw new NotImplementedException();
    }
}