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
            string file = @"../../data/unsorted-names-list.txt";
            List<FullName> nameList = new List<FullName>();

            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    nameList.Add(new FullName(line));
                }

                nameList.Sort(SortByLastName.LastNameSorting);

                try
                {
                    StreamWriter sw = new StreamWriter("../../data/sorted-names-list.txt");

                    foreach (FullName name in nameList)
                    {
                        sw.WriteLine(name.GetName());
                    }
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    foreach (FullName name in nameList)
                    {
                        Console.WriteLine(name.GetName());
                    }
                }

            }
        }
    }
}
