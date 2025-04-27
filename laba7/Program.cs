using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class Program 
    {
        static void Main() 
        {
            Console.Write("Введите целое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа: {a * a}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
