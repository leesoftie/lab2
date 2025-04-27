using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba22
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = double.Parse(Console.ReadLine());
            double avg = (Math.Abs(x) + Math.Abs(y)) / 2;
            double geom = Math.Sqrt(Math.Abs(x) * Math.Abs(y));
            Console.WriteLine($"Среднее арифметическое: {avg}");
            Console.WriteLine($"Среднее геометрическое: {geom}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
