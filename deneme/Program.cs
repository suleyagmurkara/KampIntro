using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2 = 100;

            var result = Add(out number1, number2);

            Console.WriteLine(result);
        }

        static int Add(out int number1, int number2)
        {
            number1 = 20;
            return number1 + number2;
        }
    }
}
