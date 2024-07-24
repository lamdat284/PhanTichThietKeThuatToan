using Buoi03.DisplayHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03.Task
{
    public static class SumArrayTasks
    {
        public static void Execute_SumTask()
        {
            SumArray sumArray = new SumArray();
            Console.WriteLine("\tTONG MANG TU 1 -> n");
            Console.Write("**Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            SumArrayDisplayHelper.DisplaySumResults(sumArray, n);
        }
    }
}
