public class RecordEvent : Menu
{
// attributes
 private int _goalIndex;

// constructors
    public RecordEvent( string instructions, List<string> options, string prompt) : base(instructions, options, prompt)
    {
        base.SetInstructions(instructions);
        base.SetOptions(options);
        base.SetPrompt(prompt); 
    }

// getters and setters
   public int GetGoalIndex()
   {
      return _goalIndex;
   }
   public void SetGoalIndex(int goalIndex)
    {
        _goalIndex = goalIndex;
    }

// behaviors

   public override void DisplayGoals(List <Goal> goals){

      List<string> options = new List<string>();
      List<string> goalStrings = new List<string>();
        foreach (Goal goal in goals)
        {
         goalStrings.Add(base.GoalToString(goal));
        }
         foreach (string goal in goalStrings)
        {
         string[] goalInfo = GetGoalInfo(goal);
            options.Add(goalInfo[1]);
        }
         base.SetOptions(options);
      }
         

   
   public override void GetUserInput(List <Goal> goals){
      
     string input = Console.ReadLine(); 

      SetGoalIndex(int.Parse(input)-1);
      base.AddScore(goals[int.Parse(input)-1].RecordEvent());

      base.AddGoal(goals[int.Parse(input)-1]);

   }

}