using System;

namespace _01_Calculator
{
    public class Calculator
    {
        public static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
        {
            int Lo = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Lo = Lo + numbers[i];

            }
            return Lo;
        }

        internal static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        internal static int Power(int v1, int v2)
        {
            return (int)Math.Pow(v1, v2);
        }

        internal static int Factorial(int v)
        {
            int P = 1;
            for (int i = 1; i <= v; i++)
            {
                P = P * i;

            }
            return P;
        }
    }
}