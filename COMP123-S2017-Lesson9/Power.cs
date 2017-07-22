using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Abubakir Myrzaly
 * Date: July 11,2017
 * Description: This is Power Class
 * Version: 0.2 - Added a constructor
 */

namespace COMP123_S2017_Lesson9
{
    /// <summary>
    /// This is Power Class chich will be use as a Data type
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        
        public string Name { get; set; }

        public int Rank { get; set; }

        // CONSTRUCTORS ----------

        /// <summary>
        /// This is main constructor for the Power Class.
        /// It takes two arguments - name (string) rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

    }
}