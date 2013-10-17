using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//have the 2 players "roll" 6 sided dice at the end of each roll ask the players if they want to roll again the object of the
//game is to get as close to 21 as possible without going over
namespace DiceGame
{

    class Program
    {

        static void Main(string[] args)
        {           

            bool diceValue = true;

            Random roll = new Random();

          

            while (diceValue)
            {
                int die = roll.Next(1, 6);
                Console.WriteLine("Rolling...");
                Console.Write("{0}", die);
                Console.WriteLine();
                Console.WriteLine("You rolled a " + die);
                Console.Write("");
                //break;
                Console.WriteLine("Do you want to roll again? If so hit enter.");
                Console.Read();
                
                
            }
           
            


        }

    }

}


