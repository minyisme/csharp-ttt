using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        // add comment test build release process
        // public enum players { x=1, o=2 };

        static void Main(string[] args)
        {
            // instantiating each square
            Square sq1 = new Square(1, 1);
            Square sq2 = new Square(1, 2);
            Square sq3 = new Square(1, 3);
            Square sq4 = new Square(2, 1);
            Square sq5 = new Square(2, 2);
            Square sq6 = new Square(2, 3);
            Square sq7 = new Square(3, 1);
            Square sq8 = new Square(3, 2);
            Square sq9 = new Square(3, 3);

            Square[,] gameboard = new Square[,] { { sq1, sq2, sq3}, { sq4, sq5, sq6}, { sq7, sq8, sq9} };

            // instantiating the board
            Board board = new Board(gameboard);

            // initial setup
            bool tie = false;
            bool win = false;
            int player = 1;

            // loop through until win or tie
            // switch users
            // let user draw on the board
            // draw board
            // check win
            // check tie

            board.Draw();
            while (!win && !tie)
            {
                switch (player)
                {
                    case 1:
                        {
                            // player plays
                            board.Move(1, "x");

                            // change player
                            player = 2;

                            break;
                        }
                    case 2:
                        {
                            // player plays
                            board.Move(2, "o");

                            // change player
                            player = 1;

                            break;
                        }
                }

                win = board.CheckWin();
                tie = board.CheckTie();
                board.Draw();

                if (win && player == 2)
                {
                    Console.WriteLine("Player 1 has won");
                    break;
                }
                else if (win && player == 1)
                {
                    Console.WriteLine("Player 2 has won");
                    break;
                }
                else if (tie)
                {
                    Console.WriteLine("There is a tie.");
                    break;
                }

            }
            Console.ReadKey();
        }
    }
}
