using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Jordan Saul

//Class: CMP 129

//Date: 12/5/13

//Purpose: Final Project


namespace FinalProjectTicTacToe
{
    class Program
    {
<<<<<<< HEAD
        public void DrawBoardX();
        static void Main(string[] args)
        {
            
=======
        static void Main(string[] args)
        {
>>>>>>> 8b36820ed03d6f951d7659cb0cea6116222b63d0
            string A = "1";
            string B = "2";
            string C = "3";
            string D = "4";
            string E = "5";
            string F = "6";
            string G = "7";
            string H = "8";
            string I = "9";
            string turn = "player1";
            string won = "false";
            string playAgain = "false";
            string player1, player2, selection;
            Console.ForegroundColor = ConsoleColor.Magenta;

            
            Console.Title = "Tic-Tac-Toe";
            Console.WriteLine("Welcome!");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter the name of player one.");
            player1 = Console.ReadLine();
            Console.WriteLine("Enter the name of player two.");
            player2 = Console.ReadLine();
<<<<<<< HEAD
            

            Start:
            Console.Clear();
            
            
        }
    }
    
   public class PlayerOne
   {
=======
            Start:


            Console.Clear();

>>>>>>> 8b36820ed03d6f951d7659cb0cea6116222b63d0
            if (turn == "player1") //player X
            {
                turn = "player2";
                Console.Clear();
                Console.WriteLine("Player: " + player1 + "'s turn!");
                Console.WriteLine("");
<<<<<<< HEAD
   
     public void DrawBoard
     {
=======
>>>>>>> 8b36820ed03d6f951d7659cb0cea6116222b63d0
                //Draw Board.
                Console.WriteLine(A + "|" + B + "|" + C);
                Console.WriteLine(D + "|" + E + "|" + F);
                Console.WriteLine(G + "|" + H + "|" + I);
                Console.WriteLine("*********************");
                Console.WriteLine("Please make a selection.");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "X";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
<<<<<<< HEAD
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
            
                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
        
     }

     public void PlayerWin
     {
=======
>>>>>>> 8b36820ed03d6f951d7659cb0cea6116222b63d0

                //winner detection
                if (A == B & B == C)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player1 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else 
                    {
                        playAgain = "false";
                    }
                }
                if (D == E & E == F)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player1 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else 
                    {
                        playAgain = "false";
                    }
                }
                if (G == H & H == I)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player1 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (A == D & D == G)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player1 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (B == E & E == H)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player1 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (C == F & F == I)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player1 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (G == E & E == C)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player1 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (A == E & E == I)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player1 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
<<<<<<< HEAD
=======
                if (won == "false")
                {
                    goto Start;
                }
                if (playAgain == "true")
                {
                    A = "1";
                    B = "2";
                    C = "3";
                    D = "4";
                    E = "5";
                    F = "6";
                    G = "7";
                    H = "8";
                    I = "9";
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }



            }


            //A|B|C
            //D|E|F
            //G|H|I
            if (turn == "player2") //player O
            {
                turn = "player1";
                Console.Clear();
                Console.WriteLine("Player: " + player2 + "'s turn!");
                Console.WriteLine("");
                //Draw Board.
                Console.WriteLine(A + "|" + B + "|" + C);
                Console.WriteLine(D + "|" + E + "|" + F);
                Console.WriteLine(G + "|" + H + "|" + I);
                Console.WriteLine("*********************");
                Console.WriteLine("Please make a selection.");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }
                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "O";
                    }
                    else
                    {
                        Console.WriteLine("Warning: This box has been taken");
                    }
                }

                //winner detection
>>>>>>> 8b36820ed03d6f951d7659cb0cea6116222b63d0
                if (A == B & B == C)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player2 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else 
                    {
                        playAgain = "false";
                    }
                }
                if (D == E & E == F)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player2 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else 
                    {
                        playAgain = "false";
                    }
                }
                if (G == H & H == I)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player2 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (A == D & D == G)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player2 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (B == E & E == H)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player2 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (C == F & F == I)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player2 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (G == E & E == C)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player2 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
                if (A == E & E == I)
                {
                    won = "true";
                    Console.WriteLine("Congratulations! " + player2 + "won!");
                    Console.WriteLine("");
                    Console.WriteLine(" Do you want to play again? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        playAgain = "true";
                    }
                    else
                    {
                        playAgain = "false";
                    }
                }
