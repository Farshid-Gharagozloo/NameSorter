using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortByLastName
    {
        public static int LastNameSorting(FullName a, FullName b)
        {
            string lastName_a = a.GetLastName();
            string lastName_b = b.GetLastName();

            if (lastName_a == lastName_b)
            {
                return SortByFullName.Sorting(a, b);
            }

            else
            {
                return SortModel.Sorting(lastName_a, lastName_b);
            }
        }
    }
}
