public class Entry
{
   public string _date = "";
   public string _prompt = "";
   public string _textBody = "";

public Entry()
{

}

public void DisplayEntryDetails()
{
   //writes each piece of an entry
   Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt} \n{_textBody}\n");
}

}