using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class Program
    {
        static void Main(string[] args)
        {
            Desktop classRoomDesktop = new Desktop(true,23);
            Laptop laLaptopdeMelissa = new Laptop();
            laLaptopdeMelissa.open();
            Console.ReadLine();
        }
    }
}
