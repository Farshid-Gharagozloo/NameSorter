using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortClass
    {
        public static void SortingProcess(string readFilePath, string writeFilePath)
        {
            List<NameArrays> sortedList = new List<NameArrays>();
            List<string> nameList = new List<string>();

            sortedList = SortModel.SortingNames(FileReading.ReadingNames(readFilePath));

            nameList = FullName.GetFullName(sortedList);

            FileWriting.WritingNames(writeFilePath, nameList);

            ShowingFile.ShowSortedNames(nameList);
        }
    }
}
