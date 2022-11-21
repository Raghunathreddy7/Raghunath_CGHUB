using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static int sum(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }



        public static void Main(string[] args)
        {
            int[] arr = { 10, 23, 14, 25 };
            int n= arr.Length;
            Console.WriteLine("Sum of array value : "+sum(arr,n));


        }
    }
    
    
}
