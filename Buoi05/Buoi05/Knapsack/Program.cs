using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    public class Program
    {
        public static int KnapsackProblem(int W, int[] weights, int[] values, int n, out List<int> itemsSelected)
        {
            int[,] K = new int[n + 1, W + 1];
            itemsSelected = new List<int>();

            // Xây dựng bảng K
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        K[i, w] = 0;
                    }
                    else if (weights[i - 1] <= w)
                    {
                        K[i, w] = Math.Max(values[i - 1] + K[i - 1, w - weights[i - 1]], K[i - 1, w]);
                    }
                    else
                    {
                        K[i, w] = K[i - 1, w];
                    }
                }
            }

            // Truy vết lại để tìm các món đồ đã chọn
            int res = K[n, W];
            int w_remaining = W;

            for (int i = n; i > 0 && res > 0; i--)
            {
                if (res != K[i - 1, w_remaining])
                {
                    itemsSelected.Add(i - 1); // Lưu lại chỉ số của món đồ
                    res -= values[i - 1];
                    w_remaining -= weights[i - 1];
                }
            }

            return K[n, W];
        }
        public static void Main()
        {
            int[] values = { 4, 5, 10, 11, 13 };
            int[] weights = { 3, 4, 7, 8, 9 };
            int W = 20;
            int n = values.Length;

            List<int> itemsSelected;
            int maxValue = KnapsackProblem(W, weights, values, n, out itemsSelected);

            Console.WriteLine("Gia tri lon nhat co the dat duoc la: " + maxValue);
            Console.WriteLine("Danh sach cac do vat duoc chon: ");

            foreach (int item in itemsSelected)
            {
                Console.WriteLine("Item " + item + " (Gia tri: " + values[item] + ", Trong luong: " + weights[item] + ")");
            }
            Console.ReadKey();
        }
    }
}
