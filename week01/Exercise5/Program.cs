using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, userNumber, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int n2 = number * number;
        return n2;
    }

    static void DisplayResult(string name, int favoriteNumber, int squaredNumber)
    {
        Console.WriteLine($"Hello, {name}! your square is {squaredNumber}.");
    }
}