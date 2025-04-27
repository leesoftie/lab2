using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba25c
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            a = 3; b = 1; c = 1;
            double z = (a * b) + (c++ / b) - (a * b * --c); // 3 + 1 - 3 = 1 (не 2) достичь результата 2 при a = b = c = 2 невозможно.
            Console.WriteLine(z);
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
