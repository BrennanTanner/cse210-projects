using System;
using System.Diagnostics;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<Media> loadedMedia = new List<Media>();
        string[] mediaList = System.IO.File.ReadAllLines("media.txt");
         foreach (string item in mediaList)
         {
           loadedMedia.Add(NewMedia(item));
         }

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

                    foreach (Media item in loadedMedia)
                    {   
                        item.SetScore(item.GetMediaScore(mood, genre1, genre2));
                    }
                   // scores = scores.OrderBy(arr => arr[1]).ToList();
                    IEnumerable<Media> orderedMedia = loadedMedia.OrderBy(media => -media.GetScore());
                        List<string> rankedOptions = new List<string>();
                        int index = 0;
                    foreach (Media item in orderedMedia)
                    {
                        if (index < 9){
                         rankedOptions.Add($"{item.GetTitle()} - {Math.Round((item.GetScore()/200 * 100), 0)}% Match");
                        }
                        index++;
                    }
                    rankedOptions.Add("Return to menu");

                    bool quitList = false;
                    while(quitList == false){
                    Menu rankedList= new Menu("Top Matches:", rankedOptions, "Select an item to see details: ");
                    rankedList.DisplayMenu();

                    int input = int.Parse(Console.ReadLine());
                    if (input != rankedOptions.Count())
                    {
                        Console.Clear();
                        index = 0;
                        bool quitInfo = false;
                    while(quitInfo == false){
                        foreach (var item in orderedMedia)
                        {
                            List<int> lengthData = item.GetMediaLength();
                            if (index == input-1){
                                switch (item.GetType().ToString())
                                {
                                    case "Tv":
                                        Console.WriteLine($"- {item.GetTitle()} -\n\n{item.GetTopGenres()[0]} {item.GetTopGenres()[1]}\nRating: {item.GetRating().GetRating()}\nMood: {item.GetMood().GetMood()}\n\nAverage Episode Length: {lengthData[0]} minutes - Episodes per Season: {lengthData[1]} - Total Seasons: {lengthData[2]}\nTotal Watch Time: {(lengthData[0]*lengthData[1]*lengthData[2])/60} hours");
                                        break;
                                    case "Movie":
                                        Console.WriteLine($"- {item.GetTitle()} -\n\n{item.GetTopGenres()[0]} {item.GetTopGenres()[1]}\nRating: {item.GetRating().GetRating()}\nMood: {item.GetMood().GetMood()}\n\nTotal Watch Time: {lengthData[0]} minutes");
                                        break;
                                    case "Documentary":
                                        Console.WriteLine($"- {item.GetTitle()} -\n\n{item.GetTopGenres()[0]} {item.GetTopGenres()[1]}\nRating: {item.GetRating().GetRating()}\nMood: {item.GetMood().GetMood()}\n\nAverage Episode Length: {lengthData[0]} minutes - Episodes in the Series: {lengthData[1]}\nTotal Watch Time: {(lengthData[0]*lengthData[1])/60} hours");                                    
                                        break;
                                }     
                            }
                            index++;
                        }
                    
                        Console.WriteLine("Press enter to return to list ");
                        Console.ReadLine();
                        quitInfo = true;
                    }
                    }
                    else{
                        quitList = true;
                    }
                    }
                   
                    break;
                case "2":
                    loadedMedia.Add(CreateNewMedia());
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
       string input = Console.ReadLine();
        while (quit == false)
        {
            switch(input) 
            {
                case "1": 
                    return "happy";
                case "2": 
                    return "nuetral";
                case "3": 
                    return "sad";
                case "4": 
                    Random rnd = new Random();
                    input = rnd.Next(1,3).ToString();
                    break;
            }
        }
        return "Error";
    }
        static string GenrePicker(){
        Menu mood = new Menu("Which genre would you like? ", new List<string> {"Action", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Thriller", "Western", "Random"}, "Select a genre from the menu: ");
        mood.DisplayMenu();
        bool quit = false;
        string input = Console.ReadLine();
        while (quit == false)
        {
            switch(input) 
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
                case "10": 
                   Random rnd = new Random();
                   input = rnd.Next(1,9).ToString();
                   break;
            }
        }
        return "Error";
    }
    static Media NewMedia(string mediaString){
        //split the string
        string[] mediaMetaData = mediaString.Split("?");
        string mediaType = mediaMetaData[0];
        string mediaData = mediaMetaData[1];
        string mediaLength = mediaMetaData[2];
        //get meta data
        string title = mediaData.Split("+")[0];
        List<int> genre = new List<int>();
        foreach (var item in mediaData.Split("+")[1].Split("-"))
        {
           genre.Add(int.Parse(item));
        }
        string mood = mediaData.Split("+")[2];
        int rating = int.Parse(mediaData.Split("+")[3]);

        int episode = 0;
        int season = 0;
        int series = 0;
         switch (mediaType)
            {
                case "tv":
                    // get length data
                    episode = int.Parse(mediaLength.Split("+")[0]);
                    season = int.Parse(mediaLength.Split("+")[1]);
                    series = int.Parse(mediaLength.Split("+")[2]);
                    return new Tv(title, mood, genre, rating, episode, season, series);
                case "mov":
                    // get length data
                    episode = int.Parse(mediaLength.Split("+")[0]);
                    return new Movie(title, mood, genre, rating, episode);                  
                default:
                    // get length data
                    episode = int.Parse(mediaLength.Split("+")[0]);
                    series = int.Parse(mediaLength.Split("+")[1]);   
                    return new Documentary(title, mood, genre, rating, episode, series);              
            }
    }
    static Media CreateNewMedia(){
        Menu mediaType = new Menu("What type of media is it?", new List<string> {"Tv Series", "Movie", "Documentary"}, "");
            mediaType.DisplayMenu();
        string type = Console.ReadLine();
        Console.WriteLine("What is the title of the media? ");
        string title = Console.ReadLine();
        List<int> genre = GetGenres();
        string mood = GetMood();
        Console.WriteLine("How would you rate this media from 1-100? ");
        int rating = int.Parse(Console.ReadLine());
        int ep;               
        int season;    
        int series;
        switch (type)
        {
            case "1":
                type = "tv";
                Console.WriteLine("How long are episodes on average (in minutes)? ");
                ep = int.Parse(Console.ReadLine());
                Console.WriteLine("How many episodes are there in a season? ");
                season = int.Parse(Console.ReadLine());
                Console.WriteLine("How many seasons are there? ");
                series = int.Parse(Console.ReadLine());

                Tv tv = new Tv(title, mood, genre, rating, ep, season, series);
                using (TextWriter tw = new StreamWriter("media.txt", true))
                {
                    tw.WriteLine(tv.mediaToString());
                }
                return tv;
            case "2":
                type = "mov";
                Console.WriteLine("How long is the film(in minutes)? ");
                ep = int.Parse(Console.ReadLine());

                Movie movie = new Movie(title, mood, genre, rating, ep);
                using (TextWriter tw = new StreamWriter("media.txt", true))
                {
                    tw.WriteLine(movie.mediaToString());
                }
                return movie;
            default:
                type = "doc";
                Console.WriteLine("How long are episodes on average (in minutes)? ");
                ep = int.Parse(Console.ReadLine());
                Console.WriteLine("How many episodes are there? ");
                season = int.Parse(Console.ReadLine());

                Documentary doc = new Documentary(title, mood, genre, rating, ep, season);
                using (TextWriter tw = new StreamWriter("media.txt", true))
                {
                    tw.WriteLine(doc.mediaToString());
                }
                return doc;
        }

    }
    static List<int> GetGenres()
    { 
        List<string> genres = new List<string> {"Action", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Thriller", "Western" };
        List<int> genreScores = new List<int>();
        List<double> scores = new List<double>();
        double score = 0;
        double scoreTotal = 0;
        foreach (string genre in genres)
        {   
            Console.WriteLine($"Rank the {genre} of this media on a scale of 1-10");
            score = double.Parse(Console.ReadLine());
            scoreTotal += score;
            scores.Add(score);
        }
        foreach (double item in scores)
        {
           genreScores.Add((int)Math.Round(item / scoreTotal * 100)); 
        }
        return genreScores;
    }
    static string GetMood(){
        Console.WriteLine("What is the Mood of the Show?\n1. Happy\n2. Nuetral\n3. Sad");
        string mood = Console.ReadLine();
        switch (mood)
        {
            case "1":
                mood = "happy";
                break;
            case "2":
                mood = "nuetral";
                break;
            case "3":
                mood = "sad";
                break;
        }
        return mood;
    }
    static void ShowSpinner(int spinnerTime)
   {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      int SpinnerCounter = 0;
      while (stopwatch.ElapsedMilliseconds / 1000 < spinnerTime)
      {
         SpinnerCounter++;
         switch (SpinnerCounter % 4)
         {
            case 0: Console.Write("/"); break;
            case 1: Console.Write("-"); break;
            case 2: Console.Write("\\"); break;
            case 3: Console.Write("|"); break;
         }
         Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
         Thread.Sleep(200);
      }
      Console.Write(" ");
   }


}