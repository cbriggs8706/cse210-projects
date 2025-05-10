using System;

//Exceeding Requirements: Added the ability to memorize the reference along with the text.  Added a library of other random scriptures.
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine("Scripture Memorizer\n");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Goodbye!");
    }
}
