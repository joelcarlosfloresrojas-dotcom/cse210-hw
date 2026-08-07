public class Activity
{
    private string _name;
    private int _duration;
    private string _description;  

    public Activity(string name,int duration,string description)
    {
        _name=name;
        _description=description;
        _duration=duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(" ");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_duration} of the {_name}.");
        ShowSpinner(5);
        Console.Clear();
        
    }

    public void ShowCountDown(int seconds)
    {
        for(int i=seconds;i>0;i--){
        Console.Write(i);
        Thread.Sleep(1000);
        int digits=i.ToString().Length;
           for (int j = 0; j < digits; j++)
        {
            Console.Write("\b \b");
        }
        }
        Console.WriteLine("");

    }

    public void ShowSpinner(int seconds)
    {
        int k=0;
        DateTime time=DateTime.Now;
        DateTime extra=time.AddSeconds(seconds);
        List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
        while(DateTime.Now<extra){
            
            Console.Write(animationStrings[k]);
            Thread.Sleep(400);
           Console.Write("\b \b");
            k++;
            if (k == animationStrings.Count)
            {
                k=0;
            }
        
    }
    }

}