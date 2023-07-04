using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class FullNameTests
    {
        [TestMethod]
        public void GetLastName_OneGivenName_Farshid()
        {
            FullName name = new FullName("Farshid");
            string result = name.GetLastName();
            Assert.AreEqual("Farshid", result);
        }

        [TestMethod]
        public void GetLastName_TwoGivenNameWithSpaces_MarinAlvarez()
        {
            FullName name = new FullName("    Marin Alvarez   ");
            string result = name.GetLastName();
            Assert.AreEqual("Alvarez", result);
        }

        [TestMethod]
        public void GetLastName_NoGivenName_empthy()
        {
            FullName name = new FullName("");
            string result = name.GetLastName();
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void GetLastName_ThreeGivenName_Bentley()
        {
            FullName name = new FullName("Beau Tristan Bentley");
            string result = name.GetLastName();
            Assert.AreEqual("Bentley", result);
        }

        [TestMethod]
        public void GetNameArray_FourGivenName_HunterUriahMathewClarke()
        {
            FullName name = new FullName("Hunter Uriah Mathew Clarke");
            string[] result = name.GetNameArray();
            string[] nameArray = new string[4] { "Hunter", "Uriah", "Mathew", "Clarke" };
            Console.WriteLine(result);
            CollectionAssert.AreEqual(nameArray, result);
        }

        [TestMethod]
        public void GetNameArray_OneGivenName_London()
        {
            FullName name = new FullName("London");
            string[] result = name.GetNameArray();
            string[] nameArray = new string[1] { "London" };
            Console.WriteLine(result);
            CollectionAssert.AreEqual(nameArray, result);
        }

        [TestMethod]
        public void GetNameArray_ThreeGivenNamewithThreeSpace_AdonisJuliusArcher()
        {
            FullName name = new FullName("Adonis   Julius   Archer");
            string[] result = name.GetNameArray();
            string[] nameArray = new string[3] { "Adonis", "Julius", "Archer" };
            Console.WriteLine(result);
            CollectionAssert.AreEqual(nameArray, result);
        }

        [TestMethod]
        public void GetName_TwoGivenName_MarinAlvarez()
        {
            FullName name = new FullName("Marin Alvarez");
            string result = name.GetName();
            Assert.AreEqual("Marin Alvarez", result);
        }

        [TestMethod]
        public void GetName_NoGivenName_space()
        {
            FullName name = new FullName(" ");
            string result = name.GetName();
            Assert.AreEqual(" ", result);
        }

    }
}
