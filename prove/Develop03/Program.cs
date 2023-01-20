using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Clear();
        Console.WriteLine("Which scripture mastery set would you like to practice?\nOld Testament: type'O'\nNew Testament: type'N'\nBook of Mormon: type'B'\nDoctrine & Covenants: type'D'\nExit Program: type'quit'\n");
        string userChoise = Console.ReadLine();
        string filename = "";
        bool goodRes = false;
        while (goodRes == false)
        {
            switch(userChoise) 
            {
                case "O":
                    filename = "old_testament.txt";
                    goodRes = true;
                    break;
                case "N":
                    filename = "new_testament.txt";
                    goodRes = true;
                    break;
                case "B":
                    filename = "book_of_mormon.txt";
                    goodRes = true;
                    break;
                case "D":
                    filename = "doctrine&covenants.txt";
                    goodRes = true;
                    break;
                case "quit":
                    break;
                default:
                Console.WriteLine("That is not a valid response");
                Console.WriteLine("Hit any key to try again");
                string Input = Console.ReadLine();
                Console.Clear();
                    break;

            }
        }
            int setLength = GetSetLength(filename);
            Random rnd = new Random();
            int i = rnd.Next(setLength);
            string text = GetScriptureFile(filename, i);

            Scripture scripture = new Scripture(text);
            Console.Clear();
            Console.Write(scripture.GetReference());
            Console.WriteLine(scripture.GetRenderedText());

            string userInput = "";
            while(userInput != "quit"){
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();
                Console.Clear();
                scripture.HideWords();
                Console.Write(scripture.GetReference());
                Console.WriteLine(scripture.GetRenderedText());
        } 
    }

    static int GetSetLength(string filename){

        string[] lines = System.IO.File.ReadAllLines(filename);

        return lines.Length;

    }
    static string GetScriptureFile(string filename, int i){

        string[] lines = System.IO.File.ReadAllLines(filename);

        return lines[i];

    }

}

