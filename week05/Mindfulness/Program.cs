// EXCEEDING REQUIREMENTS:
// I added a feature to keep a log of how many times each activity was performed during the session.
// and also displays them at the end of the activity to make the user know how many times he performed
// each on of them.

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        
        string choice = "";
        
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                
                BreathingActivity breathingActivity = new BreathingActivity(name, 0, description);
                breathingActivity.Run();
                
                breathingLog++;
            }
            else if (choice == "2")
            {
                string name = "Reflection Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                
                List<string> reflectionPrompts = new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };

                List<string> reflectionQuestions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };

                ReflectingActivity reflectingActivity = new ReflectingActivity(name, 0, description, reflectionQuestions, reflectionPrompts);
                reflectingActivity.Run();
                
                reflectingLog++;
            }
            else if (choice == "3")
            {
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                
                List<string> listingPrompts = new List<string>
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };

                ListingActivity listingActivity = new ListingActivity(name, 0, description, listingPrompts);
                listingActivity.Run();
                
                listingLog++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("Great job today! Here is your session summary:");
                Console.WriteLine($" - Breathing Activity: {breathingLog} times");
                Console.WriteLine($" - Reflection Activity: {reflectingLog} times");
                Console.WriteLine($" - Listing Activity: {listingLog} times");
                Console.WriteLine("");
                Console.WriteLine("Goodbye!");
                Thread.Sleep(4000);
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                Thread.Sleep(1500);
            }
        }
    }
}