using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameArrays
    {
        public string LastName;
        public string[] OtherPartsOfName;
        public NameArrays(string textNames)
        {
            string[] givenNames = textNames.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            

            if (givenNames.Length == 0)
            {
                LastName = null;
                OtherPartsOfName = Array.Empty<string>();
            }
            else if (givenNames.Length == 1)
            {
                LastName = givenNames[0];
                OtherPartsOfName = Array.Empty<string>();
            }
            else
            {
                for (int i = 0; i < givenNames.Length; i++)
                {
                     givenNames[i] = givenNames[i].Trim();
                }

                LastName = givenNames.AsQueryable().Last();
                OtherPartsOfName = givenNames.Reverse().Skip(1).Reverse().ToArray();
            }
        }

        public bool Equals(NameArrays nameObject)
        {
            if ( (this.LastName == nameObject.LastName) && (this.OtherPartsOfName.SequenceEqual(nameObject.OtherPartsOfName)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
