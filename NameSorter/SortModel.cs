using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortModel
    {

        public static List<NameArrays> SortingNames (List<NameArrays> names) 
        {
            List<NameArrays> sortedList = names.OrderBy(name => name.LastName).ThenBy(name => name.OtherPartsOfName?.FirstOrDefault())
                 .ThenBy(name => name.OtherPartsOfName?.ElementAtOrDefault(1)).ToList();
            return sortedList;
        }
    }
}
