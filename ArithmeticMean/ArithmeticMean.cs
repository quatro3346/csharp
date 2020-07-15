using System;

namespace ArithmeticMean
{
    class ArithmeticMean
    {
        static void Main(string[] args)
        {
            int startRange = 7;
            int endRange = 26;
            int i = startRange;
            int sum = 0;
            int sumEven = 0;
            int numberCount = 0;
            int evenCount = 0;

            while (i <= endRange)
            {
                if (i < endRange)
                {
                    ++numberCount;
                }
                sum += i;
                i++; 
            }
            double arithmeticMean = Convert.ToDouble(sum) / numberCount;
            Console.WriteLine("Среднее арифметическое = " + arithmeticMean);

            i = startRange;
            while (i <= endRange)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                    evenCount++;
                }
                i++;
            }
            double arithmeticMeanEven = Convert.ToDouble(sumEven) / evenCount;
            Console.WriteLine("Среднее арифметическое четных чисел = " + arithmeticMeanEven);
        }
    }
}
