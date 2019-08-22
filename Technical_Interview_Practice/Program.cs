using System;
using System.Collections.Generic;

namespace Technical_Interview_Practice
{
    class Program
    {
        #region  Given an array of integers, write a method to total the odd numbers.
        static int AddOdd(Array array)
        {
            int total = 0;
            foreach (int num in array)
            {
                if(num % 2 == 1)
                {
                    total += num;
                }
            }
            return total;
        }
        #endregion
        #region  Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.
        static long Sum(Array array)
        {
            long total = 0;
            foreach (long num in array)
            {
                total += num;
            }

            return total;
        }
        #endregion
        #region Given a string, reverse it.
        static string Reverse(string input)
        {
            int newIndex = 0;
            Array reversedArray = new char[input.Length];
            for (var i = input.Length - 1; i >= 0; i--)
            {
                reversedArray.SetValue(input[i], newIndex);
                newIndex++;
            }
            string reversed = "";
            foreach (var c in reversedArray)
            {
                reversed += c;
            }

            return reversed;
        }
        #endregion
        #region Given a string, remove any repeated letters.
        static string Dedupe(string input)
        {
            foreach (var c in input)
            {
                int first = input.IndexOf(c);
                int last = input.LastIndexOf(c);
                if (first != last)
                {
                    input = input.Replace(c.ToString(), string.Empty);
                } 
            }
            return input;
        }
        #endregion
        #region FizzBuzz
        static void FizzBuzz()
        {
            int count = 1;
            while (count <= 100)
            {
                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (count % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(count);
                }

                count++;
                
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Array array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(AddOdd(array));

            Array array2 = new long[] { 20000000, 1434536, 326546546, 12646545 };
            var sum = Sum(array2);
            Console.WriteLine(sum);

            Console.WriteLine(Reverse("raccoon"));

            Console.WriteLine(Dedupe("raccoon"));

            FizzBuzz();
        }
    }
}
