using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class Desktop : Computer
    {
        private bool _hasSpeakers;
        private int _hardDriveCapacity;

        public bool hasSpeakers
        {
            get
            {
                return _hasSpeakers;
            }
            set
            {
                _hasSpeakers = value;
            }
        }

        /// <summary>
        /// Amount of hard drives that this computer has.
        /// </summary>
        public int hardDriveCapacity
        {
            get
            {
                return _hardDriveCapacity;
            }
            set
            {
                _hardDriveCapacity = value;
            }

        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Desktop()
        {
            Console.WriteLine("Your desktop has been created");
        }
        /// <summary>
        /// Constructor overload 1
        /// </summary>
        /// <param name="value">If desktop has speakers?</param>
        public Desktop(bool value)
        {
            _hasSpeakers = value;
        }

        /// <summary>
        /// Constructor overload 2
        /// </summary>
        /// <param name="value1">If desktop has speakers.</param>
        /// <param name="value2">Amount of gigabytes of the hardrive.</param>
        public Desktop(bool value1, int value2)
        {
            _hasSpeakers = value1;
            _hardDriveCapacity = value2; 
        }
    }
}
