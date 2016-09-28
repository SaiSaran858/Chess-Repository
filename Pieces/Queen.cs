using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Chess.Util;

namespace Chess.Pieces
{
    public class Queen : Piece
    {
        private int position;
        private bool IsColor;

        public Queen()
        {
            Moves = new List<int>();
            Moves.Add((int)Direction.Left);
            Moves.Add((int)Direction.Right);
            Moves.Add((int)Direction.Bottom);
            Moves.Add((int)Direction.Top);
            Moves.Add((int)Direction.TopLeft);
            Moves.Add((int)Direction.TopRight);
            Moves.Add((int)Direction.BottomRight);
            Moves.Add((int)Direction.BottomLeft);
        }
        public bool isValidMove(Direction dir, int dest)
        {
            var isDirectionValid = Moves.Contains((int)dir);
            return isDirectionValid;
        }

        public void move(Direction dir)
        {
          
        }
    }
}