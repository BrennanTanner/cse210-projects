public class BreathingActivity : Activity
{

    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
      base.SetActivityName(activityName);
      base.SetActivityDescription(activityDescription);

    }

   public void Breathe()
   {
      Console.Write("Breathe in through nose...");
      base.Pause(4);
      Console.Write("\n");
      Console.Write("Breathe out through mouth...");
      base.Pause(6);
      Console.Write("\n");
   }
}