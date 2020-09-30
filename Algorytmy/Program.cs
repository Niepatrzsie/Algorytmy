using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorytmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 30;
            //BubbleSort
            Console.WriteLine("Bubble Sort");
            var rand = new Random();
            int[] tab = new int[rand.Next(min, max)];
            Console.Write("Initial array is: ");
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 20);
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
            BubbleSort.Sort(tab);
            Console.Write("Sorted array is: ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();


            //Selection Sort
            Console.WriteLine("Selection Sort");
            int[] tab1 = new int[rand.Next(min, max)];
            Console.Write("Initial array is: ");
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = rand.Next(min, max);
                Console.Write(tab1[i] + " ");
            }
            SelectionSort.Sort(tab1);
            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " ");
            }
            Console.WriteLine();
            
            
            //Insertion Sort
            Console.WriteLine("Insertion Sort");
            int[] tab2 = new int[rand.Next(min, max)];
            Console.Write("Initial array is: ");
            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = rand.Next(min, max);
                Console.Write(tab2[i] + " ");
            }
            InsertionSort.Sort(tab2);
            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.Write(tab2[i] + " ");
            }
        }
    }
}
