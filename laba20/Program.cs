using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba20
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите внешний радиус R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите внутренний радиус r: ");
            double r = double.Parse(Console.ReadLine());
            double S = Math.PI * (R * R - r * r);
            Console.WriteLine($"Площадь кольца: {S}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
