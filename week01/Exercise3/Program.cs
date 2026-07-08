using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess; 

        do
        {
            Console.WriteLine("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput); 
       
            if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
            }
        } while (guess != magicNumber); 
        
    }
}