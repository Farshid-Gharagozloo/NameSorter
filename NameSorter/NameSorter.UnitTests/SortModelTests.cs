using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class SortModelTests
    {
        [TestMethod]
        public void SortingModel_TwoName_return1()
        {
            string inputName_a = "Clarke";
            string inputName_b = "Bentley";
            int result = SortModel.Sorting(inputName_a, inputName_b);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SortingModel_TwoName_returnMinus1()
        {
            string inputName_a = "Bentley";
            string inputName_b = "Clarke";
            int result = SortModel.Sorting(inputName_a, inputName_b);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SortingModel_FirstNullSecondNotNull_returnMinus1()
        {
            string inputName_a = null;
            string inputName_b = "Clarke";
            int result = SortModel.Sorting(inputName_a, inputName_b);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SortingModel_FirstNotNullSecondNull_return1()
        {
            string inputName_a = "Farshid";
            string inputName_b = null;
            int result = SortModel.Sorting(inputName_a, inputName_b);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SortingModel_TwoNull_return0()
        {
            string inputName_a = null;
            string inputName_b = null;
            int result = SortModel.Sorting(inputName_a, inputName_b);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SortingModel_SameName_return0()
        {
            string inputName_a = "Shelby";
            string inputName_b = "Shelby";
            int result = SortModel.Sorting(inputName_a, inputName_b);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SortingModel_FirstEmpthyName_returnMinus1()
        {
            string inputName_a = "";
            string inputName_b = "Shelby";
            int result = SortModel.Sorting(inputName_a, inputName_b);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SortingModel_SecondEmpthyName_return1()
        {
            string inputName_a = "Shelby";
            string inputName_b = "";
            int result = SortModel.Sorting(inputName_a, inputName_b);
            Assert.AreEqual(1, result);
        }
    }
}
