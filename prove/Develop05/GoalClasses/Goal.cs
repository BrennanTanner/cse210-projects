public class Goal
{
// attributes
        private List<string> _goalInfo = new List<string>();

// constructors

    public Goal(string goalTitle, string goalDescription, string goalPoints)
    {
        
    
    }

// getters and setters
   // user score
   public List<string> GetGoalInfo()
   {
      return _goalInfo;
   }

   public void AddGoalItem(string item){
    _goalInfo.Add(item);
   }
   public void ClearGoalItems(){
    _goalInfo = new List<string>();
   }
   public virtual void SetGoalInfo(string goalTitle, string goalDescription, string goalPoints, string isCompleted, string bonus, string checksToBonus, string checksSoFar)
    {

    }

// behaviors

   public virtual int RecordEvent(){
    return 0;
   }
   public virtual void IsComplete(){}
}