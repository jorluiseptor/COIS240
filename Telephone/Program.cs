using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    class Program
    {
        static void Main(string[] args)
        {
            Telephone tel1 = new Telephone();
            Telephone tel2 = new Telephone();
            Telephone tel3 = new Telephone();
            tel1.numeroTelefono = "123";
            tel2.numeroTelefono = "346";
            tel3.numeroTelefono = "768";

            Console.WriteLine("El num de tel1 es {0}", tel1.numeroTelefono);
            Console.ReadLine();
        }
    }
}
