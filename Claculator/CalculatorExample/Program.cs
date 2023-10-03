using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo 1 ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Vuvedi chislo 2 ");
            double number2 = double.Parse(Console.ReadLine());
            double result = 0;
            Calculator elka = new Calculator();

            result = elka.Sum(number1, number2);
            Console.WriteLine($"{number1}+{number2}= "+result);

            result = elka.Subtact(number1, number2);
            Console.WriteLine($"{number1}-{number2}= "+ result);

            result = elka.Multiply(number1, number2);
            Console.WriteLine($"{number1}*{number2}= " + result);

            result = elka.Devide(number1, number2);
            Console.WriteLine($"{number1}:{number2}= " + result);

            result = elka.Factoriel((int)number1);
            Console.WriteLine($"{number1}!= " + result);

            result = elka.Stepen(number1,(int)number2);
            Console.WriteLine($"{number1} ^ {(int)number2 }=" + result);
        }
    }
}
