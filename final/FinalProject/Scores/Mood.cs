public class Mood: Score
{
// attributes 
   private string _mood;
// constructors
    public Mood(string mood) : base()
    {
      SetMood(mood);
    }
// getters and setters
   //Mood
   public string GetMood(){
      return _mood;
   }
   public void SetMood(string mood){
      _mood = mood;
   }
// behaviors

}