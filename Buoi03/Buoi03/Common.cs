using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03
{
    public static class Common
    {
        public static int[] GenerateRandomArray(int size)
        {
            const int minValue = 1;
            const int maxValue = 100;

            if (size <= 0)
            {
                throw new ArgumentException("Kích thước của mảng phải lớn hơn 0.");
            }

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }

            // Sắp xếp mảng để tìm kiếm nhị phân hoạt động
            Array.Sort(array);

            return array;
        }
        public static void DisplayArray(int[] Array)
        {
            Console.Write("**Mang A: ");
            foreach (int value in Array)
            {
                Console.Write(value + " ");
            }
        }
    }
}
