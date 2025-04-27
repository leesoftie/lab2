using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba25f
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            a = 3; b = 2; c = 1;
            double z = (a * b + c++) - (a * b * --c); // 6 + 1 - 12 = -5 (не -4) достичь результата -4 при a = b = c = 2 невозможно.
            Console.WriteLine(z); 
        }
    }
}
