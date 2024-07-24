using Buoi03.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03.DisplayHelpers
{
    public static class QuickSortDisplayHelper
    {
        public static void DisplayQuickSortResults(QuickSort quickSort, int[] array)
        {
           

            Console.WriteLine("**Mang truoc khi sap xep!!!");
            Common.DisplayArray(array);

            quickSort.Quicksort(array, 0, array.Length - 1);
            Console.WriteLine();
            Console.WriteLine("**Mang sau khi sap xep: ");
            Common.DisplayArray(array);

            Console.WriteLine();
        }
    }
}
