using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Program
    {
        static void Main()
        {
            double number = 3.14159;
            Console.WriteLine($"Округление: {Math.Round(number, 2)}"); 
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
