using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class ShowingFile
    {
        public static void ShowSortedNames(List<string> sortedNameList) 
        {
            foreach (string name in sortedNameList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
