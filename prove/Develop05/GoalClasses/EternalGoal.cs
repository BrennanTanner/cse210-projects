public class EternalGoal : Goal
{
// attributes


// constructors
    public EternalGoal(string goalTitle, string goalDescription, string goalPoints) : base(goalTitle, goalDescription, goalPoints)
    {
        SetGoalInfo(goalTitle, goalDescription, goalPoints, "", "", "", "");
    }

// getters and setters


// behaviors

      public override void SetGoalInfo(string goalTitle, string goalDescription, string goalPoints, string isCompleted, string bonus, string checksToBonus, string checksSoFar)
    {
        base.ClearGoalItems();
        base.AddGoalItem("EternalGoal");
        base.AddGoalItem(goalTitle);
        base.AddGoalItem(goalDescription);
        base.AddGoalItem(goalPoints);
    }

    public override int RecordEvent(){
        return int.Parse(base.GetGoalInfo()[3]);
   }

}