using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3  // Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
{
    class Program
    {
        static void Main(string[] args)                                     
        {
            Console.WriteLine("Введите x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x1");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = 0;
            r = (double)Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
            Console.WriteLine("{0}", $"{ r:F2}") ;

            Console.ReadKey();
        }
    }
}
