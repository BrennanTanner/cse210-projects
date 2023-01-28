public class ReflectionActivity : Activity
{
    private string _prompt;
    private string _reflection;

    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
      base.SetActivityName(activityName);
      base.SetActivityDescription(activityDescription);

      
    }

   public string GetPrompt()
   {
      return _prompt;
   }
   public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }
   public string GetReflection()
   {
      return _reflection;
   }
   public void SetReflection(string reflection)
    {
        _reflection = reflection;
    }
   public void DisplayPrompt()
   {
      string prompt = base.GetPromptFromFile("reflection_prompts.txt");
      Console.Write("\n");
      Console.WriteLine("Consider the following prompt:\n");
      Console.WriteLine($" --- {prompt} --- \n");
      Console.WriteLine("When you have something in mind, press enter to continue.");
      Console.ReadLine();
      Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
      Console.Write("You may begin in: ");
      base.Pause(5);
   }
   public void DisplayReflection(int activityTime)
   {
      string reflection = base.GetPromptFromFile("reflections.txt");
      Console.WriteLine($"\n --- {reflection} --- ");
      base.ShowSpinner(10);
      
   }
}