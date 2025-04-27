using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba25a
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            a = b = c = 2;
            double z = (a * b) + (c++ / (double)(b - a * b * --c));
            Console.WriteLine(z); // 3.66
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
