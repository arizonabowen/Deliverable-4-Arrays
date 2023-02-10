/*
 * Author: Jacquelyn Bowen
 * Date: 02/09/2023
 * Comments: This C# Console application code demonstrates the use of arrays without the input from a user
 * */

using System;
using System.Linq;

namespace Arrays
{

    class Program
    {
        static void Main(string[] args)
        {
            // Declare integer for fibonacci series
            int[] fibonacci = new int[25];

            // Initialize fibonacci series
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            // For loop to get the value of fibonacci[i]
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            Console.WriteLine("");
            Console.WriteLine("Fibonacci");

            // For loop to display the value of i and fibonacci[i]
            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}