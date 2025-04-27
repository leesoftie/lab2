using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba14
{
    class Program
    {
        static void Main()
        {
            float z;
            int a = 1, b = 2, c = 3;
            const int m = 3;
            z = (a + b + c) / (float)m;
            Console.WriteLine($"Результат: {z}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}