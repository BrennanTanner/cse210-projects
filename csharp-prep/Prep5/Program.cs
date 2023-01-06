using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int sNumber = SquareNumber(number);
        DisplayResult(name, sNumber);
    }
    static void DisplayWelcome() {

        Console.WriteLine("Welcome to the Program!");
        
    }
    static string PromptUserName() {

        Console.Write("Enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
        
    }
    static int PromptUserNumber() {

        Console.Write("Enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
        
    }
    static int SquareNumber( int num ) {

       int numSquared = num * num;
        return numSquared;
        
    }
    static void DisplayResult(string name, int sNum) {

        Console.WriteLine($"{name}, the square of your number is {sNum}");
        
    }
}