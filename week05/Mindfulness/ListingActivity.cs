public class ListingActivity : Activity
{
    List<string> _prompts= new List<string>();
    private int _count;
    public ListingActivity(string name,int duration,string description,List<string> prompt) : base(name, duration, description)
    {
        _count=0;
        _prompts=prompt;
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(5);
        _count=GetListFromUser().Count;
        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} items");
        DisplayEndingMessage();
    }


    public void GetRandomPrompt()
    {

        Random randomer = new Random();
        int a = randomer.Next(0,_prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt");
        Console.WriteLine(_prompts[a]);
    }

    public List<string> GetListFromUser(){
        DateTime time1=DateTime.Now;
        DateTime extra1=time1.AddSeconds(GetDuration());
        List<string> helper= new List<string>();
        while(DateTime.Now<extra1){
        Console.Write("-");
        string response =Console.ReadLine();
            helper.Add(response);
        }

        return  helper;
    }

}