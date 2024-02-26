using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        public static void TestGame()
        {
            // Create a Game object
            Game game = new Game();

            game.StartGame();

            int sum = game.SumOfDieValues;

            // Assert that the sum is within the expected range based on the number of dice rolled (3 to 18 for three dice)
            Debug.Assert(sum >= 3 && sum <= 18, $"Sum of die values ({sum}) out of range 3 to 18");
        }
    
        public static void TestDie()
        {
            // Create a Die object
            Die die = new Die(new Random());

            // Tests that the die roll is inbetween 1 and 6
            int rollResult = die.Roll();
            Debug.Assert(rollResult >= 1 && rollResult <= 6, $"Die roll result ({rollResult}) out of range.");

        }
    }
}
