public class BreathingActivity:Activity
{
    public BreathingActivity(string name,int duration,string description):base(name,duration,description)
    {
       
    }
    public void Run(){
        DisplayStartingMessage();
         DateTime time1=DateTime.Now;
        DateTime extra1=time1.AddSeconds(GetDuration());
         while(DateTime.Now<extra1){
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine(" ");
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine(" ");
         }
        DisplayEndingMessage();
    }
    
}
