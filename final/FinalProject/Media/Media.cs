public class Media
{
// attributes
   private string _title;
   private double _score;
   private Mood _mood;
   private Genre _genre;
   private Rating _rating;
// constructors
   public Media(string title, string mood, List<int> genres, int rating)
   {
      SetTitle(title);
      SetMood(mood);
      SetGenre(genres);
      SetRating(rating);
   }
// getters and setters
   //mood
   public string GetTitle(){
      return _title;
   }
   public void SetTitle(string title){
      _title = title;
   }
   public double GetScore(){
      return _score;
   }
   public void SetScore(double score){
      _score = score;
   }
   public Mood GetMood(){
      return _mood;
   }
   public void SetMood(string mood){
      _mood = new Mood(mood);
   }
   //genre
   public Genre GetGenre(){
      return _genre;
   }
   public string[] GetTopGenres(){
      List<int> scores = _genre.GetAll();
      string[] genres = {"Action","Comedy","Drama","Fantasy","Horror","Mystery","Romance","Thriller","Western"};
      int max1 = -1;
      int max2 = -1;
      int index = 0;
      int g1 = 0;
      int g2 = 0;                     
      foreach (int item in scores)
      {
         if (item > max1)
         {
            max2 = max1;
            g2 = g1;
            max1 = item; 
            g1 = index;
         }
         else if (item > max2)
         {
            max2 = item; 
            g2 = index;
         }
         index++;
      }
      return new string[] {genres[g1], genres[g2]};
   }
   public void SetGenre(List<int> genres){
      _genre = new Genre(genres);
   }
   //rating
   public Rating GetRating(){
      return _rating;
   }
   public void SetRating(int rating){
      _rating = new Rating(rating);
   }
// behaviors
   public int GetMediaScore(string mood, string genre1, string genre2){
      int score = 0;
      if(mood == _mood.GetMood()){
         score += 50;
      }
      score += _genre.GetByType(genre1);
      score += _genre.GetByType(genre2);
      score += _rating.GetRating();
      return score;
   }
   
   public virtual List<int> GetMediaLength(){
      return new List<int>{0, 0};
   }
   public virtual string mediaToString(){
        return "";
   }
}