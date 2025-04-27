using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba24
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите четырёхзначное число: ");
            int num = int.Parse(Console.ReadLine());
            int d1 = num / 1000;
            int d2 = (num / 100) % 10;
            int d3 = (num / 10) % 10;
            int d4 = num % 10;
            Console.WriteLine($"Сумма: {d1 + d2 + d3 + d4}");
            Console.WriteLine($"Произведение: {d1 * d2 * d3 * d4}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
