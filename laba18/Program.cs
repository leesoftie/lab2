using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba18
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите e: ");
            double e = double.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * (c - e);
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
