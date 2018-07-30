using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        private Square[,] State = new Square[3, 3];

        public Board(Square[,] state)
        {
            this.State = state;
        }

        // method to draw board
        public void Draw()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" {State[i, 0].Mark} | {State[i, 1].Mark} | {State[i, 2].Mark} ");
                Console.WriteLine($"-----------");
            }
        }

        // method to play move
        public void Move(int player, string mark)
        {

            int row = 0;
            int column = 0;
            while (true)
            {
                // ask user for a space to play
                Console.WriteLine($"Choose a row, player {player}.");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Choose a column, player {player}.");
                column = Convert.ToInt32(Console.ReadLine());

                if (isValidMove(row, column))
                {
                    break;
                }
            }

            // plays move
            State[row - 1, column - 1].Mark = mark;
        }

        // method validate move
        public bool isValidMove(int row, int column)
        {
            if (row < 1 || row > 3 || column < 1 || column > 3)
            {
                return false;
            }

            if (State[row - 1, column - 1].Mark != "-")
            {
                return false;
            }

            return true;
        }

        // method to check tie
        public bool CheckTie()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (State[i, j].Mark == "-")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // method to check winner

        public bool CheckWin()
        {
            // check rows
            for (int i = 0; i < 3; i++)
            {
                if (State[i, 0].Mark != "-" && State[i, 0].Mark == State[i, 1].Mark && State[i, 1].Mark == State[i, 2].Mark)
                {
                    return true;
                }
            }

            // check columns
            for (int i = 0; i < 3; i++)
            {
                if (State[0, i].Mark != "-" && State[0, i].Mark == State[1, i].Mark && State[1, i].Mark == State[2, i].Mark)
                {
                    return true;
                }
            }

            // check diagonals
            if (State[0, 0].Mark != "-" && State[0, 0].Mark == State[1, 1].Mark && State[1, 1].Mark == State[2, 2].Mark)
            {
                return true;
            }

            if (State[0, 2].Mark != "-" && State[0, 2].Mark == State[1, 1].Mark && State[1, 1].Mark == State[2, 0].Mark)
            {
                return true;
            }

            return false;
        }

    }
}
