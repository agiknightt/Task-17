using System;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCountArray = 30;
            int[] array = new int[maxCountArray];
            Random rand = new Random();
            int maxLocal = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 50);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0 && i != array.Length - 1)
                {
                    if(array[i] > array[i + 1] && array[i] > array[i - 1])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                else if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                else if(i == array.Length)
                {
                    if(array[i] > array[i - 1])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
