public class SimpleGoal : Goal
{

// constructors

    public SimpleGoal(string goalTitle, string goalDescription, string goalPoints, string isCompleted) : base(goalTitle, goalDescription, goalPoints)
    {   
        SetGoalInfo(goalTitle, goalDescription, goalPoints, isCompleted, "", "", "");
    
    }

// getters and setters
      public override void SetGoalInfo(string goalTitle, string goalDescription, string goalPoints, string isCompleted, string bonus, string checksToBonus, string checksSoFar)
    {
        base.ClearGoalItems();
        base.AddGoalItem("SimpleGoal");
        base.AddGoalItem(goalTitle);
        base.AddGoalItem(goalDescription);
        base.AddGoalItem(goalPoints);
        base.AddGoalItem(isCompleted);
    }

// behaviors
        
   public override int RecordEvent(){
        if (base.GetGoalInfo()[4] == "True"){
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }else{
           
            IsComplete();
            return int.Parse(base.GetGoalInfo()[3]);
        }
        
   }
    public override void IsComplete(){
       List<string> oldGoal = base.GetGoalInfo();
        SetGoalInfo(oldGoal[1], oldGoal[2], oldGoal[3], "True", "", "", "");
    }

}