using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COIS240
{
    class Circle
    {
        /// <summary>
        /// 
        /// </summary>
        private string _name = "bar";
        private double _radius;

        /// <summary>
        /// The distance from the center of the circle.
        /// </summary>
        public double radius {
            get 
            {
                return _radius;
            }
            set
            {
                _radius = value; 
            }
        }

        
        /// <summary>
        /// Calculates and returns area of this circle.
        /// </summary>
        /// <returns>Area of circle.</returns>
        public double getArea()
        {
            return System.Math.PI * _radius;
        }


    }
}
