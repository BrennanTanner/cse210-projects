using System;

class Program
{
    static void Main(string[] args)
    {
        Menu home = new Menu("Menu Options:", new List<string>
        {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"}, "Select a Choice from the menu: ");
      bool quit = false;
        while (quit == false)
        {
            Console.WriteLine($"\nYou have {home.GetUserScore()} points.\n");
            home.DisplayMenu();

            switch(Console.ReadLine()) 
                {
                case "1": 
                    CreateGoal newGoal = new CreateGoal("The types of Goals are:", new List<string>{"Simple Goal", "Eternal Goal", "Checklist Goal"}, "Which type of goal would you like to create? ");
                    newGoal.DisplayMenu();
                    newGoal.GetUserInput(home.GetGoals());
                    home.AddGoal(newGoal.GetGoals()[0]);
                    break;
                case "2":
                    ListGoals listGoals = new ListGoals("The goals are:", new List<string>{},"");
                    listGoals.DisplayMenu();
                    listGoals.DisplayGoals(home.GetGoals());
                    break;
                case "3":
                    SaveGoals saveGoals = new SaveGoals("", new List<string>{},"What is the filename for the goal file? ");
                    saveGoals.DisplayMenu();
                    saveGoals.GetUserInput(home.GetGoals());
                    break;
                case "4":
                    LoadGoals loadGoals = new LoadGoals("", new List<string>{},"What is the filename for the goal file? ");
                    loadGoals.DisplayMenu();
                    loadGoals.GetUserInput(home.GetGoals());
                    home.AddScore(loadGoals.GetUserScore());
                    foreach (Goal goal in loadGoals.GetGoals())
                    {
                        home.AddGoal(goal);
                    }
                    break;
                case "5":
                RecordEvent recordEvent = new RecordEvent("The goals are:", new List<string>{},"Which goal did you accomplish? ");

                    recordEvent.DisplayGoals(home.GetGoals());
                    recordEvent.DisplayMenu();
                    recordEvent.GetUserInput(home.GetGoals());
                    home.UpdateGoal(recordEvent.GetGoals()[0], recordEvent.GetGoalIndex());
                    home.AddScore(recordEvent.GetUserScore());
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                Console.Write("That is not a valid response, try again: ");
                    break;

            }
        }
    }
}