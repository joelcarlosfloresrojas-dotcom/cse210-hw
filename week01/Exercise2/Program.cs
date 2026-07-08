using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string help = Console.ReadLine();
        int grade = int.Parse(help);
        string word = "";
        if (grade >= 90)
        {
            word = "A";
        }
        else if (grade >= 80)
        {
            word = "B";
        }
        else if (grade >= 70)
        {
            word = "C";
        }
        else if (grade >= 60)
        {
            word = "D";
        }
        else
        {
            word = "F";
        }

        Console.WriteLine($"Your grade is: {word}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course.");
        }

    }
}