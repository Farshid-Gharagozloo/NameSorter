using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class SortByFullNameTests
    {
        [TestMethod]
        public void SortingModel_ThreeGivenName_return1()
        {
            FullName name_a = new FullName("Clarke Julius Archer");
            FullName name_b = new FullName("Bentley Alvarez Archer");
            int result = SortByFullName.Sorting(name_a, name_b);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SortingModel_ThreeGivenNamesVsTwoGivenNames_returnMinus1()
        {
            FullName name_a = new FullName("Clarke Julius Lopez");
            FullName name_b = new FullName("Mikayla Lopez");
            int result = SortByFullName.Sorting(name_a, name_b);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SortingModel_OneGivenNameVsThreeGivenNames_return1()
        {
            FullName name_a = new FullName("Lopez");
            FullName name_b = new FullName("Clarke Julius Lopez");
            int result = SortByFullName.Sorting(name_a, name_b);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SortingModel_TwoSameName_return0()
        {
            FullName name_a = new FullName("Clarke Julius Lopez");
            FullName name_b = new FullName("Clarke Julius Lopez");
            int result = SortByFullName.Sorting(name_a, name_b);
            Assert.AreEqual(0, result);
        }

    }
}
