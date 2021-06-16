using System;

namespace Option5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 5
            //?А) В массиве из 18 элементов найти сумму всех положительных элементов.

            int arraySize = 18;
            int[] array = new int[arraySize];
            Random rand = new Random();
            int sum = 0;

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(100) - 40;
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine($"Сумма положительных элементов массива = {sum}");
        }
    }
}
