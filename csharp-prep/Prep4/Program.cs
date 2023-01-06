using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int listSum = 0;
        float listAvg = 0;
        int listLargest = 0;
        int listSmallest = 0;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0 ){
            numbers.Add(number);
            }
        } while (number != 0 );

        foreach (int num in numbers)
        {
            //add all number in list together
            listSum += num;

            //change listSmallest to equal first item on list
            if (numbers.First()==num){
                listSmallest = num;
            }

            //find largest number
            if (num > listLargest){
                listLargest = num;
            }

            //find smallest number
            if (num < listSmallest && num > 0){
                listSmallest = num;
            }


        }

        listAvg = (float)listSum / numbers.Count;



        numbers.Sort();
        Console.WriteLine($"The sum is: {listSum}");
        Console.WriteLine($"The average is: {listAvg}");
        Console.WriteLine($"The largest number is: {listLargest}");
        Console.WriteLine($"The smallest positive number is: {listSmallest}");
        Console.WriteLine("The sorted list is:");
        Console.WriteLine(string.Join(",", numbers));
    }
}