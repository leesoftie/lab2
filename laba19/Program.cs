using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba19
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите катет a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите катет b: ");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Гипотенуза: {c}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
