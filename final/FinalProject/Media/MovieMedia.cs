public class Movie : Media
{
// attributes
private int _length;
// constructors
    public Movie(string mood, List<int> genres, int rating, int length) :base(mood, genres, rating)
    {
        SetLength(length);
    }
// getters and setters
   //length
   public int GetLength(){
      return _length;
   }
   public void SetLength(int length){
      _length = length;
   }
// behaviors

}