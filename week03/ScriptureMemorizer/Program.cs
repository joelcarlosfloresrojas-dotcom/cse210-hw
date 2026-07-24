using System;
using System.Collections.Generic;
using System.Linq;

/*i added an option to let the user decide what scripture he wants to memorize , like a little menu */

class Program
{
    static void Main(string[] args)
    {
        Reference one = new Reference("1 Nephi","9","6","0");
        string scrip1 = "But the Lord knoweth all things from the beginning; wherefore, he prepareth a way to accomplish all his works among the children of men; for behold, he hath all power unto the fulfilling of all his words. And thus it is. Amen";
        
        Reference two = new Reference("Mosiah","3","8");
        string scrip2 = "And he shall be called Jesus Christ, the Son of God, the Father of heaven and earth, the Creator of all things from the beginning; and his mother shall be called Mary";

        Reference three = new Reference("Proverbs", "3", "5", "6");
        string scrip3 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Reference four = new Reference("John", "3", "16");
        string scrip4 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference five = new Reference("Moroni", "10", "4");
        string scrip5 = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.";

        List<Reference> referenceLibrary = new List<Reference> { one, two, three, four, five };
        List<string> textLibrary = new List<string> { scrip1, scrip2, scrip3, scrip4, scrip5 };

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("\nPlease choose a scripture to memorize:");

        for (int i = 0; i < referenceLibrary.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {referenceLibrary[i].GetDisplayReference()}");
        }

        Console.Write("\nEnter number (1-5): ");
        string choice = Console.ReadLine();
        
        int selected = 0;
        if (int.TryParse(choice, out int result) && result >= 1 && result <= 5)
        {
            selected = result - 1;
        }

        Reference chosenReference = referenceLibrary[selected];
        string chosenText = textLibrary[selected];

        string helper1 = chosenReference.GetDisplayReference();
        Word word1 = new Word(chosenText, 3);
        string input = "";

        Console.Clear();
        Scripture initialScripture = new Scripture(word1.GetWords(), new List<int>());
        initialScripture.DisplayText(initialScripture.Getgivemeundercores(), helper1);

        while (!word1.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            Console.Clear();
            Scripture ture1 = new Scripture(word1.GetWords(), word1.GetRamdonChose());
            ture1.DisplayText(ture1.Getgivemeundercores(), helper1);
        }

        Console.WriteLine("\nYou have finished! Thank you for using ScriptureMemorizer.");
    }
}