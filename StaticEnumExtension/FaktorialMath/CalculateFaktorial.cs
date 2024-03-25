using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticEnumExtension.FaktorialMath
{
    internal static class CalculateFaktorial
    {
        public static int Faktorial(this int x)
        {
            int mult = 1;
            for (int i = 1; i <= x; i++)
            {
                mult *= i;
            }
            return mult;
        }
    }
}
