using System;

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

            char command = ' ';

            while (command != 'x')
            {
                Console.WriteLine("Press a to attack, x to finish.");
                command = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (command == 'a')
                {
                    s2.Attack(s1);
                }
            }
        }
    }

  
}
