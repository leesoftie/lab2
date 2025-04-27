using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba15
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            double avg = (x + y) / 2.0;
            double geom = Math.Sqrt(Math.Abs(x) * Math.Abs(y));
            Console.WriteLine($"Среднее арифметическое: {avg}");
            Console.WriteLine($"Среднее геометрическое: {geom}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
