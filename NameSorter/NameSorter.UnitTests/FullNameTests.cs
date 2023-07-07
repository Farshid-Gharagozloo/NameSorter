using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class FullNameTests
    {
        [TestMethod]
        public void GetFullName_OneNameList_ExpectedList()
        {
            List<NameArrays> list = new List<NameArrays>();
            list.Add(new NameArrays("farshid"));
            list.Add(new NameArrays("Hunter Uriah Mathew Clarke"));
            list.Add(new NameArrays("  "));
            list.Add(new NameArrays("Mikayla Lopez"));


            List<string> expected = new List<string>();
            expected.Add("farshid");
            expected.Add("Hunter Uriah Mathew Clarke");
            expected.Add("Mikayla Lopez");

            List<string> result = FullName.GetFullName(list);

            CollectionAssert.AreEqual(expected, result);
        }

    }
}
