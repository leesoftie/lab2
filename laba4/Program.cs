using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void Main()
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;
            c = a + (double)b + c; 
            Console.WriteLine($"Результат: {c}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
