using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            string zeichen;
            Eingabe(out number1, out zeichen, out number2);

            if (zeichen == "+")
            {
                Addition(number1, number2);
            }
            else if (zeichen == "-")
            {
                Subtration(number1, number2);
            }
            else if (zeichen == "*")
            {
                Multiplikation(number1);
            }
            else if (zeichen == "/")
            {
                Divison(number1, number2);
            }

        }

        private static void Eingabe(out int number1, out string zeichen, out int number2)
        {
            Console.WriteLine("Taschenrechner");
            number1 = int.Parse(Console.ReadLine());
            zeichen = new string(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
        }

        private static void Divison(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine(result);
        }

        private static void Multiplikation(int number1)
        {
            int result = number1 * number1;
            Console.WriteLine(result);
        }

        private static void Subtration(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine(result);
        }

        private static void Addition(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }
    }
}
