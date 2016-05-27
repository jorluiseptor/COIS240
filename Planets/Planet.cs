using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    /// <summary>
    /// Represents a planet. 
    /// </summary>
    class Planet
    {
        private string _name;

        /// <summary>
        /// Name of the planet.
        /// </summary>
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private double _diameter;
        /// <summary>
        /// The planet's diamter in Km. 
        /// </summary>
        public double diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }




        /// <summary>
        /// Describe the planet is rotating
        /// </summary>
        public void rotate()
        {
            Console.WriteLine("The planet {0} is rotating very fast!", _name);

        }
    }
}
