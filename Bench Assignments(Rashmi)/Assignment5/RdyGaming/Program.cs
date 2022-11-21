using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RdyGaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Hello welcome to RDY Gaming ---");

            Team India = new Team();

            foreach (var x in India.PlayerList)
            {
                Console.WriteLine(x.Name + " - " + x.RunsScored);
            }
        }
    }
}
