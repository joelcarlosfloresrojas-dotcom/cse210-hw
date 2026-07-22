using System;

class Program
{
    static void Main(string[] args)
    {

        hold one = new hold();
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        hold two = new hold(5);
        Console.WriteLine(two.GetFractionString());
        Console.WriteLine(two.GetDecimalValue());
        hold three = new hold(6,7);
        Console.WriteLine(three.GetFractionString());
        Console.WriteLine(three.GetDecimalValue());
        
    }
}