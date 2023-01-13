using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "0";
        Journal myJournal = new Journal();
    
        //welcomes the User
        Console.WriteLine("Welcome to the Journal Program!");
        do {
            //dislays the menu
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            userInput = Console.ReadLine();

            switch(userInput) 
            {
                case "1":
                    myJournal.WriteEntry();
                    break;
                case "2":
                    myJournal.DisplayEntries();
                    break;
                case "3":
                    myJournal.LoadEntries();
                    break;
                case "4":
                    myJournal.SaveEntries();
                    break;
                case "5":
                    break;
                default:
                //error handling any input besides 1-5
                Console.WriteLine("\nThat's not a proper answer!");
                    break;

            }

        } while (userInput != "5");
        Console.WriteLine("See you next time!");
    }
}