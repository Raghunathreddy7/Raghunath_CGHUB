using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionProjectt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 78, 76, 80 };
            string[] names = new string[] { "zkarthik", "neeraj", "purush" };


            // copy int array
            int[] markscopy = new int[3];
            Array.Copy(marks, markscopy, marks.Length);
            Console.WriteLine("--- copied int Array --");
            displayArray();


            void displayArray()
            {
                for (int i = 0; i < markscopy.Length; i++)
                {
                    Console.WriteLine(markscopy[i]);
                }
            }


          

            // sort the int array
            Console.WriteLine("--- array after sorting ---");
            Array.Sort(markscopy);
            displayArray();


           


            // reverse a array
            Console.WriteLine("--- Reverse a array ---");
            Array.Reverse(markscopy);
            displayArray();

            //clear a array
            Console.WriteLine("--- clear a array ---");
            Array.Clear(markscopy);
            displayArray();
        }
    }
}
