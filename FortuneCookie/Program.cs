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
            Console.WriteLine(inbeddifier("You will grow old"));
            Console.ReadLine();
        }

        /// <summary>
        /// Adds the text " in bed" to the provided prediction string.
        /// </summary>
        /// <param name="prediction">The original string.</param>
        /// <returns>A prediction with the words "in bed" in the end.</returns>
        static string inbeddifier(string prediction)
        {
            return prediction + " in bed!";
        }
    }
}
