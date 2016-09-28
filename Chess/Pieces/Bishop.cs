using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Chess.Util;

namespace Chess
{
    public class Bishop : Piece
    {
        private int position;
        private bool IsColor;


        public Bishop()
        {
            Type = PieceType.Bishop;

            Moves = new List<int>();
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