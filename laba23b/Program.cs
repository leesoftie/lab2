using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba23b
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            int temp = a * a; // a²
            a = temp * temp * temp; // a² * a² * a² = a⁶
            Console.WriteLine($"a⁴ = {a}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
