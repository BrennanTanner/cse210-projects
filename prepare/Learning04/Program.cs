using System;

class Program
{
    static void Main(string[] args)
    {
        // clear console
      Console.Clear();

        // initialize new assigment
      Assignment assigment = new Assignment("Ray T" , "Pottery");
        // display assigment
      Console.WriteLine("\nStep 3: ");
      Console.WriteLine(assigment.GetSummary());

        // initialize new math assigment
      MathAssignment mathAssigment = new MathAssignment("Chuck C" , "Algebra", "7.3", "8-19");
        // display math assigment
      Console.WriteLine("\nStep 4: ");
      Console.WriteLine(mathAssigment.GetSummary());
      Console.WriteLine(mathAssigment.GetHomeworkList());

        // initialize new writing assigment
      WritingAssignment writingAssigment = new WritingAssignment("Ronald M" , "English", "The Causes of World War II");
        // display writing assigment
      Console.WriteLine("\nStep 5: ");        
      Console.WriteLine(writingAssigment.GetSummary());
      Console.WriteLine(writingAssigment.GetWritingInformation());
    }
}