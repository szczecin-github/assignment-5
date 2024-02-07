using System;
using System.IO;

class Program
{
    static void Main()
    {
        Journal();
    }
    static void Text()
    {
        Console.WriteLine("Captain's Journal");
        Console.WriteLine("Type 'start' to begin and 'stop' to end.");
    }

    static void Journal()
    {
        Text();
        string userInput;
        bool writing = false;
        var notes = new System.Text.StringBuilder();
        while ((userInput = Console.ReadLine()) != null)
        {
            if (userInput.ToLower() == "start")
            {
                writing = true;
                notes.Clear();
                continue;
            }
            if (userInput.ToLower() == "stop")
            {
                break;
            }
            if (writing)
            {
                notes.AppendLine(userInput);
            }
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string filename = $"{currentDate}.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Captain’s Journal");
                writer.WriteLine($"Stardate {currentDate}");
                writer.WriteLine(notes.ToString() + "Jean-Luc Picard");
            }
            Console.WriteLine($"Journal saved to {filename}");
        }
    }
}
//boop