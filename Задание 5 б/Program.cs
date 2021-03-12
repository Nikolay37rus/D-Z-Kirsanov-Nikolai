using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_б //программа которая выводит на экран ваше имя, фамилию и город проживания. Вывод в центре экрана
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Кирсанов Николай";
            string city = "Иваново";

            Console.SetCursorPosition(50, 50);
            Console.WriteLine(name);
            Console.SetCursorPosition(50, 40);
            Console.WriteLine(city);
            Console.ReadKey();
        }
    }
}
