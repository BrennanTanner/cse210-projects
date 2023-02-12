using System;

class Program
{
    static void Main(string[] args)
    {
        Menu home = new Menu("Welcome To the 'What to Watch' Program!\n\nMenu Options:", new List<string> {"Find me something to watch", "Add media to Database", "Quit"}, "Select a Choice from the menu: ");
        bool quit = false;
        while (quit == false)
        {
            home.DisplayMenu();

            switch(Console.ReadLine()) 
                {
                case "1": 
                   string mood = MoodPicker();
                   Console.WriteLine("Pick your first Genre");
                   string genre1 = GenrePicker();
                   Console.WriteLine("Pick your second Genre");
                   string genre2 = GenrePicker();

                   
                    break;
                case "2":
                    
                    break;
                case "3":
                    quit = true;
                    break;
                default:
                Console.Write("That is not a valid response, try again: ");
                    break;
            }
        }
    }

    static string MoodPicker(){
        Menu mood = new Menu("How are you feeling today?", new List<string> {"Happy", "Neutral", "Sad", "Random"}, "Select a Choice from the menu: ");
        mood.DisplayMenu();
        bool quit = false;
        while (quit == false)
        {
            switch(Console.ReadLine()) 
            {
                case "1": 
                    return "happy";
                case "2": 
                    return "nuetral";
                case "3": 
                    return "sad";
                case "4": 
                    return "random";
                default:
                Console.Write("That is not a valid response, try again: ");
                    break;
            }
        }
        return "Error";
    }
        static string GenrePicker(){
        Menu mood = new Menu("Which genre would you like? ", new List<string> {"Action", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Thriller", "Western", "Random"}, "Select a genre from the menu: ");
        mood.DisplayMenu();
        bool quit = false;
        while (quit == false)
        {
            switch(Console.ReadLine()) 
            {
                case "1": 
                    return "action";
                case "2": 
                    return "comedy";
                case "3": 
                    return "drama";
                case "4": 
                    return "fantasy";
                case "5": 
                    return "horror";
                case "6": 
                    return "mystery";   
                case "7": 
                    return "romance";   
                case "8": 
                    return "thriller";      
                case "9": 
                    return "western";                                                                                       
                case "0": 
                    return "random";
                default:
                Console.Write("That is not a valid response, try again: ");
                    break;
            }
        }
        return "Error";
    }
    static void NewMedia(){
        
    }
}