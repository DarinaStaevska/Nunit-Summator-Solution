using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long sum = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });
            if (sum == 21)
            {
                Console.WriteLine("TEST PASS");
            } else
            {
                Console.WriteLine("TEST FAIL");
            }
            static void Main(string[] args)
            {
                long Average = Summator.Average(new int[] { 5, 10, 15 });
                if (Average == 10)
                {
                    Console.WriteLine("TEST PASS");
                }
                else
                {
                    Console.WriteLine("TEST FAIL");
                }
            }
        }


