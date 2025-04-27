using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba23g
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            int temp = a * a; // a² (1)
            temp *= temp;     // a⁴ (2)
            temp *= temp;     // a⁸ (3)
            temp *= a * a;   // a¹⁰ (4)
            Console.WriteLine($"a¹⁰ = {temp}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
