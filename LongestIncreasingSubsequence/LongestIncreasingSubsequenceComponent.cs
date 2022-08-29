using System.Collections.Generic;
using System.Text;

namespace LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequenceComponent
    {
        private StringBuilder stringBuilder = new StringBuilder();
        public string GetEarliestLongestIncreasingSubsequence(string inputString)
        {
            if (inputString == "")
                throw new ArgumentNullException("message","Please Enter Valid String of Integers seperated by single space");

            stringBuilder = FindTheLongestIncreasingSubarray(inputString);

            return stringBuilder.ToString();
        }

        private StringBuilder FindTheLongestIncreasingSubarray(string inputStr)
        {

            int[] inputArray = Array.ConvertAll(inputStr.Split(" "), s => int.Parse(s));

            int lengthOfTheLongestIncreasingSubarray = 1, lengthOfTheLastIncreasingSubarray = 1, maxIndex = 0, inputArrayLength = inputArray.Length;

            for (int i = 1; i < inputArrayLength; i++)
            {
                // if current element if greater than previous element, then this element
                // helps in building up the previous increasing subarray encountered so far

                if (inputArray[i] > inputArray[i - 1])
                    lengthOfTheLastIncreasingSubarray++;
                else
                {
                    // check if 'lengthOfTheLongestIncreasingSubarray' length is less than the length of the current increasing subarray.
                    // If true, then update 'lengthOfTheLongestIncreasingSubarray'

                    if (lengthOfTheLongestIncreasingSubarray < lengthOfTheLastIncreasingSubarray)
                    {
                        lengthOfTheLongestIncreasingSubarray = lengthOfTheLastIncreasingSubarray;

                        // index assign the starting index of longest increasing contiguous subarray.

                        maxIndex = i - lengthOfTheLongestIncreasingSubarray;
                    }

                    // reset 'lengthOfTheLastIncreasingSubarray' to 1 as from this element again the length of the new increasing subarray is being calculated

                    lengthOfTheLastIncreasingSubarray = 1;
                }
            }

            // comparing the length of the last increasing subarray with 'lengthOfTheLongestIncreasingSubarray'

            if (lengthOfTheLongestIncreasingSubarray < lengthOfTheLastIncreasingSubarray)
            {
                lengthOfTheLongestIncreasingSubarray = lengthOfTheLastIncreasingSubarray;
                maxIndex = inputArrayLength - lengthOfTheLongestIncreasingSubarray;
            }

            // finding out the elements of longest increasing contiguous subarray and adding to the StringBuilder for output.
            for (int i = maxIndex; i < lengthOfTheLongestIncreasingSubarray + maxIndex; i++)
            {
                if (i == ((lengthOfTheLongestIncreasingSubarray + maxIndex) - 1))
                    stringBuilder.Append(inputArray[i]);
                else
                    stringBuilder.Append(inputArray[i] + " ");
            }
            return stringBuilder;
        }
    }
}
