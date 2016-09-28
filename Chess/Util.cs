using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess
{
    public class Util
    {
        public enum Direction
        {
            Top, Left, Right, Bottom, TopLeft, TopRight, BottomLeft, BottomRight
        }
          
        public enum PieceType
        {
            King, Queen, Pawn, Knight, Bishop,Rook
        }
    }
}