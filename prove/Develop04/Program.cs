using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        int activityTime;

        bool quit = false;
        while (quit == false)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu:");
            string userChoise = Console.ReadLine();

            switch(userChoise) 
                {
                case "1":
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.Clear();
                    breathing.DisplayStartMessage();
                    activityTime = breathing.GetActivityTime();
                    stopwatch.Start();

                    while (stopwatch.ElapsedMilliseconds / 1000 < activityTime){
                        Console.WriteLine("\n");
                        breathing.Breathe();
                    }

                    breathing.DisplayEndMessage();
                    break;
                case "2":
                ReflectionActivity reflection = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Console.Clear();
                    reflection.DisplayStartMessage();
                    activityTime = reflection.GetActivityTime(); 

                    reflection.DisplayPrompt();
                    reflection.ResetUsedPrompts();
                    stopwatch.Start();
                    while (stopwatch.ElapsedMilliseconds / 1000 < activityTime){
                       reflection.DisplayReflection(activityTime);
                    }
                    reflection.ResetUsedPrompts();
                    reflection.DisplayEndMessage();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    Console.Clear();
                    listing.DisplayStartMessage();
                    activityTime = listing.GetActivityTime();

                    listing.DisplayPrompt();

                    stopwatch.Start();
                    while (stopwatch.ElapsedMilliseconds / 1000 < activityTime){
                        listing.CountItems(activityTime);
                     }
                    listing.DisplayItemsListed();
                    listing.ResetUsedPrompts();
                    listing.DisplayEndMessage();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                Console.WriteLine("That is not a valid response");
                Console.WriteLine("Hit any key to try again");
                string Input = Console.ReadLine();
                    break;
            }
        }

    }
    static void BreathingActivity(){

    }
    static void ReflectionActivity(){
        
    }
    static void ListingActivity(){
        
    }
}