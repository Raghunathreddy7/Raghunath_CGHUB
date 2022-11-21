using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Generic List ---");

            var EmployeeList = new List<Employee>() {

            new Employee(){Id = 14202, Name = "Purush", Company = "VakilSearch", Designation = "Developer"},
            new Employee(){Id = 14698, Name = "Neeraj Krishna", Company = "Capgemini", Designation = "Analyst"},


        };

            Employee emp = new Employee();
            emp.Id = 14218;
            emp.Name = "Raghu";
            emp.Company = "Capgemini";
            emp.Designation = "Analyst";
            EmployeeList.Add(emp);

            //Display all the employees in the list
            foreach (var item in EmployeeList)
            {
                Console.WriteLine(item.Id + " - " + item.Name + " - " + item.Company + " - " + item.Designation);
            }


            //Display the count in the List
            Console.WriteLine("--- Total Count in the List ---");
            Console.WriteLine(EmployeeList.Count);



            // Find in the Array
            Console.WriteLine("--- Find in the Array");
            var ans = EmployeeList.Find(k => k.Name == "Karthik Chittabathini");
            Console.WriteLine(ans.Name, ans.Company);
        }
    }
}
