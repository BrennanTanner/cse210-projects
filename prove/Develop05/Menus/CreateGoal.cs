public class CreateGoal : Menu
{
// attributes

// constructors
    public CreateGoal( string instructions, List<string> options, string prompt) : base(instructions, options, prompt)
    {
        base.SetInstructions(instructions);
        base.SetOptions(options);
        base.SetPrompt(prompt);  
    }

// getters and setters

// behaviors

    public void NewSimpleGoal(){
        Console.Write("What is the name of the goal? ");
        string goalTitle = Console.ReadLine();
        Console.Write("what is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("what is the ammount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();

        SimpleGoal simpleGoal = new SimpleGoal(goalTitle, goalDescription, goalPoints, "False");
        base.AddGoal(simpleGoal);
    }
    public void NewEternalGoal(){
        Console.Write("What is the name of the goal? ");
        string goalTitle = Console.ReadLine();
        Console.Write("what is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("what is the ammount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();

        EternalGoal eternalGoal = new EternalGoal(goalTitle, goalDescription, goalPoints);
        base.AddGoal(eternalGoal);
    }
    public void NewChecklistGoal(){
        Console.Write("What is the name of the goal? ");
        string goalTitle = Console.ReadLine();
        Console.Write("what is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("what is the ammount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string goalChecks = Console.ReadLine();
        Console.Write("what is the bonus for accomplishing it that many times? ");
        string goalBonus = Console.ReadLine();

        ChecklistGoal checklistGoal = new ChecklistGoal(goalTitle, goalDescription, goalPoints, goalBonus, goalChecks, "0");
        base.AddGoal(checklistGoal);
    }

   public override void GetUserInput(List <Goal> goals){

            switch(Console.ReadLine()) 
                {
                case "1":
                    NewSimpleGoal();
                    
                    break;
                case "2":
                    NewEternalGoal();
                    
                    break;
                case "3":
                    NewChecklistGoal();
                    
                    break;
                default:
                Console.Write("That is not a valid response, try again: ");
                    break;
        }
        return;

   }

}