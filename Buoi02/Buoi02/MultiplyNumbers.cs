using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02
{
    public class MultiplyNumbers
    {
        
        public string Multiply(string num1, string num2)
        {
            int m = num1.Length;
            int n = num2.Length;
            int[] result = new int[m + n];

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int mul = (num1[i] - '0') * (num2[j] - '0');
                    int sum = mul + result[i + j + 1]; 

                    result[i + j] += sum / 10;
                    result[i + j + 1] = sum % 10; 
                }
            }

            string multiplication = string.Join("", result).TrimStart('0');       
            return multiplication == "" ? "0" : multiplication;
        }
    }
}
