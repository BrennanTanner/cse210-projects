public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
      base.SetStudentName(studentName);
      base.SetTopic(topic);
      SetTitle(title);
    }

   public string GetTitle()
   {
      return _title;
   }
   public void SetTitle(string title)
    {
        _title = title;
    }

   public string GetWritingInformation()
   {
      return($"{GetTitle()} by {base.GetStudentName()}");

   }
}