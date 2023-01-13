public class Prompt
{
   public string _filename = "prompts.txt";
   public List<string> _promptList = new List<string>();

public Prompt()
{

}

public void LoadPrompts()
{
   //pulls the prompts file
   string[] lines = System.IO.File.ReadAllLines(_filename);

   //for each line, add it to the prompts list
   foreach (string line in lines)
   {
         _promptList.Add(line);
   }
}
public string GetPrompt()
{
   //makes a random number depending on the length of the prompts list
   Random rnd = new Random();
   int prompt = rnd.Next(_promptList.Count);

   //Returns a random prompt
   return _promptList[prompt];
}

}