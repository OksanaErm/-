using System;

namespace сложение_четных

            /*сложение четных чисел в массиве*/
            {
    class Program
        {
            static void Main(string[] args)
            {
                int[] Array = { 1, 3, 4, 88, 14, 50, 13, 9 };
                int Result = 0;
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] % 2 == 0)
                    {
                        Result = Result + Array[i];

                    }

                }
                Console.WriteLine(Result);
                Console.ReadLine();
            }
        }
    }
Нужно доделать
