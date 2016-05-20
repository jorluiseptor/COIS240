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
        private bool _online = false;
        private int _hitPoints = 100;
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
        /// The amount of hit points of the ship.
        /// </summary>
        public int hitPoints
        {
            get
            {
                return _hitPoints; 
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
        /// <summary>
        /// Online status.
        /// </summary>
        public bool online
        {
            get
            {
                return _online; 
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
            _online = true;
        }

        /// <summary>
        /// Attack another ship.
        /// </summary>
        /// <param name="enemyShip">The spaceship object that will be attacked.</param>
        public void Attack(Spaceship enemyShip)
        {
            //random object to create random numbers.
            Random rand = new Random(); 
            //a hit amount of 10 minus a random number between 0 and 11
            int hit = 10 - rand.Next(0, 11);
            enemyShip._hitPoints = enemyShip._hitPoints - hit; 
        }
        #endregion

    }
}
