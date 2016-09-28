using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess
{
    public class Game
    {
        Board board = new Board();

        public bool move(bool isWhite, int src, int dst)
        {
            throw new Exception();
        }
        public void reset(bool IsWhite)
        {
            this.Begin();
        }

        public void Begin()
        {
            board.pieces = new Piece[8,8];

            board.pieces[0, 0] = new Rook();
            board.pieces[0, 1] = new Knight();
            board.pieces[0, 2] = new Bishop();
            board.pieces[0, 3] = new King();
            board.pieces[0, 4] = new Queen();
            board.pieces[0, 5] = new Bishop();
            board.pieces[0, 6] = new Knight();
            board.pieces[0, 7] = new Rook();
        }
    }
}