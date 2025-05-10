using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Блокировщик
{
    public class Creater
    {
        public static string getNewString()
        {
            Random random = new Random();
            int length = random.Next(5, 30);
            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                int charChoice = random.Next(0, 3);
                switch (charChoice)
                {
                    case 0: chars[i] = 'A'; break;
                    case 1: chars[i] = 'C'; break;
                    case 2: chars[i] = '_'; break;
                    default: break;
                }
            }
            return new string(chars);
        }
    }
}
