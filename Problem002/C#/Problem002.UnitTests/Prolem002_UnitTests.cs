using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem002.UnitTests.ExtensionMethods;

namespace Problem002.UnitTests
{
    [TestClass]
    public class Prolem002_UnitTests
    {
        [TestMethod]
        public void SampleTest1()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expectedNewArray = { 120, 60, 40, 30, 24 };

            int[] actualArray = Problem002.SolveProblem(array);

            Assert.That.ArraysAreEqual(expectedNewArray, actualArray);
        }

        [TestMethod]
        public void SampleTest2()
        {
            int[] array = { 3, 2, 1 };
            int[] expectedNewArray = { 2, 3, 6 };

            int[] actualArray = Problem002.SolveProblem(array);

            Assert.That.ArraysAreEqual(expectedNewArray, actualArray);
        }
    }
}
