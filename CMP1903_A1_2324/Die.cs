using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property to hold die value
        public int DieValue { get; private set; }


        //Method to roll the die and return result
        public int Roll()
        {
            Random random = new Random();
            DieValue = random.Next(1, 7); // Genrates a random number between 1 and 6
            return DieValue;
        }

    }
}
