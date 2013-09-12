using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
    //Number Assignment
    //Jordan Saul
    //Class: CMP208
    //Date:9/11/13
    //Purpose: Assignment colors to every tenth number from 1-100 as different colors and odd and even numbers as different colors from 1-100.
{
    class Program
    {
        static void Main(string[] args)
        {
            //output one 1-100 every tenth is a different color : output two even is red, odd is blue
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ResetColor();
            int z = 1;
            while (z <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(z);
                z++;
            }
            while (z > 10 && z <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(z);
                z++;
            }
            while (z > 20 && z <= 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(z);
                z++;
            }
            while (z > 30 && z <= 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(z);
                z++;
            }
            while (z > 40 && z <= 50)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(z);
                z++;
            }
            while (z > 50 && z <= 60)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(z);
                z++;
            }
            while (z > 60 && z <= 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(z);
                z++;
            }
            while (z > 70 && z <= 80)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(z);
                z++;
            }
            while (z > 80 && z <= 90)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(z);
                z++;
            }
            while (z > 90 && z <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(z);
                z++;
            }
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
            }

        }
                            
    }
}
