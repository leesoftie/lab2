using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num} — вот какое число Вы ввели");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
