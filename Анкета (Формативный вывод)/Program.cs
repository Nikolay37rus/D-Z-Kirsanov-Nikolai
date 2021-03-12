using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкета__Формативный_вывод_
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Здравствуйте! Это программа Анкета. Ответе пожалуйста на несколько вопросов. ");

			Console.WriteLine("Назовите ваше имя пожалуйста.");
			string name = Console.ReadLine();

			Console.WriteLine("Назовите вашу фамилию пожалуйста.");
			string surname = Console.ReadLine();

			Console.WriteLine("Назовите ваш возраст.");
			string age = Console.ReadLine();

			Console.WriteLine("Назовите ваш рост.");
			string growth = Console.ReadLine();

			Console.WriteLine("Назовите ваш вес.");
			string massa = Console.ReadLine();
			
			Console.WriteLine("{0} {1}: {2} лет, {3} см., {4} кг.", name, surname, age, growth, massa);
			Console.ReadKey();

        }
    }
}
