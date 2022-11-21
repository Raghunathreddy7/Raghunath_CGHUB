using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateProg
{
    internal class Program
    {
        public delegate void DelegateDemo();

        public delegate void DelegateDemo2(string msg);
        static void Main(string[] args)
        {

            // ------------------ EMPLOYEE MANAGEMENT CODE STARTS --------------------------------
            // Task 6 [date = 15-11-2022]

            Console.WriteLine("Welcome to Litware Application!");
            Employee e1 = new Employee(1, "Raghu", 30000, "employee", 0);


            // Instantiate delegate (multicast delegate)
            DelegateDemo h1 = e1.CalculateSalary;
            DelegateDemo h2 = e1.EmpDetails;
            DelegateDemo alldelegates = h1 + h2;


            // Instantiate delegate (Unicast delegate)
            DelegateDemo2 greetings = e1.PrintMessage;


            //call the delegates
            alldelegates();

            greetings("------------- Bye --------------");

            Console.ReadLine();


        }
    }
}
