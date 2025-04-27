using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.WriteLine($"Случайное число: {rnd.Next(a, b)}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine(); 
        }
    }
}
