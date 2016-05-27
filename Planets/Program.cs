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

            planet1.diameter = 1200;


            SolarSystem sol = new SolarSystem();
            sol.starName = "Sun";
            sol.planetList.Add(planet1);
            sol.planetList.Add(planet2);



            Console.WriteLine(sol.planetList[0].name);
            Console.ReadLine();
        }
    }
}
