using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet planet1 = new Planet();
            planet1.name = "Venus";
            planet1.rotate();

            Planet planet2 = new Planet();
            planet2.name = "Angelito";
            planet2.rotate();

            Console.ReadLine();
        }
    }
}
