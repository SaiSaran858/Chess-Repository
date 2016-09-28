using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Chess.Util;

namespace Chess
{
    public class Rook : Piece
    {
        public Rook()
        {
            Moves = new List<int>();
            Moves.Add((int)Direction.Left);
            Moves.Add((int)Direction.Right);
            Moves.Add((int)Direction.Bottom);
            Moves.Add((int)Direction.Top);
        }

        public bool isValidMove(Direction dir, int dest)
        {
            var isDirectionValid = Moves.Contains((int)dir);
            return isDirectionValid;
        }
    }

}