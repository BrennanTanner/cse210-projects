public class Scripture
{
   private string _reference;
   private string _originalText;
    private string[] _renderedText;

    public Scripture( string scripture)
    {
      //string[] words = reference.Split(' ');
      string[] split = scripture.Split('>');

      Reference reference = new Reference(split[0]); 
      SetReference(reference.GetReference());

      SetOriginalText(split[1]);

      string[] text = split[1].Split(' ');
      SetRenderedText(text);
     
    }
   public void SetReference(string reference)
    {
       
      _reference = reference;
    }
   public string GetReference()
    {
      
      return _reference;
    }
   public void SetOriginalText(string originalText)
    {
      _originalText = originalText;
    }
   public string GetOriginalText(string originalText)
    {
      return _originalText;
    }
   public string GetRenderedText()
   {
      int length = _renderedText.Length;
      string newText = "";
      string oldText = "";
      for (int i = 0; i < length; i++)
      {
         oldText = _renderedText[i] + " ";
         newText = newText + oldText;
        
      }
      return newText;
   }
   public void SetRenderedText(string[] renderedText)
    {
      _renderedText = renderedText;
    }
   public void SetRenderedWord(string word, int i)
    {
      _renderedText[i] = word;
    }

   public void HideWords()
   {
      int length = _renderedText.Length;
      int blank1 = GetRandomNumber(length);
      int blank2 = GetRandomNumber(length);
      int blank3 = GetRandomNumber(length);

      Word word = new Word(_renderedText);
      int changes = 0;
      int iterations = 0;
      for (int i = 0; changes < 3; i++)
      {
         if (blank1 > length){
            blank1 = 0;
         }
         if (blank2 > length){
            blank1 = 0;
         }
         if (blank2 > length){
            blank1 = 0;
         }
         if (i == length){
            i = 0;
            iterations++;
         }
         if (iterations > 1 && changes == 0){
            IsCompletelyHidden();
         }
         else if(iterations > 1)
         {
            changes = 3;
         }
         else {
            if(i == blank1){
            if(word.IsHidden(i) == true){
               blank1++;
            }
            else{
               SetRenderedWord(word.Hide(i), i);
               changes++;
            }
         }
         else if(i == blank2)
         {
            if(word.IsHidden(i) == true){
               blank2++;
            }
            else{
               SetRenderedWord(word.Hide(i), i);
               changes++;
            }
         }
         else if(i == blank3)
         {
            if(word.IsHidden(i) == true){
               blank3++;
            }
            else{
               SetRenderedWord(word.Hide(i), i);
               changes++;
            }
         }
         else
         {
            
         }
         }
         
      }

   }
   public void IsCompletelyHidden()
   {
      Environment.Exit(0);
   }

      public int GetRandomNumber(int length)
   {
      Random rnd = new Random();
      return rnd.Next(length);
   }

      public int ChangeRandomNumber(int num1, int num2, int num3)
   {
      int length = _renderedText.Length;
      while (num1 == num2 || num1 == num3)
      {
         num1 = GetRandomNumber(length);
      }
      return num1;
   }
}