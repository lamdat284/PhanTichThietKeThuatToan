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
            Console.WriteLine();
            Console.Write("=> Mang A: ");
            Common.PrintArray(A);

            Console.WriteLine("\tThuat Toan BinarySearch!!!");
            BinarySearch _binarySearch = new BinarySearch();
            Console.Write("\t**Nhap so ban muon tim kiem trong mang: ");
            int x = int.Parse(Console.ReadLine());
            int kq_BinarySearch = _binarySearch.Binary(A, A.Length, x);
            if(kq_BinarySearch == -1)
            {
                Console.WriteLine("\t**Khong tim thay X trong mang A!!!");
            }else
            {
                Console.WriteLine("\t**Tim thay X tai vi tri " + kq_BinarySearch);
            }


            Console.WriteLine("\n\tThuat Toan MegreSort!!!");
            MergeSort _mergeSort = new MergeSort();
            _mergeSort.Merge_Sort(A);
            Console.Write("\t**Mang A: ");
            Common.PrintArray(A);


            Console.WriteLine("\n\tMultiply Numbers!!!");
            MultiplyNumbers _multiplyNumbers = new MultiplyNumbers();
           
            string a = "28042003";
            string b = "19052003";
            Console.WriteLine("\t**So a: "+ a);
            Console.WriteLine("\t**So b: " + b);
            string kq_MultiplyNumbers = _multiplyNumbers.Multiply(a,b);
            Console.WriteLine("\t** " + a + " * " + b + "= " + kq_MultiplyNumbers);
            

            

            Console.ReadKey();

        }
    }
}
