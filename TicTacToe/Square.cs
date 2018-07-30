using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Square
    {
        public int Row { get; }
        public int Column { get; }

        public string Mark { get; set; } = "-";

        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }

        // change state of square based on user's choosing
        public void PlaySquare(string player)
        {
            this.Mark = player;
        }
    }
}
