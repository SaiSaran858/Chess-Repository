using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Chess.Util;

namespace Chess.Pieces
{
    public abstract class Piece
    {
        public PieceType Type { get; set; }

        public bool IsWhite { get; set; }
        public List<int> Moves { get; set; }


        public static int GetLocation(int x, int y)
        {
            throw new Exception();
        }

        public static Tuple<int,int> GetLocation(int index)
        {
            return new Tuple<int, int>(index / 8, index % 8);
        }
    }
}