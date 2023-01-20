public class Word
{
   private string[] _allWords;

    public Word( string[] allWords)
    {
      SetAllWords(allWords);

    }

   
   public string GetWord(int i)
   {
      return _allWords[i];
   }
      public void SetWord(string word, int i)
    {
        _allWords[i] = word;
    }

       public string[] GetAllWords()
   {
      return _allWords;
   }
   public void SetAllWords(string[] allWords)
    {
        _allWords = allWords;
    }


   public string Hide(int index)
   {
      string word= GetWord(index);
      int length = word.Length;

      word = "";
      for (int i = 0; i < length; i++)
      {
         word = word + "_";
        
      }

      SetWord(word, index);
      return word;
   }
   public bool IsHidden(int i)
   {
      if (GetWord(i).Substring(0, 1) == "_"){
         return true;
      }
      return false;
   }   
}