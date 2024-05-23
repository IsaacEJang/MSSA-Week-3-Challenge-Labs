using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk_3_Challenge_Labs
{
    internal class Program
    {
        static void Introduction()
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Week 3 Challenge Labs");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Transition()
        {
            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }

        static void Part(int i)
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n---------------PART {i}---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ClosingMessage()
        {
            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");
        }

        static void Main(string[] args)
        {
        //    #region Part1
        //    Introduction();
        //StartPoint1:

        //    /*1. Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). 
        //     * Assume that string may consist only of lower-case letters.

        //    Expected input and output
        //    IsPalindrome("eye") → true
        //    IsPalindrome("home") → false*/

        //    Console.WriteLine("I can check if a word is a palindrome");
        //    Console.Write("Enter word: ");
        //    string input = Console.ReadLine().ToLower(); // takes input and converts to lower case

        //    if (IsPalindrome(input))
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine($"\n{IsPalindrome(input)}: '{input}' is a palindrome.\n");
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"\n{IsPalindrome(input)}: '{input}' is not a palindrome.\n");
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }

        //    while (true)
        //    {
        //        // ask user if they want to try again
        //        Console.WriteLine("\nWant to try again? (Y / N)");
        //        char answer = char.Parse(Console.ReadLine().ToUpper());

        //        // wants to continue
        //        if (answer == 'Y')
        //        {
        //            goto StartPoint1;
        //        }

        //        // does not want to continue
        //        else if (answer == 'N')
        //        {
        //            break;
        //        }

        //        // invaid entry
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("\nEnter valid character");
        //            Console.ForegroundColor = ConsoleColor.White;
        //            continue;
        //        }
        //    }
        //    #endregion

        //    #region Part2
        //    Transition();
        //    Part(2);

        //    /* 2. Sum digits in string
        //    Given a string, write a method which returns sum of all digits 
        //    in that string. Assume that string contains only single digits.

        //    Expected input and output
        //    SumDigitsInString("1q2w3e") → 6 
        //    SumDigitsInString("L0r3m.1p5um") → 9
        //    SumDigitsInString("") → 0*/


        //    #endregion

        //    #region Part3
        //    Transition();
        //    Part(3);
        //    StartPoint3:

        //    /*3. Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //    You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //    Input: nums = [2,7,11,15], target = 9
        //    Output: [0,1]

        //    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].*/

        //    Console.WriteLine("Enter an array and a target number and I will return the index of the two numbers that add up to the target number");
        //    Console.Write("Please enter an array of integers separated by commas: ");
        //    string input2 = Console.ReadLine(); //takes user's array as a temp string

        //    // puts string into array and converts to int array
        //    int[] array = input2.Split(',').Select(int.Parse).ToArray();

        //    // target number
        //    Console.Write("Target Number: ");
        //    int target = int.Parse(Console.ReadLine());

        //    //declare answer array and initalize array to {-1,-1} for if statement later
        //    int[] answerArray = { -1, -1 };

        //    //for loop to go through every variation
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++) //start with i+1 so it does not repeat i
        //        {
        //            if (array[i] + array[j] == target) //if pair is found
        //            {
        //                answerArray[0] = i;// reassign to answer
        //                answerArray[1] = j;
        //                break;
        //            }
        //        }
        //    }

        //    //print answer
        //    if (answerArray[0] == -1) //pair not found
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"\nNo two numbers add up to the target number: {target}\n");
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //    else // pair found
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine($"\nTarget Number: {target} can be found by adding the two numbers at indices [{answerArray[0]},{answerArray[1]}]\n");
        //        Console.ForegroundColor = ConsoleColor.White;

        //    }

        //    while (true)
        //    {
        //        // ask user if they want to try again
        //        Console.WriteLine("\nWant to try again? (Y / N)");
        //        char answer = char.Parse(Console.ReadLine().ToUpper());

        //        // wants to continue
        //        if (answer == 'Y')
        //        {
        //            goto StartPoint3;
        //        }

        //        // does not want to continue
        //        else if (answer == 'N')
        //        {
        //            break;
        //        }

        //        // invaid entry
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("\nEnter valid character");
        //            Console.ForegroundColor = ConsoleColor.White;
        //            continue;
        //        }
        //    }
        //    #endregion

            #region Part4
            //Transition();
            Part(4);
            StartPoint4:
            /*4. You are given a string s consisting only of uppercase English letters.

            You can apply some operations to this string where, in one operation, you can remove any occurrence of one of the substrings "AB" or "CD" from s.
            Return the minimum possible length of the resulting string that you can obtain.
            Note that the string concatenates after removing the substring and could produce new "AB" or "CD" substrings.

            **Hint : Use Replace method of string.

            Example 1:
            Input: s = "ABFCACDB"
            Output: 2
            Explanation: We can do the following operations:
            - Remove the substring "ABFCACDB", so s = "FCACDB"
            - Remove the substring "FCACDB", so s = "FCAB".
            - Remove the substring "FCAB", so s = "FC".

            So the resulting length of the string is 2.
            It can be shown that it is the minimum length that we can obtain.

            Example 2
            Input: s = "ACBBD"
            Output: 5

            Explanation: We cannot do any operations on the string so the length remains the same.*/

            Console.WriteLine("\nEnter an string and I will remove 'AB' and 'CD'");
            string s = Console.ReadLine().ToUpper();

            Console.WriteLine($"The current string is: {s}");

            while (s.Contains("AB") || s.Contains("CD"))
            {
                s = s.Replace("AB", "");
                s = s.Replace("CD", "");

                Console.WriteLine($"The current string is: {s}");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nThe resulting string '{s}' has a length of {s.Length}\n");
            Console.ForegroundColor = ConsoleColor.White;

            TryAgain:
            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint4;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain;
            }
            

            #endregion

            ClosingMessage(); Console.ReadKey();
        }

        // Part 1
        static bool IsPalindrome(string input)
        {
            //creating new character array and setting to the size of the input length
            char[] reversedArray = new char[input.Length];

            // Loop through the input string from the end to the beginning
            for (int i = 0; i < input.Length; i++)
            {
                reversedArray[i] = input[input.Length - 1 - i]; // setting each element of reversedArray to the last element
            }

            // Convert the character array back to a string
            string reversedWord = new string(reversedArray);

            // palindrome checker
            if (input == reversedWord) { return true; }
            else { return false; }
        }
    }
}
