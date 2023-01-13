using System.IO;

public class Journal
{
   public List<Entry> _entries = new List<Entry>();

   public List<Entry> _newEntries = new List<Entry>();

public void WriteEntry()
{
   Entry newEntry = new Entry();
   Prompt prompt = new Prompt();

   //Get date and add it to the entry
   DateTime today = DateTime.Today;
   newEntry._date = today.ToString("MM/dd/yyyy");

   //Load prompts from a page
   prompt.LoadPrompts();
   string userInput = "n";

   //checks if user wants a new prompt, gets prompt, then adds prompt to the entry
   do {
   string newPrompt = prompt.GetPrompt();
   newEntry._prompt = newPrompt;
   Console.Write($"{newPrompt}\n(type 'n' for a new prompt)\n>");
   userInput = Console.ReadLine();
   }while(userInput == "n");

   //adds user response to entry 
   newEntry._textBody = userInput;

   //adds new entry to list of entries
   _entries.Add(newEntry);

}

public void SaveEntries()
{
   //asks for file name, then pulls that file or creates that file. 
   Console.WriteLine("What is the filename?");
   string filename = Console.ReadLine();

   using (StreamWriter outputFile = new StreamWriter(filename))
   {
      //for each entry, write a new line with the data.
       foreach(Entry entry in _entries){
         outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._textBody}");
      };

   }

}
public void LoadEntries()
{
   //asks for file name, then pulls that file 
   Console.WriteLine("What is the filename?");
   string filename = Console.ReadLine();

   string[] lines = System.IO.File.ReadAllLines(filename);

   //makes a new enrty class and clears the previous entries list
   Entry loadedEntry = new Entry();
   _entries.Clear();

  //seperates the parts in the file and adds them to new class
   foreach (string line in lines)
   {
      string[] parts = line.Split(",");

      loadedEntry._date = parts[0];
      loadedEntry._prompt = parts[1];
      loadedEntry._textBody = parts[2];

      //adds new class to entries list
      _entries.Add(loadedEntry);
   }
}
public void DisplayEntries()
{
   //for each entry runs the function
   foreach(Entry entry in _entries){
      entry.DisplayEntryDetails();
   };
}

}