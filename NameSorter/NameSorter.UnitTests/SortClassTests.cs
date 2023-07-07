using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class SortClassTests
    {
        public bool FileCompare (string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            if (file1 == file2)
            {
                return true;
            }

            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            if (fs1.Length != fs2.Length)
            {
                fs1.Close();
                fs2.Close();

                return false;
            }

            do
            {
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            fs1.Close();
            fs2.Close();

            return ((file1byte - file2byte) == 0);
        }

        [TestMethod]
        public void SortingModel_TestOne_test1_output()
        {
            string inputs = @"../../../TestFiles/test1/inputs.txt";
            string expected = @"../../../TestFiles/test1/expected.txt";
            string output = @"../../../TestFiles/test1/output.txt";
            SortClass.SortingProcess(inputs, output);

            bool result = FileCompare(expected, output);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SortingModel_TestTwo_test2_output()
        {
            string inputs = @"../../../TestFiles/test2/inputs.txt";
            string expected = @"../../../TestFiles/test2/expected.txt";
            string output = @"../../../TestFiles/test2/output.txt";
            SortClass.SortingProcess(inputs, output);

            bool result = FileCompare(expected, output);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SortingModel_TestThree_test3_output()
        {
            string inputs = @"../../../TestFiles/test3/inputs.txt";
            string expected = @"../../../TestFiles/test3/expected.txt";
            string output = @"../../../TestFiles/test3/output.txt";
            SortClass.SortingProcess(inputs, output);

            bool result = FileCompare(expected, output);
            Assert.IsTrue(result);
        }

    }


}
