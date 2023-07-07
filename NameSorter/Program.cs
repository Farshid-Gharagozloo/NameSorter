using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readingPath = @"../../data/unsorted-names-list.txt";
            string writingPath = @"../../data/sorted-names-list.txt";

            SortClass.SortingProcess(readingPath, writingPath);

        }
    }
}
