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
            SumArray _sumArray = new SumArray();

            Console.WriteLine("\tTONG MANG TU 1 -> n");
            Console.Write("**Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("**PHUONG PHAP KHONG DE QUI!!!");
           
            int sumArray_nonRecursion = _sumArray.SumDivideAndConquer_nonRecursion(1, n);
            Console.WriteLine("=>Ket qua khi n = " + n + " la: " + sumArray_nonRecursion);

            Console.WriteLine("**PHUONG PHAP DE QUI!!!");
            int sumArray_Recursion = _sumArray.SumDivideAndConquer_Recursion(1, n);
            Console.WriteLine("=>Ket qua khi n = " + n + " la: " + sumArray_Recursion);


            Console.ReadKey();


        }
    }
}
