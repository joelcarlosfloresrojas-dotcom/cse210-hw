using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals =new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score=0;
    }

public void Start()
    {
        string menu = "";

       
        while (menu != "6")
        {
            Console.WriteLine();
            DisplayPlayerInfo(); 
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            menu = Console.ReadLine();

            if (menu == "1")
            {
                CreateGoal();
            }
            else if (menu == "2")
            {
                ListGoalDetails();
            }
            else if (menu == "3")
            {
                SaveGoals();
            }
            else if (menu == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
            }
            else if (menu == "5")
            {
                RecordEvent();
            }
            else if (menu == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
        if (_score >= 1000) Console.WriteLine("Level: Master Achiever");
        else if (_score >= 500) Console.WriteLine("Level: Goal Setter");
        else Console.WriteLine("Level: Beginner");
    }

    public void ListGoalsNames()
    {
        for(int i = 0; i <_goals.Count;i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");    
        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());               
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
          if (type == 1) {
                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
               
            }
            else if (type == 2 ) {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
               
            }
            else if (type == 3) {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
                
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
    }

    public void RecordEvent()
    {
        ListGoalsNames();
        Console.WriteLine("Which goal did you accomplish? ");
        string numberG=Console.ReadLine();
        int numberG1=int.Parse(numberG);
        _score=_score+_goals[numberG1-1].RecordEvent();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();

        
        using (StreamWriter File = new StreamWriter(fileName))
        {
           
            File.WriteLine(_score);
        

        foreach (Goal goal in _goals)
        {
           
            File.WriteLine(goal.GetStringRepresentation());
        }
    
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string filename)
    {
        string[] loader= File.ReadAllLines(filename);
        _score=int.Parse(loader[0]);
        _goals.Clear();
        for(int i = 1; i < loader.Length; i++)
        {
           string[] helper=loader[i].Split(":");
           string kindof=helper[0];
           string content=helper[1];
           string[] realize=content.Split(",");
           int points1=int.Parse(realize[2]);
            if (kindof == "Simple Goal")
            {
                
                SimpleGoal goal = new SimpleGoal(realize[0], realize[1],points1);
                bool isComplete = bool.Parse(realize[3]);
                goal.SetIsComplete(isComplete);
                _goals.Add(goal);
            }
            else if(kindof=="Eternal Goal")
            {
                EternalGoal goal = new EternalGoal(realize[0], realize[1],points1);
                _goals.Add(goal);
            }
            else if(kindof=="Check List Goal")
            {
                int bonus=int.Parse(realize[3]);
                int target=int.Parse(realize[4]);
                int times=int.Parse(realize[5]);
                ChecklistGoal goal = new ChecklistGoal(realize[0], realize[1],points1,target,bonus);

                goal.SetAmount(times);
                _goals.Add(goal);
            }


            
        }

    }
}