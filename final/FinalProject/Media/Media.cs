public class Media
{
// attributes
   private Mood _mood;
   private Genre _genre;
   private Rating _rating;
// constructors
   public Media(string mood, List<int> genres, int rating)
   {
      SetMood(mood);
      SetGenre(genres);
      SetRating(rating);
   }
// getters and setters
   //mood
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

}