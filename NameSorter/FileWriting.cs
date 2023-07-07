using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class FileWriting
    {
        public static void WritingNames(string filePath, List<string> nameList)
        {
            StreamWriter sw = new StreamWriter(filePath);

            foreach (string name in nameList)
            {
                sw.WriteLine(name);
            }
            sw.Close();
        }
    }
}
