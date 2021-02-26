using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();

            //int number1 = 20;
            //int number2 = 100;

            //number1 in metotta değişebileceğini düşünüyorsak ref olarak gönderebiliriz.
            //ref te mutlaka ilk başta bir değer vermeliyiz.
            //var result2 = Add3(ref number1, number2);

            ////out keyword de number1'i ilk başta set etmemize gerek yok.
            //var result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);

            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //int number2=30 -- default değerler her zaman metodun en sonunda olması gerekiyor.
        //birden fazla default  değer tanılayabiliyoruz.
        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            //out için değer gönderdiğimizde metodun içinde mutlaka bir kere set edilmeli.
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number)
        {
            return number1 * number2 * number;
        }
    }
}
