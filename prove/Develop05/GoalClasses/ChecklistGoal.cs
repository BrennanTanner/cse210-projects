public class ChecklistGoal : Goal
{
// attributes

// constructors
    public ChecklistGoal(string goalTitle, string goalDescription, string goalPoints, string bonus, string checksToBonus, string checksSoFar) : base(goalTitle, goalDescription, goalPoints)
    {
        SetGoalInfo(goalTitle, goalDescription, goalPoints, "", bonus, checksToBonus, checksSoFar);
    }

// getters and setters
  
      public override void SetGoalInfo(string goalTitle, string goalDescription, string goalPoints, string isCompleted, string bonus, string checksToBonus, string checksSoFar)
    {
        base.ClearGoalItems();
        base.AddGoalItem("ChecklistGoal");
        base.AddGoalItem(goalTitle);
        base.AddGoalItem(goalDescription);
        base.AddGoalItem(goalPoints);
        base.AddGoalItem(bonus);
        base.AddGoalItem(checksToBonus);
        base.AddGoalItem(checksSoFar);
    }

// behaviors

 public override int RecordEvent(){
        if (base.GetGoalInfo()[6] == base.GetGoalInfo()[5]){
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }else if(int.Parse(base.GetGoalInfo()[6]) - 1 == int.Parse(base.GetGoalInfo()[5])){
            IsComplete();
            return(int.Parse(base.GetGoalInfo()[4]));
            
        }else{
            IsComplete();
             return (int.Parse(base.GetGoalInfo()[3]));
              
        }
   }
   public override void IsComplete(){
       List<string> oldGoal = base.GetGoalInfo();
       oldGoal[6] = $"{int.Parse(oldGoal[6])+1}";
        SetGoalInfo(oldGoal[1], oldGoal[2], oldGoal[3], "", oldGoal[4], oldGoal[5], oldGoal[6]);
    }
}