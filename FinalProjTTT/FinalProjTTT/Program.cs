using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjTicTacToe
{
    class Program
    {
        static string[] Position = new string[9];
        static string String = "";
        static int Key = 0;
        static int TurnCount = 0;
        static bool GameEnd = false;


        //Player input
        public void Player1()
        {
            Console.WriteLine("Player 1 Make Your Selection.");
            String = Console.ReadLine();
            int.TryParse(String, out Key);
            if (String == "1" || String == "2" || String == "3" || String == "4" || String == "5" || String == "6" || String == "7" || String == "8" || String == "9")
            {
                //Input update
                Key = Key - 1;
                if (Position[Key] != " ")
                {
                    Console.WriteLine("This space is taken already.");
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine(" 0 | 1 | 2 ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" 3 | 4 | 5 ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" 6 | 7 | 8 ");

                    Position[Key] = "X";

                    Console.WriteLine(" " + Position[0] + " | " + Position[1] + " | " + Position[2] + " ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" " + Position[3] + " | " + Position[4] + " | " + Position[5] + " ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" " + Position[6] + " | " + Position[7] + " | " + Position[8] + " ");

                    TurnCount++;
                }
            }
        }
        public void Player2()
        {
            Console.WriteLine("Player 2 Make Your Selection.");
            String = Console.ReadLine();
            int.TryParse(String, out Key);
            if (String == "1" || String == "2" || String == "3" || String == "4" || String == "5" || String == "6" || String == "7" || String == "8" || String == "9")
            {
                //Player 2 input update
                Key = Key - 1;
                if (Position[Key] != " ")
                {
                    Console.WriteLine("This space is taken already.");
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine(" ");
                    Console.WriteLine(" 0 | 1 | 2 ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" 3 | 4 | 5 ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" 6 | 7 | 8 ");

                    Position[Key] = "O";

                    Console.WriteLine(" " + Position[0] + " | " + Position[1] + " | " + Position[2] + " ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" " + Position[3] + " | " + Position[4] + " | " + Position[5] + " ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" " + Position[6] + " | " + Position[7] + " | " + Position[8] + " ");

                    TurnCount++;
                }
            }
        }

        //Win Conditions
        public void WinX()
        {
            //Horizontal wins
            if (Position[0] == "X" && Position[1] == "X" && Position[2] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                GameEnd = true;
            }

            if (Position[3] == "X" && Position[4] == "X" && Position[5] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                GameEnd = true;
            }

            if (Position[6] == "X" && Position[7] == "X" && Position[8] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                GameEnd = true;
            }
            //Vertical wins
            if (Position[0] == "X" && Position[3] == "X" && Position[6] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                GameEnd = true;
            }

            if (Position[1] == "X" && Position[4] == "X" && Position[7] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                GameEnd = true;
            }

            if (Position[2] == "X" && Position[5] == "X" && Position[8] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                GameEnd = true;
            }
            // X win
            if (Position[8] == "X" && Position[4] == "X" && Position[0] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                GameEnd = true;
            }

            if (Position[6] == "X" && Position[4] == "X" && Position[2] == "X")
            {
                Console.WriteLine("Player 1 Wins!");
                GameEnd = true;
            }
        }
        public void WinO()
        {
            //Horizontal wins
            if (Position[0] == "O" && Position[1] == "O" && Position[2] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                GameEnd = true;
            }
            if (Position[3] == "O" && Position[4] == "O" && Position[5] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                GameEnd = true;
            }
            if (Position[6] == "O" && Position[7] == "O" && Position[8] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                GameEnd = true;
            }
            //vertical wins
            if (Position[0] == "O" && Position[3] == "O" && Position[6] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                GameEnd = true;
            }
            if (Position[1] == "O" && Position[4] == "O" && Position[7] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                GameEnd = true;
            }
            if (Position[2] == "O" && Position[5] == "O" && Position[8] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                GameEnd = true;
            }
            // X win
            if (Position[8] == "O" && Position[4] == "O" && Position[0] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                GameEnd = true;
            }
            if (Position[6] == "O" && Position[4] == "O" && Position[2] == "O")
            {
                Console.WriteLine("Player 2 Wins!");
                GameEnd = true;
            }
        }



        static void Main(string[] args)
        {
            //Program check = new Program();
            Program player = new Program();
            Position[0] = " ";
            Position[1] = " ";
            Position[2] = " ";
            Position[3] = " ";
            Position[4] = " ";
            Position[5] = " ";
            Position[6] = " ";
            Position[7] = " ";
            Position[8] = " ";

            //Board guide
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" 0 | 1 | 2 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 3 | 4 | 5 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 6 | 7 | 8 ");

            //Players' turns
            while (TurnCount != 9)
            {
                if (GameEnd != true)
                {
                    if (TurnCount % 2 == 0)
                    {
                        player.WinO();
                        if(GameEnd != true)
                            player.Player1();
                    }

                    if (TurnCount % 2 != 0)
                    {
                        player.WinX();
                        if(GameEnd != true)
                            player.Player2();
                    }
                }
                else
                    return;
            }
            if (TurnCount == 9)
            {
                if (GameEnd != true)
                {
                    Console.WriteLine("Game is a draw.");
                    return;
                }
                else
                    return;
            }
        }


    }
}