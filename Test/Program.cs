using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COIS240
{
    class Program
    {
        static void Main(string[] args)
        {
            //test circle
            Circle myCircle = new Circle();
            myCircle.radius = 1;
            myCircle.getArea();
            Console.WriteLine("hello");
            Console.WriteLine(myCircle.getArea());
            Console.ReadLine();
        }
    }
}
