using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next());          // От 0 до Int32.MaxValue
            Console.WriteLine(rnd.Next(5));         // От 0 до 4
            Console.WriteLine(rnd.Next(-5, 5));     // От -5 до 4
        }
    }
}
