using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choices = "";
        do
        {
            Console.WriteLine("Hello Develop02 World!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            choices = Console.ReadLine();

            if(choices == "1")
            {
                journal.WriteEntry();
            }
            else if(choices == "2")
            {
                journal.DisplayEntries();
            }
            else if(choices == "3")
            {
                journal.LoadEntries();
            }
            else if(choices == "4")
            {
                journal.SaveEntries();
            }
        } while (choices != "5");
    }
}

class Journal
{
    private Entry[] entries;
    private PromptGenerator promptGenerator;
    private QuoteGenerator quoteGenerator;

    public Journal()
    {
        promptGenerator = new PromptGenerator();
        quoteGenerator = new QuoteGenerator();
        entries = new Entry[0];
    }

    public void WriteEntry()
    {
        Console.WriteLine("Here's your prompt for today:");
        string prompt = promptGenerator.GeneratePrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("What's on your mind today?");
        string answer = Console.ReadLine();

        Console.WriteLine("How are you feeling right now?");
        string mood = Console.ReadLine();

        DateTime currentDate = DateTime.Now;
        Entry newEntry = new Entry(prompt, answer, mood, currentDate);
        Array.Resize(ref entries, entries.Length + 1);
        entries[entries.Length - 1] = newEntry;

        Console.WriteLine("Here's a quote to inspire you:");
        string quote = quoteGenerator.GenerateQuote();
        Console.WriteLine(quote);
    }

    public void DisplayEntries()
    {
        if (entries.Length == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        Console.WriteLine("Your entries so far:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void LoadEntries()
    {
        // load entries from file
    }

    public void SaveEntries()
    {
        // save entries to file
    }
}

class Entry
{
    private string prompt;
    private string answer;
    private string mood;
    private DateTime dateTime;

    public Entry(string prompt, string answer, string mood, DateTime dateTime)
    {
        this.prompt = prompt;
        this.answer = answer;
        this.mood = mood;
        this.dateTime = dateTime;
    }

    public override string ToString()
    {
        return $"Date: {dateTime.ToString()} - Prompt: {prompt} - Answer: {answer} - Mood: {mood}";
    }
}

class PromptGenerator
{
    private string[] prompts = {"What are three things that you're grateful for today?",
                                "Describe a recent challenge you faced and how you overcame it.",
                                "Write about a moment that made you feel proud of yourself.",
                                "What's something that you've been procrastinating on, and what steps can you take to start working on it?",
                                "Write about a recent accomplishment that you're proud of."};
    private Random random;

    public PromptGenerator()
    {
        random = new Random();
    }

    public string GeneratePrompt()
    {
        int randomNumber = random.Next(0, prompts.Length);
        return prompts[randomNumber];
    }
}

class QuoteGenerator
{
    private string[] quotes = {
        "Believe you can and you're halfway there. -Theodore Roosevelt",
        "You miss 100% of the shots you don't take. -Wayne Gretzky",
        "It does not matter how slowly you go as long as you do not stop. -Confucius",
        "Success is not final, failure is not fatal: it is the courage to continue that counts. -Winston Churchill",
        "The only way to do great work is to love what you do. -Steve Jobs"
    };

    public string GetRandomQuote()
    {
        Random random = new Random();
        int index = random.Next(0, quotes.Length);
        return quotes[index];
    }

    public void DisplayRandomQuote()
    {
        string quote = GetRandomQuote();
        Console.WriteLine("Quote of the day:");
        Console.WriteLine(quote);
    }
}

