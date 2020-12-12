using System.Collections.Generic;

namespace Problem001
{
    public static class Problem001
    {
        #region Primary Method

        /// <summary>
        ///     <para>Difficulty Rating: EASY</para>
        ///     <para>Good morning! Here's your coding interview problem for today.</para>
        ///     <para>This problem was recently asked by Google.</para>
        ///     <para>Given a list of numbers and a number k, return whether any two numbers from the list add up to k.</para>
        ///     <para>For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.</para>
        ///     <para>Bonus: Can you do this in one pass?</para>
        /// </summary>
        /// <param name="list">The list of numbers to check</param>
        /// <param name="k">The target sum</param>
        /// <returns></returns>
        public static bool SolveProblem(List<int> list, int k)
        {
            return BonusSolution(list, k);
        }

        #endregion Primary Method

        #region Solution Methods

        /// <summary>
        ///     <para>
        ///         Loops through <paramref name="list"/> once, checking a 
        ///         HashSet for any values that add to the current index to 
        ///         equal <paramref name="k"/>. Returns true if found. If not,
        ///         the current value is added to the HashSet. If done looping,
        ///         return false.
        ///     </para>
        ///     <para>Time Complexity: O(n)</para>
        ///     <para>Space Complexity: O(n)</para>
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns>
        ///     <list type="bullet">
        ///         <item>true if two values in <paramref name="list"/> add up to <paramref name="k"/></item>
        ///         <item>false otherwise</item>
        ///     </list>
        /// </returns>
        private static bool BonusSolution(List<int> list, int k)
        {
            // Return false if list not valid for problem
            if (!IsValidList(list)) { return false; }

            // Create HashSet to track values seen
            HashSet<int> seen = new HashSet<int>();

            // Loop through list input
            for (int i=0; i<list.Count; i++)
            {
                // Check if any values seen add to this value to equal k
                if (seen.Contains(k - list[i]))
                    return true;

                seen.Add(list[i]);
            }

            return false;
        }

        /// <summary>
        ///     <para>
        ///         Sorts <paramref name="list"/> and creates indexes i and j 
        ///         at the start and end respectively. While the indexes are 
        ///         not equal, checks the sum of the values at each index. 
        ///         <list type="bullet">
        ///             <item>If the sum is less than <paramref name="k"/>, increment i.</item>
        ///             <item>If the sum is greater than <paramref name="k"/>, decrement j.</item>
        ///             <item>If equal, return true.</item>
        ///         </list>
        ///         Once all indexes have been checked,
        ///         return false.
        ///     </para>
        ///     <para>Time Complexity: O(nlogn)</para>
        ///     <para>Space Complexity: O(1)</para>
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns>
        ///     <list type="bullet">
        ///         <item>true if two values in <paramref name="list"/> add up to <paramref name="k"/></item>
        ///         <item>false otherwise</item>
        ///     </list>
        /// </returns>
        private static bool BetterTimeComplexity(List<int> list, int k)
        {
            // Return false if list not valid for problem
            if (!IsValidList(list)) { return false; }

            // Sort list
            list.Sort();

            // Setup for algorithm
            int i = 0;
            int j = list.Count - 1;
            int sum;
            
            // Check each value in list
            while (i < j)
            {
                // Get sum
                sum = list[i] + list[j];

                // Check for sum or next action
                if (sum == k)
                    return true;
                else if (sum < k)
                    i++;
                else
                    j--;
            }

            // Return false if not found
            return false;
        }

        /// <summary>
        ///     <para>
        ///         Sets two indexes, i and j, where i = 0 and 
        ///         j = i + 1. Then, checks sum of values in
        ///         <paramref name="list"/> at i and j. If equal,
        ///         return true. Otherwise, increment j to the end
        ///         of <paramref name="list"/>. Then increment i and
        ///         reset j to i + 1. Repeat until all values are 
        ///         checked. If target sum <paramref name="k"/> never 
        ///         met, return false.
        ///     </para>
        ///     <para>Time Complexity: O(n^2)</para>
        ///     <para>Space Complexity: O(1)</para>
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns>
        ///     <list type="bullet">
        ///         <item>true if two values in <paramref name="list"/> add up to <paramref name="k"/></item>
        ///         <item>false otherwise</item>
        ///     </list>
        /// </returns>
        private static bool BruteForce(List<int> list, int k)
        {
            // Return false if list not valid for problem
            if (!IsValidList(list)) { return false; }

            // Check each value in list
            for (int i=0; i<list.Count-1; i++)
            {
                for (int j=i+1; j<list.Count; j++)
                {
                    // If sum found, return true
                    if (list[i] + list[j] == k)
                    {
                        return true;
                    }
                }
            }

            // Return false if not found
            return false;
        }

        #endregion Solution Methods

        #region Helper Methods

        /// <summary>
        ///     <para>
        ///         Checks if <paramref name="list"/> is valid for the problem.
        ///     </para>
        /// </summary>
        /// <param name="list"></param>
        /// <returns>
        ///     <list type="bullet">
        ///         <item>false if list is null</item>
        ///         <item>false if list does not contain at least two values</item>
        ///         <item>true otherwise</item>
        ///     </list>
        /// </returns>
        private static bool IsValidList(List<int> list)
        {
            return (list != null && list.Count > 1);
        }

        #endregion Helper Methods
    }
}
