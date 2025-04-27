using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba23c
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            a *= a; // a²
            a *= a; // a⁴
            a *= a; // a⁸
            a /= a; // a⁷ (если исходное a ≠ 0)
            Console.WriteLine($"a⁴ = {a}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}