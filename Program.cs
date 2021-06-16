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


            //?Б) Дан массив из 30 элементов. Найти порядковый номер первого отрицательного элемента.

            int arrSize = 30;
            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = rand.Next(100) - 40;
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < arraySize; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine($"Порядковый номер первого отрицательного элемента массива = {i + 1}");
                    break;
                }
            }

            //В) Переменной t присвоить значение true, если в массиве x нет нулевых элементов, и при
            //этом отрицательные элементы чередуются с положительными, и значение – false в
            //противном случае.

            int xSize = 10;
            //int[] x = new int[xSize]{ 2, -5, 44, -27, 16, -16, 9, -10, 1, 25 };
            int[] x = { 2, -5, 44, -27, 16, -16, 9, -10, 1, 25 };
            bool t = true;

            for (int i = 0; i < x.Length - 1; i = i + 2)
            {
                if (x[i] > 0 && x[i + 1] < 0)
                {
                    if (x[i] == 0)
                    {
                        t = true;
                    }

                }
                else
                {
                    t = false;
                    break;
                }
            }
            Console.WriteLine($"t = {t}");

        }
    }
}
