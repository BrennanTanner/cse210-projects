public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
   private string _endingVerse;
    

    public Reference(string reference)
    {
      string[] book = reference.Split('/');
      string[] chapter = book[1].Split(':');
      string[] verse = chapter[1].Split('-');

      SetBook(book[0]);
      SetChapter(chapter[0]);
      SetVerse(verse[0]);
      if (verse.Length > 1){
         SetVerse(verse[1]);
      }
    }
   
   public string GetBook()
   {
      return _book;
   }
   public void SetBook(string book)
    {
      _book = book;
    }

   public string GetChapter()
   {
      return _chapter;
   }
   public void SetChapter(string chapter)
    {
      _chapter = chapter;
    }

   public string GetVerse()
   {
      return _verse;
   }
   public void SetVerse(string verse)
    {
      _verse = verse;
    }

       public string GetEndingVerse()
   {
      return _endingVerse;
   }
   public void SetEndingVerse(string endingVerse)
    {
      _endingVerse = endingVerse;
    }

   public string GetReference()
   {
      if (GetEndingVerse() == null) {
         
        return ($"{GetBook()} {GetChapter()}:{GetVerse()} ");
      }
      return ($"{GetBook()} {GetChapter()}:{GetVerse()}-{GetEndingVerse()} ");
   }
}