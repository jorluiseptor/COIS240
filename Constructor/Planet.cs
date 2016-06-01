using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Planet
    {
        private string _creationDate;

        public string creationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        //constructor
        /*
        public Planet(string planetName)
        {
            _name = planetName;
            _creationDate = "12/12/2016";
        }
        */

        public Planet()
        {
            Console.WriteLine("You have created an instance.");
        }
        //overloading
        public Planet(string planetName)
        {
            _name = planetName;
            Console.WriteLine("Corrio el overload segundo. Parametro es {0}", planetName);
        }
    }
}
