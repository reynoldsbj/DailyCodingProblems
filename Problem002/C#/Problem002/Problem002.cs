namespace Problem002
{
    public static class Problem002
    {
        /// <summary>   
        ///     <para>Difficulty Rating: HARD</para>
        ///     <para>Good morning! Here's your coding interview problem for today.</para>
        ///     <para>This problem was asked by Uber.</para>
        ///     <para>
        ///         Given an array of integers, return a new array such that each element at 
        ///         index i of the new array is the product of all the numbers in the original 
        ///         array except the one at i.
        ///     </para>
        ///     <para>
        ///         For example, if our input was [1, 2, 3, 4, 5], the expected output would 
        ///         be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output 
        ///         would be [2, 3, 6].
        ///     </para>
        ///     <para>Follow-up: what if you can't use division?</para>
        /// </summary>
        public static int[] SolveProblem(int[] array)
        {
            return FasterSolution(array);
        }

        /// <summary>
        ///     <para>
        ///         Gets the product of all of the values in 
        ///         <paramref name="array"/>. Then, loops
        ///         through the original <paramref name="array"/>
        ///         and divides the value at each index from the
        ///         product to get the values for the new array.
        ///     </para>
        ///     <para>Time Complexity: O(n)</para>
        ///     <para>Space Complexity: O(n)</para>
        /// </summary>
        /// <param name="array">The array to process</param>
        /// <returns>
        ///     A new array such that each element at index i 
        ///     is the product of all the values in the original 
        ///     <paramref name="array"/> except the value at index
        ///     i in the original <paramref name="array"/>
        /// </returns>
        public static int[] FasterSolution(int[] array)
        {
            // Create a new array of the same length
            int[] newArray = new int[array.Length];

            // Get the product of all values in the original array
            int product = 1;
            for (int i=0; i<array.Length; i++)
            {
                product *= array[i];
            }
            
            /**
             * Set the value of each index in the new array 
             * to the product of all values in the original 
             * divided by the value at the same index 
             */
            for (int i=0; i<array.Length; i++)
            {
                newArray[i] = product / array[i];
            }

            // Return the new array
            return newArray;
        }

        /// <summary>
        ///     <para>
        ///         For each value in the original array, loops
        ///         through the <paramref name="array"/> and 
        ///         multiplies all of the values of the
        ///         <paramref name="array"/> except the value at
        ///         that index to get all of the values for the new
        ///         array.
        ///     </para>
        ///     <para>Time Complexity: O(n^2)</para>
        ///     <para>Space Complexity: O(n)</para>
        /// </summary>
        /// <param name="array">The array to process</param>
        /// <returns>
        ///     A new array such that each element at index i 
        ///     is the product of all the values in the original 
        ///     <paramref name="array"/> except the value at index
        ///     i in the original <paramref name="array"/>
        /// </returns>
        public static int[] BruteForce(int[] array)
        {
            // Create a new array of the same length
            int[] newArray = new int[array.Length];

            // Declare product
            int product;

            // Loop through each value in original array
            for (int i=0; i<array.Length; i++)
            {
                // Reset product
                product = 1;

                // Loop through each value in original array
                for (int j=0; j<array.Length; j++)
                {
                    // Skip if the index is the one currently being calculated
                    if (j != i)
                    {
                        // Multiply into product
                        product *= array[j];
                    }
                }

                // Get value for index
                newArray[i] = product;
            }

            // Return the new array
            return newArray;
        }
    }
}
