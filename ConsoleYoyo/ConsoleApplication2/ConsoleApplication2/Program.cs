using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleYoYo
{
    public class Yoyo
    {
        int x, y, numTimes;
        public Yoyo(int xPos, int ypos, int numTimes)
        {
            x = xPos;
            y = ypos;
            this.numTimes = numTimes;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            int maxLength = 5;
            int currentLength = 0;
            for (int times = 0; times < 5; times++)

            for (int i = 0; i < maxLength; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|");
                Console.SetCursorPosition(x, y + i + 1);
                Console.Write("0");
                Thread.Sleep(100);
            }
            for (int i = maxLength; i >= 0; i--)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|");
                Console.SetCursorPosition(x, y + i + 1);
                Console.Write("0");
                Console.SetCursorPosition(x, y + i + 1 + 2);
                Console.Write(" ");
                Thread.Sleep(100);
            }
            Thread.Sleep(300);
        }

    }
}
