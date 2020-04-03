using System.Collections.Generic;

namespace Problem001
{
    public static class Problem001
    {
        /// <summary>
        /// Difficulty Rating: EASY
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
            return BonusSolution(list, k);
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(n)
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool BonusSolution(List<int> list, int k)
        {
            HashSet<int> seen = new HashSet<int>();

            for (int i=0; i<list.Count; i++)
            {
                if (seen.Contains(k - list[i]))
                    return true;

                seen.Add(list[i]);
            }

            return false;
        }

        /// <summary>
        /// Time Complexity: O(nlogn)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool BetterTimeComplexity(List<int> list, int k)
        {
            list.Sort();

            int i = 0;
            int j = list.Count - 1;
            int sum;
            
            while (i < j)
            {
                sum = list[i] + list[j];

                if (sum == k)
                    return true;
                else if (sum < k)
                    i++;
                else
                    j--;
            }

            return false;
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
