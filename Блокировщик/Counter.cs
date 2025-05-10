using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Блокировщик
{
    public class Counter
    {
       public static int countSym(string L)
        {
            int count = 0;
            foreach (char c in L) if (c == '_') count++;
            return count;
        }
    }
}
