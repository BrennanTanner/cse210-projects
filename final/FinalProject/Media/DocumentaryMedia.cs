public class Documentary : Media
{
// attributes
    private int _epLength;
    private int _seriesLength;
// constructors
    public Documentary(string mood, List<int> genres, int rating, int epLength, int seriesLength) :base(mood, genres, rating)
    {
        SetEpLength(epLength);
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
    //series Length
   public int GetSeriesLength(){
      return _seriesLength;
   }
   public void SetSeriesLength(int seriesLength){
      _seriesLength = seriesLength;
   }
// behaviors

}