// I added to the program a new atribute in the entry class it askes the user what's his mood today and stores it

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal helper = new Journal();
        PromptGenerator connect = new PromptGenerator();
        
        connect._prompts = new List<string>(){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        
        Console.WriteLine("Hello World! This is the Journal Project.");
        
        int number = 0;

        while(number != 5){ 
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            number = int.Parse(Console.ReadLine()); 

            if (number == 1){
                string question = connect.GetRandomPrompt();
                Console.WriteLine(question);
                Console.Write("> ");
                
                Entry jojo = new Entry(); 
                jojo._date = DateTime.Now.ToShortDateString();
                jojo._entryText = Console.ReadLine(); 
                jojo._promptText = question;
              
                Console.WriteLine("What is your current mood?");
                Console.Write("> ");
                jojo._mood = Console.ReadLine();
              
                helper.AddEntry(jojo); 
            }
            else if(number == 2){ 
                helper.Display();
            }
            else if(number == 3){
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                helper.Load(filename);
            }
            else if(number == 4){
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                helper.Save(filename);
            }
            else if(number == 5){
                Console.WriteLine("Bye!");
            }
            else{
                Console.WriteLine("Invalid option!! please type a valid numbre");
            }
        }
    }
}