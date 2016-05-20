using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Spaceship
    {

        #region Attributes
            private string _name;
            private string _state = "Offline";
            //TODO añade una funcion para atacar a otras naves
            //TODO anade el HitPoint (HP) y escudo (shield) de la nave
            //TODO una funcion que dispare de una nave a otra y el parametro
            //sea otra el objeto de otra nave. 
        #endregion

        #region Properties
            /// <summary>
            /// Name of the ship.
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

            /// <summary>
            /// Current state of the ship. 
            /// </summary>
            public string state
            {
                get
                {
                    return _state;
                }
            }
        #endregion


        #region Methods

        /// <summary>
        /// Make the ship take off. 
        /// </summary>
        public void TakeOff()
        {
            //Ship is now flying.
            _state = "Flying";
        }

        /// <summary>
        /// Turns the ship online. The ship must be online before it can do other commands.
        /// </summary>
        public void TurnOn()
        {
            //Ship is now on. 
            _state = "Online"; 
        }

        #endregion

    }
}
