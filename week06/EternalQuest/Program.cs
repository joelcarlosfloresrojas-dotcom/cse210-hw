///I gave the player levels according to the amount
/// of points he has in three levels

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        
        manager.Start();
    }
}