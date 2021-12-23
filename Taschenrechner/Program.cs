using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Taschenrechner");
            int number1 = int.Parse(Console.ReadLine());
            string zeichen = new string(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            
            if (zeichen == "+")
            {
                int result = number1 + number2;
                Console.WriteLine(result);
            }
            else if (zeichen == "-")
            {
                int result = number1 - number2;
                Console.WriteLine(result);
            }
            else if (zeichen == "*")
            {
                int result = number1 * number1;
                Console.WriteLine(result);
            }
            else if (zeichen == "/")
            { 
                int result = number1 / number2;
                Console.WriteLine(result);
            }
            
        }
    }
}
