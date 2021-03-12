using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2 // индек массы тела
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ваш рост (м.)?");
			double height = Double.Parse(Console.ReadLine());

			Console.WriteLine("Ваш вес (кг.)?");
			double weight = Double.Parse(Console.ReadLine());

			double index = weight / (height * height);

			Console.WriteLine("Ваш индекс массы тела: " + index.ToString("N2"));

			Console.ReadKey();
		}
	}   
}
