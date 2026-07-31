using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment math1= new MathAssignment("Joel","Fractions","Section 7.3","Problems 8-19");
        WritingAssignment write1=new WritingAssignment("Juan","European History","The Causes of World War II","by Marry Waters");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());


        
    }
}