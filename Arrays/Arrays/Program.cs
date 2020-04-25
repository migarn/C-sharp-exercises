﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            generateArray();
        }

        private static void generateArray()
        {
            try
            {
                Console.WriteLine("Podaj rozmiar tablicy:");
                int arraySize = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną wartość podaną w komórkach tablicy:");
                int maxValue = int.Parse(Console.ReadLine());
                int[] array = generateIntsArray(arraySize, maxValue);
                Console.WriteLine("Tablica z nieposortowanymi wartościami:");
                printArray(array);
                Console.WriteLine("Tablica z posortowanymi wartościami:");
                printArray(bubbleSort(array));
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak...");
            }
        }

        private static int[] generateIntsArray(int arraySize, int maxValue)
        {
            int[] array = new int[arraySize];
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(maxValue);
            }
            return array;
        }

        private static void printArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        private static int[] bubbleSort(int[] array)
        {
            Boolean isSorting = true;
            while (isSorting)
            {
                isSorting = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int auxiliaryVariable = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = auxiliaryVariable;
                        isSorting = true;
                    }            
                }
            }
            return array;
        }
    }
}
