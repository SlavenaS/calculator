using System;

namespace CalculatorExample
{
    public class Calculator
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Subtact(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Devide(double x, double y)
        {
            //delene na 0
            return x / y;
        }
        public long Factoriel(int x)
        {
            long rezul = 1;
            for (int i = 2; i <= x; i++)
            {
                rezul *= i;
            }
           return rezul;
        }
        public double Stepen(double baseNumber, int power)
        {
            //stepenuvane s -chisla
            double rezul = 1;
            for (int i = 1; i <= power; i++)
            {
                rezul *=baseNumber;
            }
            return rezul;
        }
    }
}