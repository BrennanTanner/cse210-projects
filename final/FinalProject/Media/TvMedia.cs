public class Tv : Media
{
// attributes
private int _epLength;
private int _seasonLength;
private int _seriesLength;

// constructors
    public Tv(string mood, List<int> genres, int rating, int epLength, int seasonLength, int seriesLength) :base(mood, genres, rating)
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

}