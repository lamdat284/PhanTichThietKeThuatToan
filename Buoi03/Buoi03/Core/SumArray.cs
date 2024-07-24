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

            // Tính tổng của mảng từ left đến right bằng hai vòng lặp
            int mid = (left + right) / 2;

            // Tính tổng của phần đầu tiên của mảng từ left đến mid
            for (int i = left; i <= mid; i++)
            {
                totalSum += i;
            }

            // Tính tổng của phần thứ hai của mảng từ mid + 1 đến right
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
                // Trường hợp cơ sở: Nếu chỉ còn một phần tử, trả về giá trị của nó
                return left;
            }

            // Chia mảng thành hai phần
            int mid = (left + right) / 2;

            // Tính tổng của hai phần bằng cách gọi đệ quy
            int leftSum = SumDivideAndConquer_Recursion(left, mid);
            int rightSum = SumDivideAndConquer_Recursion(mid + 1, right);

            // Cộng tổng của hai phần
            return leftSum + rightSum;
        }

    }
}
