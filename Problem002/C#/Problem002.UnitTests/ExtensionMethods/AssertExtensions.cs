using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Problem002.UnitTests.ExtensionMethods
{
    public static class AssertExtensions
    {
        #region Error Constants

        private const string ARRAYS_DIFFERENT_LENGTH_ERROR = "Array {0} and array {1} are of different lengths.";
        private const string ARRAYS_DIFFER_AT_INDEX_ERROR = "Array {0} and array {1} are not equal at index {2}.\n"
            + "\t{0}[{2}] = {3}\n"
            + "\t{1}[{2}] = {4}";

        #endregion Error Constants

        #region Extension Methods

        /// <summary>
        ///     <para>
        ///         Determines if two arrays are equal by comparing lengths
        ///         and the value of each item in both arrays
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Any type that implements IComparable</typeparam>
        /// <param name="array1">the first array to compare</param>
        /// <param name="array2">the second array to compare</param>
        /// <exception cref="OverflowException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="AssertFailedException"></exception>
        public static void ArraysAreEqual<T>(this Assert assert, T[] array1, T[] array2) where T : IComparable<T>
        {
            // Assert that two arrays are same length
            if (array1.Length != array2.Length)
            {
                Assert.Fail(string.Format(ARRAYS_DIFFERENT_LENGTH_ERROR, nameof(array1), nameof(array2)));
            }

            // Assert that each value in two arrays are equal
            for (int i = 0; i < array1.Length; i++)
            {
                if (!array1[i].Equals(array2[i]))
                {
                    Assert.Fail(string.Format(ARRAYS_DIFFER_AT_INDEX_ERROR, 
                        nameof(array1), 
                        nameof(array2),
                        i, 
                        array1[i], 
                        array2[i]));
                }
            }
        }

        #endregion Extension Methods
    }
}
