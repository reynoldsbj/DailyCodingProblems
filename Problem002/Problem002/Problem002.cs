using System;

namespace Problem002
{
    public static class Problem002
    {
        /// <summary>
        /// Difficulty Rating: HARD
        /// Good morning! Here's your coding interview problem for today.
        ///
        /// This problem was asked by Uber.
        ///
        /// Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
        ///
        /// For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be[2, 3, 6].
        ///
        ///
        /// Follow-up: what if you can't use division?
        /// </summary>
        public static int[] SolveProblem(int[] array)
        {
            return BruteForce(array);
        }

        /// <summary>
        /// Time Complexity: O(n^2)
        /// Space Complexity: O(n)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] BruteForce(int[] array)
        {
            int[] newArray = new int[array.Length];

            int product;

            for (int i=0; i<array.Length; i++)
            {
                product = 1;

                for (int j=0; j<array.Length; j++)
                {
                    if (j != i)
                    {
                        product *= array[j];
                    }
                }

                newArray[i] = product;
            }

            return newArray;
        }
    }
}
