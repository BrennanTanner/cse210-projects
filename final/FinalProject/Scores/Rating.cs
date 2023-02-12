public class Rating: Score
{
// attributes
   private int _rating;
// constructors
    public Rating(int rating) : base()
    {
      SetRating(rating);
    }
// getters and setters
   //Rating
   public int GetRating(){
      return _rating;
   }
   public void SetRating(int rating){
      _rating = rating;
   }
// behaviors
public override int GetScoreAdditive(){
   return 0;
}
}