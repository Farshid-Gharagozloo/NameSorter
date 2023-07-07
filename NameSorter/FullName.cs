using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class FullName
    {

        public static List<string> GetFullName (List<NameArrays> names)
        {
            List<string> fullName= new List<string>();
            foreach (NameArrays name in names)
            {
                if ((name.OtherPartsOfName.Length == 0) && (name.LastName != null))
                {
                    fullName.Add( name.LastName );
                }
                else if (name.LastName != null)
                {
                    fullName.Add( string.Join (" ", name.OtherPartsOfName) + " " + name.LastName );
                }
            }

            return fullName;
        }

    }
}
