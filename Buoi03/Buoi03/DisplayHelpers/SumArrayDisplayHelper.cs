using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03.DisplayHelpers
{
    public static class SumArrayDisplayHelper
    {
        public static void DisplaySumResults(SumArray sumArray, int n)
        {
            Console.WriteLine("**PHUONG PHAP KHONG DE QUI!!!");
            int sumArrayNonRecursion = sumArray.SumDivideAndConquer_nonRecursion(1, n);
            Console.WriteLine("=> Ket qua khi n = " + n + " la: " + sumArrayNonRecursion);

            Console.WriteLine("**PHUONG PHAP DE QUI!!!");
            int sumArrayRecursion = sumArray.SumDivideAndConquer_Recursion(1, n);
            Console.WriteLine("=> Ket qua khi n = " + n + " la: " + sumArrayRecursion);
            Console.WriteLine("*********************************************************");
        }
    }
}
