using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    class LISFunction
    {
        public int LongestIncreasingSequence(int[] intArray)
        {
            int finalLargestLISLength = 0;
            int counter = 0;
            int x = 0;
            int y = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i == 0)
                {
                    x = intArray[i];
                }
                else
                {
                    x = intArray[i];
                    y = intArray[i - 1];

                    /* debug lines
                    Console.WriteLine(finalLargestLISLength);
                    Console.WriteLine(counter);
                    Console.WriteLine();
                    */

                    if (x >= y)
                    {
                        counter++; // counter increases if LIS is not complete

                        if (i == (intArray.Length - 1) && finalLargestLISLength < counter) // when the LIS is found at last element or array given is sorted
                        {
                            finalLargestLISLength = counter;
                        }
                    }
                    else
                    {
                        if (finalLargestLISLength < counter) // make counter the new final result for LIS final 
                        {
                            finalLargestLISLength = counter;
                            counter = 0;
                        }
                        else // reset counter back to 0
                        {
                            counter = 0;
                        }
                    }
                }
            }
            return finalLargestLISLength;
        }
    }
}
