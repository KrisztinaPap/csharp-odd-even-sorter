﻿using System;
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

        // Initialized two empty lists
        List<int> evenNumbers = new List<int> ();
        List<int> oddNumbers = new List<int> ();

        // Sorts numbers by even/odd and adds them to the appropriate lists
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

        // Citation:
        //      https://www.dotnetperls.com/convert-list-array
        //      The code line below converts the list to an array
        int[] sortedEvenNumbers = evenNumbers.ToArray();
        int[] sortedOddNumbers = oddNumbers.ToArray();

        SortNumbers(sortedEvenNumbers);
        SortNumbers(sortedOddNumbers);
                  
        }
        static void SortNumbers(int[] theArray)
        {
            // Citation:
            //      https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=netcore-3.1
            //      The code line below sorts the array itms from smallest to largest
            Array.Sort(theArray);
            foreach( int number in theArray )
            {
                if (number != 0)
                Console.WriteLine(number);
            }
        }
    }
}
