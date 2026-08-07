using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity
{
    List<string> _prompts= new List<string>();
    List<string> _questions= new List<string>();
    public ReflectingActivity(string name,int duration,string description,List<string> questions,List<string> prompts): base(name, duration, description)
    {
        _prompts=prompts;
        _questions=questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.ReadLine();
        Console.Write("You may begin in:");
        ShowCountDown(5);
        GetRandomQuestion();
        DisplayEndingMessage();

    }

     public void GetRandomPrompt()
    {
        Random randomer = new Random();
        int a = randomer.Next(0,_prompts.Count);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"---{_prompts[a]}---");
         Console.WriteLine("");
        Console.WriteLine("When you have something in mind press enter to continue");
    }
     public void GetRandomQuestion()
    {
        DateTime time1=DateTime.Now;
        DateTime extra1=time1.AddSeconds(GetDuration());
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        while(DateTime.Now<extra1){
        Random randomer = new Random();
        int a = randomer.Next(0,_questions.Count);
        Console.WriteLine(_questions[a]);
        ShowSpinner(8);

        }
    }
}