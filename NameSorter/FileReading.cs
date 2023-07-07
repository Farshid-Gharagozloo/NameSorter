using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class FileReading
    {
        
        public static List<NameArrays> ReadingNames (string filePath)
        {
            List<NameArrays> list = new List<NameArrays>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines (filePath);
                foreach (string line in lines)
                {
                    list.Add(new NameArrays(line));
                }
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
