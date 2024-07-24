using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03
{
    public class BinarySearch
    {
        
        public int BinarySearch_nonRecursion(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

              
                if (array[mid] == target)
                {
                    return mid;
                }

                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }        
            return -1;
        }

        public int BinarySearch_Recursion(int[] array, int target)
        {
            return BinarySearch_Recursion(array, target, 0, array.Length - 1);
        }
        private int BinarySearch_Recursion(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1; // Giá trị không có trong mảng
            }

            // Tính chỉ số giữa
            int mid = left + (right - left) / 2;

            // Kiểm tra nếu giá trị tại mid là giá trị tìm kiếm
            if (array[mid] == target)
            {
                return mid;
            }

            // Nếu giá trị tại mid nhỏ hơn giá trị tìm kiếm, tìm kiếm trong nửa phải
            if (array[mid] < target)
            {
                return BinarySearch_Recursion(array, target, mid + 1, right);
            }
            // Nếu giá trị tại mid lớn hơn giá trị tìm kiếm, tìm kiếm trong nửa trái
            else
            {
                return BinarySearch_Recursion(array, target, left, mid - 1);
            }
        }

    }
}
