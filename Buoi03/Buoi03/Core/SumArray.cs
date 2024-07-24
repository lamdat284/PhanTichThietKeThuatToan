using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03
{
    public class SumArray
    {
        public int SumDivideAndConquer_nonRecursion(int left, int right)
        {
            int totalSum = 0;

            
            int mid = (left + right) / 2;

            for (int i = left; i <= mid; i++)
            {
                totalSum += i;
            }

            for (int i = mid + 1; i <= right; i++)
            {
                totalSum += i;
            }

            return totalSum;
        }
        public int SumDivideAndConquer_Recursion(int left, int right)
        {
            if (left == right)
            {
                return left;
            }

            int mid = (left + right) / 2;

            int leftSum = SumDivideAndConquer_Recursion(left, mid);
            int rightSum = SumDivideAndConquer_Recursion(mid + 1, right);

            return leftSum + rightSum;
        }

    }
}
