public class LoadGoals : Menu
{
// attributes

// constructors
    public LoadGoals( string instructions, List<string> options, string prompt) : base(instructions, options, prompt)
    {
        base.SetInstructions(instructions);
        base.SetOptions(options);
        base.SetPrompt(prompt);  
    }

// getters and setters

// behaviors

   public override void GetUserInput(List <Goal> goalList){

      string filename = Console.ReadLine();

      string[] goals = System.IO.File.ReadAllLines(filename);
      int length = goals.Length;

      int index = 0;
      foreach (string goal in goals)
      {
         if (index == 0){
            base.AddScore(int.Parse(goal));
         } else {
            string goalType = base.GetGoalType(goal);
         string[] goalArr = base.GetGoalInfo(goal);
         if (goalType == "SimpleGoal"){
            SimpleGoal simpleGoal = new SimpleGoal(goalArr[0], goalArr[1], goalArr[2], goalArr[3]);
         base.AddGoal(simpleGoal);
         }else if(goalType == "EternalGoal"){
            EternalGoal eternalGoal = new EternalGoal(goalArr[0], goalArr[1], goalArr[2]);
         base.AddGoal(eternalGoal);
         }else{
            ChecklistGoal checklistGoal = new ChecklistGoal(goalArr[0], goalArr[1], goalArr[2], goalArr[3], goalArr[4], goalArr[5]);
         base.AddGoal(checklistGoal);
         }
        }
        index++;
      }
   }
}