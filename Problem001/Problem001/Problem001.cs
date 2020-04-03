using System.Collections.Generic;

namespace Problem001
{
    public static class Problem001
    {
        /// <summary>
        /// Good morning! Here's your coding interview problem for today.
        ///
        /// This problem was recently asked by Google.
        ///
        /// Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
        ///
        /// For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
        ///
        /// Bonus: Can you do this in one pass?
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool SolveProblem(List<int> list, int k)
        {
            return BruteForce(list, k);
        }

        /// <summary>
        /// Time Complexity: O(n^2)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool BruteForce(List<int> list, int k)
        {
            for (int i=0; i<list.Count-1; i++)
            {
                for (int j=i+1; j<list.Count; j++)
                {
                    if (list[i] + list[j] == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
