using System;
using System.Collections.Generic;

namespace c_odd_even_sorter_practice_KrisztinaPap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Title: c-odd-even-sorter-practice
                Purpose: The program prompts the user for an array of ten numbers and returns an array of the even numbers from lowest to highest followed by the odd numbers from lowest to highest. 
                Author: Krisztina Pap
                Date of last edit: Aug 13, 2020
            */

        // Explains program to the user
        Console.WriteLine("Welcome to Number-sorter! You will be prompted for up to ten numbers and we will give you a sorted list with even numbers first, from lowest to highest, followed by the odd numbers, from lowest to highest. Just enter 'done' if you don't want to enter any more numbers. Hit enter when you are ready to start!");
        Console.ReadLine(); // Waits for user to continue

        // Declare variables
        string userInput = "";

        // Creates an empty number array, initilizes all values at 0
        int[] numbers = new int[10];
        int[] newNumbers = new int[10];
        Console.WriteLine(numbers[9]);
        
        // Sentinel loop with 'done' as the breaking value
        int i = 0;
        while ( userInput != "done" && i < 10 ) // Huge shout-out to Aaron Champagne for his troubleshooting help!
        {
            Console.WriteLine("Enter number {0}:", i+1);
            userInput = Console.ReadLine().ToLower();
            if (userInput != "done")
            {
                numbers[i] = int.Parse(userInput);
                i++;
            }
        }   

        // Initialized empty lists
        List<int> evenNumbers = new List<int> ();
        List<int> oddNumbers = new List<int> ();


        // Sorts numbers by even/odd 
        foreach (int number in numbers )
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
            else
            {
                oddNumbers.Add(number);
            }
        }

        int[] sortedEvenNumbers = evenNumbers.ToArray();

        Array.Sort(sortedEvenNumbers);
        foreach( int number in sortedEvenNumbers )
        {
            if (number != 0)
            Console.WriteLine(number);
        }

        int[] sortedOddNumbers = oddNumbers.ToArray();
        
        // Sort numbers by even/odd and then lowest to highest using methods
      
        Array.Sort(sortedOddNumbers);
        foreach( int number in sortedOddNumbers )
        {
            if (number != 0)
            Console.WriteLine(number);
        }
                 


        
        }
    }
}
