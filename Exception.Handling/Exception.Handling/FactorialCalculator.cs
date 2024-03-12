﻿public class FactorialCalculator
{
    public static long CalculateFactorial(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException("Menfi eded faktorial ola bilmez");
        }

        long factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
