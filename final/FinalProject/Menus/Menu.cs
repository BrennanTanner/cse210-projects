public class Menu
{
// attributes
    private List<string> _options = new List<string>();
    private List<Media> _media = new List<Media>();
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
   public List<Media> GetMedias()
   {
      return _media;
   }
   public void SetMedias(List<Media> media)
    {
        _media = media;
    }

  public void UpdateMedia(Media media, int index)
    {
        _media[index] = media;
    }

    public void AddMedia(Media media)
    {
        _media.Add(media);
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

    public void LoadFromFile(){
      string[] medias = System.IO.File.ReadAllLines("media.txt");
      foreach (string media in medias)
      {
        string[] mediaInfo = media.Split('?');
        string mediaType = mediaInfo[0];
        string[] mediaData = mediaInfo[1].Split('+');
        string[] mediaRuntime = mediaInfo[2].Split('+');
        List<int> mediaScores = new List<int>();
        foreach (string item in mediaInfo[1].Split('-'))
        {
            mediaScores.Add(int.Parse(item));
        }

        if (mediaType == "tv"){
           new Tv(mediaData[0], mediaScores, int.Parse(mediaData[1]), int.Parse(mediaRuntime[0]), int.Parse(mediaRuntime[1]), int.Parse(mediaRuntime[2]));
        }else if(mediaType == "doc"){
           
        }else{
            
        }
      }
    }

    public virtual void GetUserInput(){

    }
}