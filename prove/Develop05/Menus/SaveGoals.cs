public class SaveGoals : Menu
{
// attributes

// constructors
    public SaveGoals( string instructions, List<string> options, string prompt) : base(instructions, options, prompt)
    {
        base.SetInstructions(instructions);
        base.SetOptions(options);
        base.SetPrompt(prompt);  
    }

// getters and setters

// behaviors

   public override void GetUserInput(List <Goal> goalList){

      string filename = Console.ReadLine();
      List<string> goalStrings = new List<string>();
      int index = 0;
      foreach (var goal in goalList)
      {
         if (index == 0){
            goalStrings.Add($"{base.GetUserScore()}");
         }
         goalStrings.Add(base.GoalToString(goal));
         index++;
      }

      System.IO.File.WriteAllLines(filename, goalStrings);
   }

}