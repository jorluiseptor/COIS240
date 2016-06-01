using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    /// <summary>
    /// A computer.
    /// </summary>
    class Computer
    {
        private string _model;

        /// <summary>
        /// The computer model.
        /// </summary>
        public string model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        /// <summary>
        /// Turns the computer on
        /// </summary>
        public void turnOn()
        {

        }

        /// <summary>
        /// Turns the computer off
        /// </summary>
        public void turnOff()
        {

        }
    }
}
