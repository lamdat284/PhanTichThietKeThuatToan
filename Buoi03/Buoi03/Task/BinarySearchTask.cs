using Buoi03.DisplayHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03.Task
{
    public class BinarySearchTasks
    {
        public void Execute_BinaryTask()
        {
            BinarySearch binarySearch = new BinarySearch();

            Console.WriteLine("\tTIM KIEM NHI PHAN");
            Console.Write("**Nhap so luong phan tu de sinh mang ngau nhien: ");
            int soLuongPhanTu = int.Parse(Console.ReadLine());

            int[] array = Common.GenerateRandomArray(soLuongPhanTu);
            Common.DisplayArray(array);
            Console.WriteLine();
            Console.Write("**Nhap gia tri can tim: ");
            int x = int.Parse(Console.ReadLine());

            BinarySearchDisplayHelper.DisplayBinarySearchResults(binarySearch, array, x);
        }
    }
}
