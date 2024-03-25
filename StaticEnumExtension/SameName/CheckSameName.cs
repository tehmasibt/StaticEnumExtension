using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEnumExtension.SameName
{
    internal static class CheckSameName
    {
        public static void SameN(this string word)
        {
            int count = 0;  
            foreach (var item in word.Split(' '))
            {
                if (item == "code")
                {
                    count++;
                }               
            }
            Console.WriteLine(count);
        }
    }
}
