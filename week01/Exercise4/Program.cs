using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numb = new List<int>();
        int input = -1;

        while (input != 0)
        {
            Console.WriteLine("Enter a number or type 0 to exit: ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                numb.Add(input);
            }
        }

        if (numb.Count > 0)
        {
            int sum = 0;
            int higher = numb[0];

            for (int i = 0; i < numb.Count; i++)
            {
                sum += numb[i];
                if (numb[i] > higher)
                {
                    higher = numb[i];
                }
            }

            double average = (double)sum / numb.Count;

            Console.WriteLine($"The highest number entered is: {higher}");
            Console.WriteLine($"The sum of the numbers entered is: {sum}");
            Console.WriteLine("The average of the numbers entered is: " + average);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}