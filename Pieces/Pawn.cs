using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Chess.Util;

namespace Chess
{
    public class Pawn : Piece
    {
        public List<int> Moves { get; set; }

        public Pawn()
        {
            Moves = new List<int>();
            Moves.Add((int)Direction.TopLeft);
            Moves.Add((int)Direction.TopRight);
            Moves.Add((int)Direction.Top);
        }
    }
}