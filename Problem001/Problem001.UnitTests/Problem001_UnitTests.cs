using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Problem001.UnitTests
{
    [TestClass]
    public class Problem001_UnitTests
    {
        [TestMethod]
        public void SampleTest()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 17;

            Assert.IsTrue(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        public void NoTwoNumbersAddUpToK()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 30;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        public void OneNumberEqualsKButNoTwoNumbersAddUpToK()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 15;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        public void ThreeNumbersAddUpToKButNoTwoNumbersAddUpToK()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 20;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        public void MoreThanOneSetThatAddsUpToK()
        {
            List<int> list = new List<int>() { 6, 4, 3, 7 };
            int k = 10;

            Assert.IsTrue(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        public void TwoOfSameNumberThatAddUpToK()
        {
            List<int> list = new List<int>() { 5, 5 };
            int k = 10;

            Assert.IsTrue(Problem001.SolveProblem(list, k));
        }
    }
}
