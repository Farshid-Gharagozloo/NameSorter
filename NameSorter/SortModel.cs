using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortModel
    {
        public static int Sorting(string a, string b)
        {
            if (a == null)
            {
                if (b == null)
                {             // If a and b is null then they are equal
                    return 0;
                }
                else
                {             // If a is null but y is not null then b is greater.
                    return -1;
                }
            }
            else
            {
                if (b == null)
                {
                    return 1;
                }
                else
                {             // If the strings are not null, sort them with string comparison
                    return a.CompareTo(b);
                }
            }
        }
    }
}
