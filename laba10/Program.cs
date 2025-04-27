using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {num}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
