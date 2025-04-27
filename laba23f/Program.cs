using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba23f
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
            temp *= a;        // a⁹ (4)
            Console.WriteLine($"a⁹ = {temp}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
