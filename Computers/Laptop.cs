using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    class Laptop : Computer
    {
        private bool _hasTouchScreen;

        /// <summary>
        /// If the laptop has touch screen.
        /// </summary>
        public bool hasTouchScreen
        {
            get
            {
                return _hasTouchScreen;
            }
            set
            {
                _hasTouchScreen = value;
            }
        } // end of hasTouchScreen

        /// <summary>
        /// Open the laptop
        /// </summary>
        public void open()
        {
            Console.WriteLine("The laptop is now opened.");
            
        }
        /// <summary>
        /// Close the laptop
        /// </summary>
        public void close()
        { }


    } // final de class Laptop
} //final del Namespace Computers
