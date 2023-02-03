public class ListGoals : Menu
{
// attributes

// constructors
    public ListGoals( string instructions, List<string> options, string prompt) : base(instructions, options, prompt)
    {
        base.SetInstructions(instructions);
        base.SetOptions(options);
        base.SetPrompt(prompt);  
    }

// getters and setters

// behaviors
 public override void DisplayGoals(List <Goal> goals){

        int index = 0;
        foreach (Goal goal in goals)
        {
            List<string> goalInfo = goal.GetGoalInfo();
            index++;
            if (goal.GetType().Name == "SimpleGoal"){
                if (goalInfo[4] == "False"){
                    Console.WriteLine($"{index}. [ ] {goalInfo[1]} ({goalInfo[2]})");
                } else{
                    Console.WriteLine($"{index}. [X] {goalInfo[1]} ({goalInfo[2]})");
                }
                
            } else if (goal.GetType().Name == "EternalGoal"){
                Console.WriteLine($"{index}. [ ] {goalInfo[1]} ({goalInfo[2]})");
            } else {
                if(goalInfo[6] == goalInfo[4]){
                    Console.WriteLine($"{index}. [X] {goalInfo[1]} ({goalInfo[2]}) -- Currently completed: {goalInfo[6]}/{goalInfo[5]}");
                }
                else{
                    Console.WriteLine($"{index}. [ ] {goalInfo[1]} ({goalInfo[2]}) -- Currently completed: {goalInfo[6]}/{goalInfo[5]}");
                }
                
            }

            
        }

   }
}