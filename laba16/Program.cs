using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba16
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите массу (кг): ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите объем (м³): ");
            double V = double.Parse(Console.ReadLine());
            double p = m / V;
            Console.WriteLine($"Плотность: {p} кг/м³");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
