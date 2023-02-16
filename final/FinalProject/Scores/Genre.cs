public class Genre: Score
{
// attributes
   private int _action;  
   private int _comedy;
   private int _drama;
   private int _fantasy;
   private int _horror;
   private int _mystery;
   private int _romance;
   private int _thriller;
   private int _western;

// constructors
    public Genre(List<int> genres) : base()
    {
      SetAction(genres[0]);
      SetComedy(genres[1]);
      SetDrama(genres[2]);
      SetFantasy(genres[3]);
      SetHorror(genres[4]);
      SetMystery(genres[5]);
      SetRomance(genres[6]);
      SetThriller(genres[7]);
      SetWestern(genres[8]);
    }
// getters and setters
   public List<int> GetAll(){
      List<int> scores = new List<int>();
      scores.Add(GetAction());
      scores.Add(GetComedy());
      scores.Add(GetDrama());
      scores.Add(GetFantasy());
      scores.Add(GetHorror());
      scores.Add(GetMystery());
      scores.Add(GetRomance());
      scores.Add(GetThriller());
      scores.Add(GetWestern());
      return scores;
   }
   public int GetByType(string type){
      switch (type)
      {
         case "action":
            return GetAction();
         case "comedy":
            return GetComedy();
         case "drama":
            return GetDrama();
         case "fantasy":
            return GetFantasy();
         case "horror":
            return GetHorror();
         case "mystery":
            return GetMystery();
         case "romance":
            return GetRomance();
         case "thriller":
            return GetThriller();
         default:
            return GetWestern();
      }
   }
   //Action
   public int GetAction(){
      return _action;
   }
   public void SetAction(int action){
      _action = action;
   }
   //comedy
   public int GetComedy(){
      return _comedy;
   }
   public void SetComedy(int comedy){
      _comedy = comedy;
   }
   //drama
   public int GetDrama(){
      return _drama;
   }
   public void SetDrama(int drama){
      _drama = drama;
   }
   //fantasy
   public int GetFantasy(){
      return _fantasy;
   }
   public void SetFantasy(int fantasy){
      _fantasy = fantasy;
   }
   //horror
   public int GetHorror(){
      return _horror;
   }
   public void SetHorror(int horror){
      _horror = horror;
   }
   //mystery
   public int GetMystery(){
      return _mystery;
   }
   public void SetMystery(int mystery){
      _mystery = mystery;
   }
   //romance
   public int GetRomance(){
      return _romance;
   }
   public void SetRomance(int romance){
      _romance = romance;
   }
   //thriller
   public int GetThriller(){
      return _thriller;
   }
   public void SetThriller(int thriller){
      _thriller = thriller;
   }
   //western
   public int GetWestern(){
      return _western;
   }
   public void SetWestern(int western){
      _western = western;
   }
// behaviors

}