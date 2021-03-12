using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкета__склеивание_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Это программа Анкета. Ответе пожалуйста на несколько вопросов. ");
            Console.WriteLine("Назовите ваше имя пожалуйста.");
            String name = Console.ReadLine();
            Console.WriteLine("Назовите вашу фамилию пожалуйста.");
            String surname = Console.ReadLine();
            Console.WriteLine("Назовите ваш рост.");
            String growth = Console.ReadLine();
            Console.WriteLine("Назовите ваш возраст.");
            String age = Console.ReadLine();
            Console.WriteLine("Назовите ваш вес.");
            String massa = Console.ReadLine();
            String text = name + surname + growth + age + massa;
            Console.WriteLine(text);



            Console.ReadKey();
        }
    }
}
