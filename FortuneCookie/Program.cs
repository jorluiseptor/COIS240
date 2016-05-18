using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(inbeddifier("You will grow old "));
            Console.ReadLine();
        }

        static string inbeddifier(string prediction)
        {
            return prediction + " in bed!";
        }
    }
}
