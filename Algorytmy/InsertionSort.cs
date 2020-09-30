using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy
{
    class InsertionSort
    {
        public static void Sort(int [] arrayToSort)
        {
            
            for (int i = 1; i <arrayToSort.Length -1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if(arrayToSort[j-1] > arrayToSort[j])
                    {
                        int temp = arrayToSort[j - 1];
                        arrayToSort[j - 1] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                }
            }
        }
    }
}
