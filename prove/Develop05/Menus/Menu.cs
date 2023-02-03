public class Menu
{
// attributes
    private List<string> _options = new List<string>();
    private List<Goal> _goals = new List<Goal>();
    private int _userScore;
    
    private string _instructions;
    private string _prompt;

// constructors
    public Menu( string instructions, List<string> options, string prompt)
    {
        SetInstructions(instructions);
        SetOptions(options);
        SetPrompt(prompt);
    }

// getters and setters
   // options
   public List<string> GetOptions()
   {
      return _options;
   }
   public void SetOptions(List<string> options)
    {
        _options = options;
    }
    // goals
   public List<Goal> GetGoals()
   {
      return _goals;
   }
   public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }

  public void UpdateGoal(Goal goal, int index)
    {
        _goals[index] = goal;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    // score
   public int GetUserScore()
   {
      return _userScore;
   }
   public void SetUserScore(int userScore)
    {
        _userScore = userScore;
    }
    public void AddScore(int score)
    {
        _userScore = _userScore + score;
    }

    // instructions
   public string GetInstructions()
   {
      return _instructions;
   }
   public void SetInstructions(string instructions)
    {
        _instructions = instructions;
    }
    // prompt
   public string GetPrompt()
   {
      return _prompt;
   }
   public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

// behaviors

   public void DisplayMenu(){

    if(_instructions != ""){
        Console.WriteLine(_instructions);
    }
    
    if(_options != new List<string>{}){
        int index = 0;
        foreach (string option in _options)
        {
            index++;
            Console.WriteLine($"{index}. {option}");
        }
    }
    Console.WriteLine(_prompt);
   }
  
  public virtual void DisplayGoals(List <Goal> goals){

   }
   public virtual void GetUserInput(List <Goal> goals){


   }
   
    public virtual string GoalToString(Goal goal){
        List<string> goalList = goal.GetGoalInfo();
        string goalString = "";
        int index = 0;
        foreach (string item in goalList)
        {
            if (index == 0){
                goalString += $"{item}:";
            }else if (index == 1){
               goalString += $"{item}";
            } else{
                goalString += $",{item}";
            }
            index++;
        }
        return goalString;
    }
    public string[] GetGoalInfo(string line){

        string[] goalType = line.Split(':');
        string[] goalInfo = goalType[1].Split(',');
        
        return goalInfo;
   }

       public string GetGoalType(string line){

       string[] goalType = line.Split(':');
        
        return goalType[0];
   }

}