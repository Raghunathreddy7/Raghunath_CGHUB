using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Litware Application!");
            Employee e1 = new Employee(1, "karthik", 30000);
            e1.CalculateSalary();
            Console.ReadLine();

        }
    }
}
