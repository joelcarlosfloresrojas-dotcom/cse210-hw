using System;
using System.Collections.Generic;
using System.IO;

// --- CLASES ---

public class Entry 
{    
    public string _date;    
    public string _promptText;    
    public string _entryText;

    public void Display() 
    {        
        Console.WriteLine($"Date: {_date}");        
        Console.WriteLine(_promptText);        
        Console.WriteLine(_entryText);        
        Console.WriteLine();    
    }
}

public class PromptGenerator 
{    
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt() 
    {        
        Random random = new Random();        
        int prompt = random.Next(0, _prompts.Count);        
        return _prompts[prompt];    
    }
}

public class Journal 
{    
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) 
    {        
        _entries.Add(newEntry);    
    }

    public void DisplayAll() 
    {        
        Console.WriteLine("\nJournal Entries:\n");        
        foreach (Entry entry in _entries) 
        {            
            entry.Display();        
        }    
    }

    public void SaveToFile(string file) 
    {        
        Console.WriteLine("Saving Entries...");        
        using (StreamWriter outfile = new StreamWriter(file)) 
        {            
            foreach (Entry entry in _entries) 
            {                
                outfile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");            
            }        
        }        
        Console.WriteLine("Entries Saved.");    
    }

    public void LoadFromFile(string file) 
    {        
        Console.WriteLine("Loading Entries...");        
        string[] lines = System.IO.File.ReadAllLines(file);        
        _entries.Clear(); 
        foreach (string line in lines) 
        {            
            string[] parts = line.Split(",");
            if (parts.Length >= 3)
            {
                Entry newEntry = new Entry();            
                newEntry._date = parts[0];            
                newEntry._promptText = parts[1];            
                newEntry._entryText = parts[2];
                _entries.Add(newEntry);
            }
        }        
        Console.WriteLine("Entries loaded successfully.");    
    }
}

// --- CLASE PRINCIPAL ---

class Program
{    
    static void Main(string[] args)    
    {        
        Console.WriteLine("Welcome to Ryan's Journal Program!");        
        PromptGenerator prompts = new PromptGenerator();        
        Journal journal = new Journal();

        prompts._prompts = new List<string> {            
            "What are you grateful for?",            
            "What did you learn today?",            
            "What was something nice that you did for someone or someone did for you?",            
            "What inspired you today?",            
            "What is something you worked on or accomplished today?"
        };

        bool running = true;
        while (running)        
        {            
            Console.WriteLine("\nSelect one of the following options:");
            Console.WriteLine("1: New Entry | 2: Display All | 3: Save | 4: Load | 5: Quit");
            
            string choiceStr = Console.ReadLine();
            
            if (int.TryParse(choiceStr, out int choice))
            {
                switch (choice)            
                {                
                    case 1:                    
                        Entry entry = new Entry();
                        entry._date = DateTime.Now.ToShortDateString();
                        entry._promptText = prompts.GetRandomPrompt();
                        Console.WriteLine(entry._promptText);
                        Console.Write("> ");
                        entry._entryText = Console.ReadLine();
                        journal.AddEntry(entry);
                        break;
                    case 2:                    
                        journal.DisplayAll();
                        break;
                    case 3:                    
                        Console.Write("Filename to save: ");
                        journal.SaveToFile(Console.ReadLine());
                        break;
                    case 4:                    
                        Console.Write("Filename to load: ");
                        journal.LoadFromFile(Console.ReadLine());
                        break;
                    case 5:                    
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }    
    }
}