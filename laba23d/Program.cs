using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba23d
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            a *= a; // a² (1)
            a *= a; // a⁴ (2)
            a *= a; // a⁸ (3)
            Console.WriteLine($"a⁸ = {a}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
