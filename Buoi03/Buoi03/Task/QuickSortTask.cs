using Buoi03.Core;
using Buoi03.DisplayHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03.Task
{
    public class QuickSortTask
    {
        public void  Execute_QuickSortTask() 
        {
           
            QuickSort quickSort = new QuickSort();
            Console.WriteLine("\tQUICKSORT");

            int[] array = { 12, 87, 45, 67 };
         
            QuickSortDisplayHelper.DisplayQuickSortResults(quickSort, array);
        }
    }
}
