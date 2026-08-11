using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running runningActivity = new Running(30, 4.8);   
        Cycling cyclingActivity = new Cycling(49, 23.0);  
        Swimming swimmingActivity = new Swimming(22, 45);

        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);
        foreach (Activity help in activities)
        {
            Console.WriteLine(help.GetSummary());
        }
    }
}