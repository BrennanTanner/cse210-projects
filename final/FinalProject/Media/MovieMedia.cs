public class Movie : Media
{
// attributes
private int _length;
// constructors
    public Movie(string title, string mood, List<int> genres, int rating, int length) :base(title, mood, genres, rating)
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
   public override List<int> GetMediaLength(){
     List<int> length = new List<int>();
     length.Add(GetLength());
     return length;
   }
   public override string mediaToString(){
      List<int> genres = base.GetGenre().GetAll();
        return $"mov?{base.GetTitle()}+{genres[0]}-{genres[1]}-{genres[2]}-{genres[3]}-{genres[4]}-{genres[5]}-{genres[6]}-{genres[7]}-{genres[8]}+{base.GetMood().GetMood()}+{base.GetRating().GetRating()}?{_length}";
   }
}