using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference one = new Reference("1 Nephi", 9, 6);
        string scrip1 = "But the Lord knoweth all things from the beginning; wherefore, he prepareth a way to accomplish all his works among the children of men; for behold, he hath all power unto the fulfilling of all his words. And thus it is. Amen";
        
        Reference two = new Reference("Mosiah", 3, 8);
        string scrip2 = "And he shall be called Jesus Christ, the Son of God, the Father of heaven and earth, the Creator of all things from the beginning; and his mother shall be called Mary";

        Reference three = new Reference("Proverbs", 3, 5, 6);
        string scrip3 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Reference four = new Reference("John", 3, 16);
        string scrip4 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference five = new Reference("Moroni", 10, 4);
        string scrip5 = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.";

        List<Reference> ole = new List<Reference>(); 
        ole.Add(one);
        ole.Add(two);
        ole.Add(three);
        ole.Add(four);
        ole.Add(five);

        List<string> _theword = new List<string>() { scrip1, scrip2, scrip3, scrip4, scrip5 }; 

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("\nPlease choose a scripture to memorize:");

        for (int go = 0; go < ole.Count; go++) 
        {
            Console.WriteLine((go + 1) + ". " + ole[go].GetDisplayText());
        }

        Console.Write("\nEnter number (1-5): ");
        string op1 = Console.ReadLine(); 
        int enumber = 0; 
        
        try 
        {
            enumber = int.Parse(op1) - 1;
            if (enumber < 0 || enumber > 4) 
            {
                enumber = 0; 
            }
        }
        catch 
        {
            enumber = 0; 
        }

        Scripture ture1 = new Scripture(ole[enumber], _theword[enumber]); 
        string ref1 = ""; 

        Console.Clear();
        Console.WriteLine(ture1.GetDisplayText());

        while (ture1.IsCompletelyHidden() == false)
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            ref1 = Console.ReadLine();

            if (ref1 == "quit")
            {
                break;
            }
            ture1.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(ture1.GetDisplayText());
        }
        Console.WriteLine("\nYou have finished! Thank you for using ScriptureMemorizer.");
    }
}