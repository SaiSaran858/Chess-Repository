using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess
{
    public class Board
    {
        public Piece[,] pieces = null;

        public Piece getPeice(int location)
        {
            var pos = Piece.GetLocation(location);
            return pieces[pos.Item1, pos.Item2];
        }
        public void removePeice(int location)
        {
            var pos = Piece.GetLocation(location);
            pieces[pos.Item1, pos.Item2] = null;
        }
        public bool move(int srcLoc, int destLoc)
        {
            var srcPos = Piece.GetLocation(srcLoc);
            var destPos = Piece.GetLocation(destLoc);

            var srcPiece = pieces[srcPos.Item1, srcPos.Item2];
            pieces[srcPos.Item1, srcPos.Item2] = null;

            pieces[destPos.Item1, destPos.Item2] = srcPiece;

            return true;
        }
        public int whereIs(Piece piece)
        {
            throw new Exception();
        }
        public void setPeice(Piece piece, int place)
        {
            pieces[place / 8, place % 8] = piece;
        }
    }
}