using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    /// <summary>
    /// Represents a star with planets.
    /// </summary>
    class SolarSystem
    {
        private string _starName;
        /// <summary>
        /// The star of this system.
        /// </summary>
        public string starName
        {
            get { return _starName; }
            set { _starName = value; }
        }

        /// <summary>
        /// Planets that orbit the sun of this system.
        /// </summary>
        public List<Planet> planetList = new List<Planet>();

        /// <summary>
        /// Writes the name of each planet in the system;
        /// </summary>
        public void showPlanets()
        {
            planetList.ForEach(delegate(String planet) {
                    Console.WriteLine(planet.n)
            });
        }
    }
}
