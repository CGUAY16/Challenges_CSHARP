using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // references
            LISFunction lisFunction = new LISFunction();

            //
            // This Tests A function that returns the Longest Increasing Sequence of Positive Ints
            // Within an Array.
            //
            int[] arrayOfPosInts1 = new int[10] { 2, 4, 6, 8, 9, 3, 1, 5, 3, 4 };
            int[] arrayOfPosInts2 = new int[5] {4, 3, 5, 1, 6};

            Console.WriteLine(arrayOfPosInts1.Length);
            Console.WriteLine();

            int resultLIS = lisFunction.LongestIncreasingSequence(arrayOfPosInts1);
            Console.WriteLine(resultLIS);
            Console.WriteLine();

            resultLIS = lisFunction.LongestIncreasingSequence(arrayOfPosInts2);
            Console.WriteLine(resultLIS);
            Console.WriteLine();
        }
    }

}

