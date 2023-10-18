using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLengthLibrary
{
    public delegate int FindLength(string s1);
    public class StringLength

    {
        public int CalculateStringLength(string s1)
        {
            if(s1 == null)
            {
                return 0;
            }
            else
            {
                return s1.Length;
            }
        }
    }
}
