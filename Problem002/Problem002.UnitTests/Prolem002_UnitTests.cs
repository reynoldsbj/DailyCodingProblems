using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem002.UnitTests
{
    [TestClass]
    public class Prolem002_UnitTests
    {
        /// <summary>
        /// Determines if two arrays are equal by comparing each item
        /// in both arrays
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        public void AssertArraysAreEqual<T>(T[] array1, T[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
                Assert.AreEqual(array1[i], array2[i]);

            for (int i = 0; i < array2.Length; i++)
                Assert.AreEqual(array2[i], array1[i]);
        }

        [TestMethod]
        public void SampleTest1()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expectedNewArray = { 120, 60, 40, 30, 24 };

            int[] actualArray = Problem002.SolveProblem(array);

            AssertArraysAreEqual<int>(expectedNewArray, actualArray);
        }

        [TestMethod]
        public void SampleTest2()
        {
            int[] array = { 3, 2, 1 };
            int[] expectedNewArray = { 2, 3, 6 };

            int[] actualArray = Problem002.SolveProblem(array);

            AssertArraysAreEqual<int>(expectedNewArray, actualArray);
        }
    }
}
