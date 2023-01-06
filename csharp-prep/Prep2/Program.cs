using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your Grade percentage?: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letterGrade;
        string sign;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (letterGrade != "A" &&  letterGrade != "F") 
        {
            if (7 <= grade % 10) 
            {
                sign = "+";
            }          
            else if (3 >= grade % 10) 
            {
                sign = "-";
            }
            else 
            {
               sign = ""; 
            }

            
        }
        else 
        {
            sign = ""; 
        }

        Console.Write($"Your Grade is: {letterGrade}{sign}");

        if (letterGrade == "D" ||  letterGrade == "F") 
        {
            Console.Write(", you failed. Don't be sorry, be better.");
        }
        else
        {
            Console.Write(", wow! I can't believe you passed.");
        }
    }
}