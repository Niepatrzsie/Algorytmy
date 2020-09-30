using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy
{
    class SelectionSort
    {
        public static void Sort(int [] arraytoSort)
        {
            int temp, smallest;
            for (int i = 0; i <arraytoSort.Length - 1; i++) 
            {
                smallest = i; 
                for (int j = i+1; j < arraytoSort.Length; j++)
                {
                    if(arraytoSort[j] < arraytoSort[smallest])   
                    {
                        smallest = j;
                    }
                }
                temp = arraytoSort[smallest];
                arraytoSort[smallest] = arraytoSort[i];
                arraytoSort[i] = temp;
            }
        }
     
        
    }
}
