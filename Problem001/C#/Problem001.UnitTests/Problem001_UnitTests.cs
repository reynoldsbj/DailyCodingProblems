using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Problem001.UnitTests
{
    [TestClass]
    public class Problem001_UnitTests
    {
        #region Test Categories

        private const string VALIDATION_TESTS = "Validation Tests";
        private const string STANDARD_TESTS = "Standard Tests";

        #endregion Test Categories

        #region Validation Tests

        [TestMethod]
        [TestCategory(VALIDATION_TESTS)]
        public void NullList()
        {
            List<int> list = null;
            int k = 0;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        [TestCategory(VALIDATION_TESTS)]
        public void EmptyList()
        {
            List<int> list = new List<int>();
            int k = 0;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }


        [TestMethod]
        [TestCategory(VALIDATION_TESTS)]
        public void SingleItemList()
        {
            List<int> list = new List<int>() { 1 };
            int k = 1;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }

        #endregion Validation Tests

        #region Standard Tests

        [TestMethod]
        [TestCategory(STANDARD_TESTS)]
        public void SampleTest()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 17;

            Assert.IsTrue(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        [TestCategory(STANDARD_TESTS)]
        public void NoTwoNumbersAddUpToK()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 30;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        [TestCategory(STANDARD_TESTS)]
        public void OneNumberEqualsKButNoTwoNumbersAddUpToK()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 15;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        [TestCategory(STANDARD_TESTS)]
        public void ThreeNumbersAddUpToKButNoTwoNumbersAddUpToK()
        {
            List<int> list = new List<int>() { 10, 15, 3, 7 };
            int k = 20;

            Assert.IsFalse(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        [TestCategory(STANDARD_TESTS)]
        public void MoreThanOneSetThatAddsUpToK()
        {
            List<int> list = new List<int>() { 6, 4, 3, 7 };
            int k = 10;

            Assert.IsTrue(Problem001.SolveProblem(list, k));
        }

        [TestMethod]
        [TestCategory(STANDARD_TESTS)]
        public void TwoOfSameNumberThatAddUpToK()
        {
            List<int> list = new List<int>() { 5, 5 };
            int k = 10;

            Assert.IsTrue(Problem001.SolveProblem(list, k));
        }

        #endregion Standard Tests
    }
}
