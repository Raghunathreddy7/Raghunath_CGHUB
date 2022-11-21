using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    public class circle
    {
        public (double circumference, double area) CircumferenceAndArea(int r)
        {
            double circum = (2 * Math.PI * r);
            double area = (Math.PI * r * r);
            return (circum, area);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            (double circumference, double area) = c.CircumferenceAndArea(2);
            Console.WriteLine("The circumference of the circle was :" + circumference);
            Console.WriteLine("The area of the circle was :" + area);

        }
    }
}
