using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class FullName
    {
        public string Name;


        public FullName(string nameInfo)
        {
            Name = nameInfo;
        }

        public string GetLastName()
        {
            return Name.Trim().Split().Last();
        }

        public string[] GetNameArray()
        {
            return Name.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
        }

        public string GetName()
        {
            return Name;
        }
    }
}
