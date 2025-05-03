using System;
using System.Security.Principal;
using System.Threading.Tasks.Dataflow;

// To exceed requirements I added the functionality of saving and loading from JSON as well as many other prompts
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load (text)");
            Console.WriteLine("4. Save (text)");
            Console.WriteLine("5. Load (JSON)");
            Console.WriteLine("6. Save (JSON)");
            Console.WriteLine("7. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
        {
            case "1":
                journal.WriteEntry();
                break;
            case "2":
                journal.DisplayEntries();
                break;
            case "3":
                Console.Write("Enter filename to load (text): ");
                journal.LoadFromFile(Console.ReadLine());
                break;
            case "4":
                Console.Write("Enter filename to save (text): ");
                journal.SaveToFile(Console.ReadLine());
                break;
            case "5":
                Console.Write("Enter filename to load (JSON): ");
                journal.LoadFromJsonFile(Console.ReadLine());
                break;
            case "6":
                Console.Write("Enter filename to save (JSON): ");
                journal.SaveToJsonFile(Console.ReadLine());
                break;

            case "7":
                running = false;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
        }

        Console.WriteLine("Goodbye!");
    }
}
