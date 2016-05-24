using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {

            Spaceship s1 = new Spaceship();
            s1.name = "Battlestar Gallactica";
            Console.WriteLine(s1.state);
            Console.WriteLine(s1.name);

            Spaceship s2 = new Spaceship();
            s2.name = "Millenium Falcon";
            s2.TurnOn();

            char command = '1';

            while (command != 'x')
            {
                Console.WriteLine("Press a to attack.");
                Console.WriteLine("Press x to finish.");

                command = Console.ReadKey().KeyChar; 
                if (command == 'a')
                {
                    Console.WriteLine(""); //blank line

                    s2.Attack(s1);
                }
            }

        }
    }

  
}
