using System.Xml.Linq;

namespace CreateAClass;

class Bot
{
    public string name { get; set; }
    public string version { get; set; }

    //Constructor
    public Bot(string name, string version)
    {
        this.name = name;
        this.version = version;
    }

    //Virtual method
    public virtual void introduce()
    {
        Console.WriteLine($"Hello, I'm {name}, version {version}.");
    }
}

class ChatBot : Bot
{
    public string language { get; set; }
    public string creator { get; set; }

    //Constructor
    public ChatBot(string name, string version, string language, string creator)
        : base(name, version)
    {
        this.language = language;
        this.creator = creator;
    }

    // Indexer
    public string this[int index]
    {
        get
        {
            if (index == 0)
                return language;
            else if (index == 1)
                return creator;
            else
                throw new IndexOutOfRangeException();
        }
        set
        {
            if (index == 0)
                language = value;
            else if (index == 1)
                creator = value;
            else
                throw new IndexOutOfRangeException();
        }
    }

    public override void introduce()
    {
        Console.WriteLine($"Hello, I'm {name}, version {version}. I communicate in {language} and was created by {creator}.");
    }
}

static class BotExtensions
{
    public static void PerformAction(this Bot bot, string action)
    {
        Console.WriteLine($"{bot.name} is performing action: {action}");
    }
}

class WeatherBot : Bot
{
    public double temp { get; }
    public double high { get; }
    public double low { get; }

    //Constructor
    public WeatherBot(string name, string version, double temp, double high, double low) : base(name, version)
    {
        this.temp = temp;
        this.high = high;
        this.low = low;
    }

    public override void introduce()
    {
        Console.WriteLine($"Hello, I'm {name}, version {version}. The temperature today is {temp} " +
            $"Farenheits with higer of {high} Farenheits and lower of {low} Farenheits.");
    }
}

public class BotTest
{
    static void Main(string[] args)
    {
        ChatBot chatBot = new ChatBot("ChatBot", "1.0", "English", "Creator1");
        chatBot.introduce();
        WeatherBot weatherBot = new WeatherBot("WeatherBot", "1.0", 72.5, 80.2, 65.7);
        Bot customBot = new Bot("CustomBot", "1.0");

        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Interact with ChatBot");
            Console.WriteLine("2. Interact with WeatherBot");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    chatBot.introduce();
                    chatBot.PerformAction("Chatting"); // Using extension method
                    break;
                case "2":
                    weatherBot.introduce();
                    weatherBot.PerformAction("Getting weather updates"); // Using extension method
                    break;
                case "3":
                    exitProgram = true;
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
