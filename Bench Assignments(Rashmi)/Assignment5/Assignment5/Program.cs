using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Array List ---");

            var emp1 = new ArrayList();

            emp1.Add("Raghunath");
            emp1.Add(11179);
            emp1.Add("Capgemini");
            emp1.Add("Analyst");


            // display or iterate over the array list 

            foreach (var item in emp1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
