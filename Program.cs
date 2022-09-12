/*  
 Purpose: Demonstrate basic arithmetic in C#
Input: N/A
Output: The results of various arithmetic operations
 Author: Ilyas G
Date: Sept 12 2022
 */







using System;

namespace arithmeticoperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int a = 2,
                b = 3,
            remainder;
            double c = 4,
                d = 5;
            // display original values
            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}" );

            // combined operators
            // a = a + 1
            a = a + 1;
            Console.WriteLine($" a = {a}");
            b += 1;
            Console.WriteLine($" b = {b}");
            a += 3;
            Console.WriteLine($" a = {a}");
            b -= 6;
            Console.WriteLine($" b = {b}");
            c = c % d;
            Console.WriteLine($" c = {c} -- did not work "); 
           
            remainder = a % b;
            Console.WriteLine($" a % b = {remainder}");
            // increment operators
            Console.WriteLine($" a = {a}, a++ = {a++}, ++a = {++a}" );

            // divide by zero
            Console.WriteLine($" c / 0 = {c / 0}");
            Console.WriteLine($" a / 0 = {a / 0}");

            Console.ReadLine();
        }
    }
}
