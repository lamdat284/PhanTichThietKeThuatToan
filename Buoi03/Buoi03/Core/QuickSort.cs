using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03.Core
{
    public class QuickSort
    {
        public void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        public void Quicksort(int[] arr, int startArr, int endArr)
        {
            if (startArr < endArr)
            {
                int divide = DivArr(arr, startArr, endArr);

                Quicksort(arr, startArr, divide - 1);
                Quicksort(arr, divide + 1, endArr);
            }
        }

        public int DivArr(int[] arr, int startArr, int endArr)
        {
            int pivot = arr[endArr];
            int i = startArr - 1;

            for (int j = startArr; j < endArr; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, endArr);

            return i + 1;
        }
    }
}
