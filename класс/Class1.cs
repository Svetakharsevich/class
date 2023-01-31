using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace класс
{
    public class Tel
    {
        //задание 1
        public int day;
        public double time;
        public double money;
        public double calculator()
        {
            double totalPrice = time * money;
            if (day == 6 || day == 7)
                return totalPrice - totalPrice * 0.1;
            else return totalPrice;
        }
    }
    //задание 3
    public class Sqr
    {
        public void Generation()
        {
            int square;
            for (int i = 1; i <= 10; i++)
            {
                square = Convert.ToInt32(Math.Pow(i, 2));
                Console.Write(i + " ");
                EndSqr ss = new EndSqr();
                ss.Stop(square);
            }
        }
    }

    public class EndSqr
    {
        public void Stop(int number)
        {
            if (number >= 25)
            {
                Console.WriteLine("Квадрат числа больше 25!");
                Console.ReadKey();
            }

        }
    }

}
