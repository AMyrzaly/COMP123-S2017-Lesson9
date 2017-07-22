using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Abubakir Myrzaly
 * Date: July 11,2017
 * Description: This is Abstract Human class
 * Version: 0.1 - Created the Abstract Human class
 */

namespace COMP123_S2017_Lesson9
{
    /// <summary>
    /// This is Abstract Human Class
    /// </summary>
    public abstract  class Human
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _name;

        // PUBLIC PROPERTIES 
        public string Name {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        // CONSTRUCTORS --------------------------

        /// <summary>
        /// This is main constructor for the Human class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}