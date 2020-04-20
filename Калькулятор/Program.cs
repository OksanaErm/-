using System;

namespace Калькулятор
/*написать калькулятор*/
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstValue, SecondValue;
            string Action;

            Console.WriteLine("Введите первое число");
            FirstValue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            SecondValue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите действие '+' '-' '*' '/'");
            Action = Console.ReadLine();

            switch (Action)

            {
                default:
                    Console.WriteLine("Error!");
                    break;

                case "+":
                    Console.WriteLine(FirstValue + SecondValue);
                    break;

                case "-":
                    Console.WriteLine(FirstValue - SecondValue);
                    break;

                case "*":
                    Console.WriteLine(FirstValue * SecondValue);
                    break;

                case "/":
                    Console.WriteLine(FirstValue / SecondValue);
                    break;
            }
            Console.ReadLine();

        }
    }
}

