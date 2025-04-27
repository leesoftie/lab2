using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class Program
    {
        static void Main()
        {
            int a = 3;
            double b = 2.6;
            b = a + b; 
            Console.WriteLine($"Сумма: {b}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
