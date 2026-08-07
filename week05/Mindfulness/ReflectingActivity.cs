using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, int duration, string description, List<string> questions, List<string> prompts) : base(name, duration, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    
    public string GetRandomPrompt()
    {
        Random randomer = new Random();
        int a = randomer.Next(0, _prompts.Count);
        return _prompts[a];
    }

    
    public string GetRandomQuestion()
    {
        Random randomer = new Random();
        int a = randomer.Next(0, _questions.Count);
        return _questions[a];
    }

   
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind press enter to continue");
        Console.ReadLine();
        Console.Write("You may begin in:");
        ShowCountDown(5);
    }

    
    public void DisplayQuestions()
    {
        DateTime time1 = DateTime.Now;
        DateTime extra1 = time1.AddSeconds(GetDuration());
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        
        while (DateTime.Now < extra1)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(8);
        }
    }
}