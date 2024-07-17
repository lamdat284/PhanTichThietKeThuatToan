using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02
{
    class Progam
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 8, 7, 2, 1, 4, 5, 6, 7, 12, 45 };
            Console.Write("=> Mang A: ");
            Common.PrintArray(A);

            Console.WriteLine("\tThuat Toan BinarySearch!!!");
            BinarySearch _binarySearch = new BinarySearch();
            Console.Write("\t**Nhap so ban muon tim kiem trong mang: ");
            int x = int.Parse(Console.ReadLine());
            int kq = _binarySearch.Binary(A, A.Length, x);
            if(kq == -1)
            {
                Console.WriteLine("\t**Khong tim thay X trong mang A!!!");
            }else
            {
                Console.WriteLine("\t**Tim thay X tai vi tri " + kq);
            }

            Console.ReadKey();



        }
    }
}
