using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class SortByLastNameTests
    {
        [TestMethod]
        public void SortingModel_ThreeNamesVsThreeNames_return1()
        {
            FullName name_a = new FullName("Shelby Nathan Yoder");
            FullName name_b = new FullName("Adonis Julius Archer");
            int result = SortByLastName.LastNameSorting(name_a, name_b);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SortingModel_OneNamesVsThreeNames_return1()
        {
            FullName name_a = new FullName("Yoder");
            FullName name_b = new FullName("Adonis Julius Archer");
            int result = SortByLastName.LastNameSorting(name_a, name_b);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SortingModel_SameLastNames_returnMinus1()
        {
            FullName name_a = new FullName("Leo Lopez");
            FullName name_b = new FullName("Mikayla Lopez");
            int result = SortByLastName.LastNameSorting(name_a, name_b);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SortingModel_SameNames_return0()
        {
            FullName name_a = new FullName("Leo Gardner");
            FullName name_b = new FullName("Leo Gardner");
            int result = SortByLastName.LastNameSorting(name_a, name_b);
            Assert.AreEqual(0, result);
        }
   
    }
}
