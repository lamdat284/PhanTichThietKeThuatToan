using Buoi03.DisplayHelpers;
using Buoi03.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumArrayTasks _sumArrayTasks = new SumArrayTasks();
            _sumArrayTasks.Execute_SumTask();

            BinarySearchTasks _binarySearchTask = new BinarySearchTasks();
           _binarySearchTask.Execute_BinaryTask();

            QuickSortTask _quickSortTask = new QuickSortTask();
            _quickSortTask.Execute_QuickSortTask();
            Console.ReadKey();
           
        }
    }
}
