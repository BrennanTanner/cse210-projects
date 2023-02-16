public class Tv : Media
{
// attributes
private int _epLength;
private int _seasonLength;
private int _seriesLength;

// constructors
    public Tv(string title, string mood, List<int> genres, int rating, int epLength, int seasonLength, int seriesLength) :base(title, mood, genres, rating)
    {
        SetEpLength(epLength);
        SetSeasonLength(seasonLength);
        SetSeriesLength(seriesLength);
    }
// getters and setters
   //ep Length
   public int GetEpLength(){
      return _epLength;
   }
   public void SetEpLength(int epLength){
      _epLength = epLength;
   }
    //season Length
   public int GetSeasonLength(){
      return _seasonLength;
   }
   public void SetSeasonLength(int seasonLength){
      _seasonLength = seasonLength;
   }
    //series Length
   public int GetSeriesLength(){
      return _seriesLength;
   }
   public void SetSeriesLength(int seriesLength){
      _seriesLength = seriesLength;
   }
// behaviors
   public override List<int> GetMediaLength(){
     List<int> length = new List<int>();
     length.Add(GetEpLength());
     length.Add(GetSeasonLength());
     length.Add(GetSeriesLength());
     return length;
   }
   public override string mediaToString(){
      List<int> genres = base.GetGenre().GetAll();
        return $"tv?{base.GetTitle()}+{genres[0]}-{genres[1]}-{genres[2]}-{genres[3]}-{genres[4]}-{genres[5]}-{genres[6]}-{genres[7]}-{genres[8]}+{base.GetMood().GetMood()}+{base.GetRating().GetRating()}?{_epLength}+{_seasonLength}+{_seriesLength}";
   }
}