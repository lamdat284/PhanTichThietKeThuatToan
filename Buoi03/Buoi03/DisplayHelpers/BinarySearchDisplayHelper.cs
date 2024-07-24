using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03.DisplayHelpers
{
    public static class BinarySearchDisplayHelper
    {
        public static void DisplayBinarySearchResults(BinarySearch binarySearch, int[] array, int target)
        {
            Console.WriteLine("**PHUONG PHAP DE QUI!!!");
            int resultBinarySearch_Recursion = binarySearch.BinarySearch_Recursion(array, target);
            if (resultBinarySearch_Recursion != -1)
            {
                Console.WriteLine($"=> Tim thay {target} trong mang");
            }
            else
            {
                Console.WriteLine($"=> Khong tim thay {target} trong mang");
            }

            Console.WriteLine("**PHUONG PHAP KHONG DE QUI!!!");
            int resultBinarySearch_nonRecursion = binarySearch.BinarySearch_nonRecursion(array, target);
            if (resultBinarySearch_nonRecursion != -1)
            {
                Console.WriteLine($"=> Tim thay {target} trong mang");
            }
            else
            {
                Console.WriteLine($"=> Khong tim thay {target} trong mang");
            }
        }
    }
}
