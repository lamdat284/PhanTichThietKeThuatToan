using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02
{
    class BinarySearch
    {
        public static int Binary(int[] A,int n, int key)
        {
            int left = 0;
            int right = n - 1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if(A[mid] == key)         
                    return mid;
                if (key < A[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }


        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 45 };
            Console.Write("Mang A: ");
            foreach(int item in A)
            {
                Console.Write(" " + item);
            }
           
            Console.Write("\nNhap so ban muon tim kiem trong mang A: ");
            int x = int.Parse(Console.ReadLine());

            int kq = Binary(A, A.Length, x);
            if(kq != -1)
            {
                Console.WriteLine("Tim thay X tai vi tri " + kq);
            }
            else
            {
                Console.WriteLine("Khong tim thay X trong mang!!!");
            }
            Console.ReadKey();
        }
    }
}
