using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class SortModelTests
    {
        [TestMethod]
        public void SortingModel_TwoNameslist_true()
        {
            List<NameArrays> names = new List<NameArrays>();
            names.Add(new NameArrays("Leo Gardner"));
            names.Add(new NameArrays("Janet Parsons"));

            List<NameArrays> expected = new List<NameArrays>();
            expected.Add(new NameArrays("Leo Gardner"));
            expected.Add(new NameArrays("Janet Parsons"));

            List<NameArrays> actual = SortModel.SortingNames(names);
            

            bool result = true;

            for (int i = 0; i < names.Count; i++)
            {
                if ( !expected[i].Equals(actual[i]) )
                {
                    result = false;
                }
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SortingModel_fourNameslist_true()
        {
            List<NameArrays> names = new List<NameArrays>();
            names.Add(new NameArrays("Leo Gardner"));
            names.Add(new NameArrays("Hunter Uriah Mathew Clarke"));
            names.Add(new NameArrays("Frankie Conner Ritter"));
            names.Add(new NameArrays("Archer"));


            List<NameArrays> expected = new List<NameArrays>();
            expected.Add(new NameArrays("Archer"));
            expected.Add(new NameArrays("Hunter Uriah Mathew Clarke"));
            expected.Add(new NameArrays("Leo Gardner"));
            expected.Add(new NameArrays("Frankie Conner Ritter"));


            List<NameArrays> actual = SortModel.SortingNames(names);


            bool result = true;

            for (int i = 0; i < names.Count; i++)
            {
                if (!expected[i].Equals(actual[i]))
                {
                    result = false;
                }
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SortingModel_SimilarNames_true()
        {
            List<NameArrays> names = new List<NameArrays>();
            names.Add(new NameArrays("London Lindsey"));
            names.Add(new NameArrays("London Janet Lindsey"));
            names.Add(new NameArrays("Marin Alvarez"));
            names.Add(new NameArrays("Hunter Marin Alvarez"));
            names.Add(new NameArrays("Janet Parsons"));
            names.Add(new NameArrays("Janet Parsons"));



            List<NameArrays> expected = new List<NameArrays>();
            expected.Add(new NameArrays("Hunter Marin Alvarez"));
            expected.Add(new NameArrays("Marin Alvarez"));
            expected.Add(new NameArrays("London Lindsey"));
            expected.Add(new NameArrays("London Janet Lindsey"));
            expected.Add(new NameArrays("Janet Parsons"));
            expected.Add(new NameArrays("Janet Parsons"));


            List<NameArrays> actual = SortModel.SortingNames(names);


            bool result = true;

            for (int i = 0; i < names.Count; i++)
            {
                if (!expected[i].Equals(actual[i]))
                {
                    result = false;
                }
            }
            Assert.IsTrue(result);
        }

    }
}
