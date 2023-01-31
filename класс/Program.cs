using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace класс
{
    internal class Program
    {
        static void TaskOne()
        {
            try
            {
                Tel tel = new Tel();
                while (tel.day < 1 || tel.day > 7)
                {
                    Console.Write("День недели разговора: ");
                    tel.day = Convert.ToInt32(Console.ReadLine());
                    if (tel.day < 1 || tel.day > 7)
                    {
                        Console.WriteLine("День должен быть от 1 до 7");//задание 2
                        Console.ReadKey();
                    }

                }
                Console.Write("Время разговора: ");
                tel.time = Convert.ToDouble(Console.ReadLine());
                Console.Write("Стоимость минуты:");
                tel.money = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Стоимость разговора: {tel.calculator()}");
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        static void TaskTree()
        {
            try
            {
                Sqr number = new Sqr();
                number.Generation();
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
        static void Main(string[] args)
        {
            TaskOne();
            TaskTree();
            Console.ReadKey();
        }
    }
}
