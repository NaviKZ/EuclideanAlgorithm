using System;

namespace EuclideanAlgorithm
{
    internal class EuclideanAlgorithm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисляет НОД двух чисел А и B");

            Console.WriteLine("Введите значение числа А:");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение числа B:");
            int numberB = Convert.ToInt32(Console.ReadLine());

            if (numberA != numberB && (numberA == 0 || numberB == 0))
            {
                Console.WriteLine("НОД = " + Math.Max(numberA, numberB));
            }
            else if (numberA == 0 && numberB == 0)
            {
                Console.WriteLine("НОД искать нельзя, так как оба числа равны нулю!");
            }
            else
            {
                while ((numberA %= numberB) != 0)
                {
                    int transmittingNumber = numberA;
                    numberA = numberB;
                    numberB = (transmittingNumber % numberB);
                }

                Console.WriteLine("НОД = " + numberB);
            }

            Console.ReadLine();
        }
    }
}