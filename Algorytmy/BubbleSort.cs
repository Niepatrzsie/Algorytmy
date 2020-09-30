using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy
{
    class BubbleSort
    {
    
        public static void Sort(int [] arrayToSort)
        {
            int n = arrayToSort.Length;
            int it = 0;
            while(it<n-1)
            {
                for(int j=0; j<n-1; j++)
                {
                    if(arrayToSort[j] > arrayToSort[j + 1])
                    {
                        Swap(arrayToSort, j, j + 1);
                    }
                }
                it++;
            }
        }
       public static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        } 
    }
}