<<<<<<< HEAD
                if (won == "false")
                {
                    goto Start;
                }
                if (playAgain == "true")
                {
                    A = "1";
                    B = "2";
                    C = "3";
                    D = "4";
                    E = "5";
                    F = "6";
                    G = "7";
                    H = "8";
                    I = "9";
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
    }

    public class Player2
    {
            //A|B|C
            //D|E|F
            //G|H|I
            if (turn == "player2") //player O
            {
                turn = "player1";
                Console.Clear();
                Console.WriteLine("Player: " + player2 + "'s turn!");
                Console.WriteLine("");
            

    private class placeholder
            {
                //Draw Board.
                //Console.WriteLine(A + "|" + B + "|" + C);
                //Console.WriteLine(D + "|" + E + "|" + F);
                //Console.WriteLine(G + "|" + H + "|" + I);
                //Console.WriteLine("*********************");
                //Console.WriteLine("Please make a selection.");
                //selection = Console.ReadLine();
                //if (selection == "1")
                //{
                //    if (A == "1")
                //    {
                //        A = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
            
                //if (selection == "2")
                //{
                //    if (B == "2")
                //    {
                //        B = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
                //if (selection == "3")
                //{
                //    if (C == "3")
                //    {
                //        C = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
                //if (selection == "4")
                //{
                //    if (D == "4")
                //    {
                //        D = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
                //if (selection == "5")
                //{
                //    if (E == "5")
                //    {
                //        E = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
                //if (selection == "6")
                //{
                //    if (F == "6")
                //    {
                //        F = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
                //if (selection == "7")
                //{
                //    if (G == "7")
                //    {
                //        G = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
                //if (selection == "8")
                //{
                //    if (H == "8")
                //    {
                //        H = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
                //if (selection == "9")
                //{
                //    if (I == "9")
                //    {
                //        I = "O";
                //    }
                //    else
                //    {
                //        Console.WriteLine("Warning: This box has been taken");
                //    }
                //}
        
      }
    private class PlayerTwoWin
    {
                //winner detection
                //if (A == B & B == C)
                //{
                //    won = "true";
                //    Console.WriteLine("Congratulations! " + player2 + "won!");
                //    Console.WriteLine("");
                //    Console.WriteLine(" Do you want to play again? Y / N");
                //    selection = Console.ReadLine();
                //    if (selection == "Y")
                //    {
                //        playAgain = "true";
                //    }
                //    else 
                //    {
                //        playAgain = "false";
                //    }
                //}
                //if (D == E & E == F)
                //{
                //    won = "true";
                //    Console.WriteLine("Congratulations! " + player2 + "won!");
                //    Console.WriteLine("");
                //    Console.WriteLine(" Do you want to play again? Y / N");
                //    selection = Console.ReadLine();
                //    if (selection == "Y")
                //    {
                //        playAgain = "true";
                //    }
                //    else 
                //    {
                //        playAgain = "false";
                //    }
                //}
                //if (G == H & H == I)
                //{
                //    won = "true";
                //    Console.WriteLine("Congratulations! " + player2 + "won!");
                //    Console.WriteLine("");
                //    Console.WriteLine(" Do you want to play again? Y / N");
                //    selection = Console.ReadLine();
                //    if (selection == "Y")
                //    {
                //        playAgain = "true";
                //    }
                //    else
                //    {
                //        playAgain = "false";
                //    }
                //}
                //if (A == D & D == G)
                //{
                //    won = "true";
                //    Console.WriteLine("Congratulations! " + player2 + "won!");
                //    Console.WriteLine("");
                //    Console.WriteLine(" Do you want to play again? Y / N");
                //    selection = Console.ReadLine();
                //    if (selection == "Y")
                //    {
                //        playAgain = "true";
                //    }
                //    else
                //    {
                //        playAgain = "false";
                //    }
                //}
                //if (B == E & E == H)
                //{
                //    won = "true";
                //    Console.WriteLine("Congratulations! " + player2 + "won!");
                //    Console.WriteLine("");
                //    Console.WriteLine(" Do you want to play again? Y / N");
                //    selection = Console.ReadLine();
                //    if (selection == "Y")
                //    {
                //        playAgain = "true";
                //    }
                //    else
                //    {
                //        playAgain = "false";
                //    }
                //}
                //if (C == F & F == I)
                //{
                //    won = "true";
                //    Console.WriteLine("Congratulations! " + player2 + "won!");
                //    Console.WriteLine("");
                //    Console.WriteLine(" Do you want to play again? Y / N");
                //    selection = Console.ReadLine();
                //    if (selection == "Y")
                //    {
                //        playAgain = "true";
                //    }
                //    else
                //    {
                //        playAgain = "false";
                //    }
                //}
                //if (G == E & E == C)
                //{
                //    won = "true";
                //    Console.WriteLine("Congratulations! " + player2 + "won!");
                //    Console.WriteLine("");
                //    Console.WriteLine(" Do you want to play again? Y / N");
                //    selection = Console.ReadLine();
                //    if (selection == "Y")
                //    {
                //        playAgain = "true";
                //    }
                //    else
                //    {
                //        playAgain = "false";
                //    }
                //}
                //if (A == E & E == I)
                //{
                //    won = "true";
                //    Console.WriteLine("Congratulations! " + player2 + "won!");
                //    Console.WriteLine("");
                //    Console.WriteLine(" Do you want to play again? Y / N");
                //    selection = Console.ReadLine();
                //    if (selection == "Y")
                //    {
                //        playAgain = "true";
                //    }
                //    else
                //    {
                //        playAgain = "false";
                //    }
                //}
    }
=======
            }
>>>>>>> 8b36820ed03d6f951d7659cb0cea6116222b63d0
            if (won == "false")
            {
                goto Start;
            }
            if (playAgain == "true")
            {
                A = "1";
                B = "2";
                C = "3";
                D = "4";
                E = "5";
                F = "6";
                G = "7";
                H = "8";
                I = "9";
                goto Start;
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
