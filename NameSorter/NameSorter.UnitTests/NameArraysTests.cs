using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class NameArraysTests
    {
        [TestMethod]
        public void ConstructorLastName_NoName_Null()
        {
            NameArrays name = new NameArrays("   ");
            string expectedLastName = null;
            string result = name.LastName;
            Assert.AreEqual(expectedLastName, result);
        }

        [TestMethod]
        public void ConstructorLastName_OneName_Janet()
        {
            NameArrays name = new NameArrays("Janet");
            string expectedLastName = "Janet";
            string result = name.LastName;
            Assert.AreEqual(expectedLastName, result);
        }

        [TestMethod]
        public void ConstructorLastName_ThreeGivenName_return1()
        {
            NameArrays name = new NameArrays("Clarke Julius Archer");
            string expectedLastName = "Archer";
            string result = name.LastName;
            Assert.AreEqual(expectedLastName, result);
        }

        [TestMethod]
        public void ConstructorLastName_OneNameWithSpaces_Janet()
        {
            NameArrays name = new NameArrays("   Janet   ");
            string expectedLastName = "Janet";
            string result = name.LastName;
            Assert.AreEqual(expectedLastName, result);
        }

        [TestMethod]
        public void ConstructorOPON_NoName_0()
        {
            NameArrays name = new NameArrays("  ");
            string[] expectedLastName = Array.Empty<string>();
            string[] result = name.OtherPartsOfName;
            Assert.AreEqual(expectedLastName, result);
        }

        [TestMethod]
        public void ConstructorOPON_OneName_0()
        {
            NameArrays name = new NameArrays("Julius");
            string[] expectedLastName = Array.Empty<string>();
            string[] result = name.OtherPartsOfName;
            Assert.AreEqual(expectedLastName, result);
        }

        [TestMethod]
        public void ConstructorOPON_ThreeNames_FrankieConner()
        {
            NameArrays name = new NameArrays("Frankie Conner Ritter");
            string[] expectedLastName = { "Frankie", "Conner" };
            string[] result = name.OtherPartsOfName;
            CollectionAssert.AreEqual(expectedLastName, result);
        }

        public void ConstructorOPON_ThreeNamesWithSpaces_ShelbyNathan()
        {
            NameArrays name = new NameArrays("  Shelby   Nathan    Yoder");
            string[] expectedLastName = { "Shelby", "Nathan" };
            string[] result = name.OtherPartsOfName;
            CollectionAssert.AreEqual(expectedLastName, result);
        }

    }
}
