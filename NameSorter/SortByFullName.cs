using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortByFullName
    {
        public static int Sorting(FullName x, FullName y)
        {
            string[] x_name = x.GetNameArray();
            string[] y_name = y.GetNameArray();

            for (int i = 0; i < x_name.Length; i++)
            {
                int result = SortModel.Sorting(x_name[i], y_name[i]);
                if (result != 0)
                    return result;
            }

            return 0;
        }
    }
}
