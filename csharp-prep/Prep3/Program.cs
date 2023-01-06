using System;

class Program
{
    static void Main(string[] args)
    {
        bool play;

        do{
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guess;
            int count = 0;
                do {
                    Console.Write("What is your guess? ");
                    
                    string userInput = Console.ReadLine();
                    guess = int.Parse(userInput);
                    count++;
                    if (guess != number){
                        if (guess > number)
                            Console.WriteLine("Lower");
                        else{
                            Console.WriteLine("Higher");
                        }
                    }
                } while (guess != number);

            Console.WriteLine($"You guessed it in {count} guesses!");
            Console.Write("Do you want to play again?(y/n) ");
            string playAgain = Console.ReadLine();

            if (playAgain == "y" || playAgain == "Y"){
                play = true;
            }
            else{
                play = false;
            }

        } while (play == true);
    }
}