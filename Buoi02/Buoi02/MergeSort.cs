using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02
{
    public class MergeSort
    {
        private static void Merge(int[] result, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];
        }

        public static void Merge_Sort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int[] left = new int[array.Length / 2];
            int[] right = new int[array.Length - left.Length];

            Array.Copy(array, 0, left, 0, left.Length);
            Array.Copy(array, left.Length, right, 0, right.Length);

            Merge_Sort(left);
            Merge_Sort(right);
            Merge(array, left, right);
        }

       

       
    }
}
