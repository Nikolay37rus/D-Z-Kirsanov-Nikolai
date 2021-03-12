using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4 //обмен значения двух переменных
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.MaxValue;
            double y = 0.0000000000000000000000001;
            Swap(ref x, ref y);
            Console.WriteLine($"{x} {y}");
            Console.ReadKey();
        }
        static void Swap<T>(ref T x, ref T y)
        {
            T t = y;
            y = x;
            x = t;
        }
    
    }
}
