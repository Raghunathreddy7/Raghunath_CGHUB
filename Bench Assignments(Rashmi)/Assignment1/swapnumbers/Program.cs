using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnumbers
{
    public class Program
    {
        public class swapnumbers
        {
            public void swapping(int a, int b)
            {

                Console.WriteLine("--- Numbers before Swapping --- ");
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);

                int temp = a;
                a = b;
                b = temp;

                Console.WriteLine("--- Numbers after Swapping --- ");
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);

            }
        }
        static void Main(string[] args)
        {
            swapnumbers sn = new swapnumbers();
            sn.swapping(2, 5);
        }
    }
}
