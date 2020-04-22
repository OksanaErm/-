
using System;

namespace вывести_четные_числа
{

    class Program

    {
        public static double Main()

        {
            for (double i = 0; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
            return 0;
        }
    }

}