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

        public bool move(bool isWhite, string src, string dst)
        {
            string srcValue = ConvertStringToPositions(src);
            string dstValue = ConvertStringToPositions(dst);
            dstValue = srcValue;

            return true;
        }

        public string ConvertStringToPositions(string strValue)
        {
            char[] array = strValue.ToCharArray();
            var IsIndex0Char = (int)array[0] >= 97 && (int)array[0] <= 104;
            var IsIndex1Char = (int)array[1] >= 97 && (int)array[1] <= 104;

            if (IsIndex0Char)
            {
                strValue = string.Concat(GetIndexOfchar(array[0]), array[1]);
            }
            else if (IsIndex1Char)
            {
                strValue = string.Concat(array[0], GetIndexOfchar(array[1]));
            }

            return strValue;
        }

        public int GetIndexOfchar(char ch)
        {
            return (int)ch - 97;

        }

        public void reset(bool IsWhite)
        {
            this.Begin(IsWhite);
        }

        public bool IsWhiteSelected { get; set; }

        public void Begin(bool IsWhite)
        {
            IsWhiteSelected = IsWhite;

            board.pieces = new Piece[8, 8];

            //Top Row 1
            board.pieces[0, 0] = new Rook();
            board.pieces[0, 1] = new Knight();
            board.pieces[0, 2] = new Bishop();
            board.pieces[0, 3] = new King();
            board.pieces[0, 4] = new Queen();
            board.pieces[0, 5] = new Bishop();
            board.pieces[0, 6] = new Knight();
            board.pieces[0, 7] = new Rook();

            //Top Row 2
            for (int i = 0; i < 8; i++)
                board.pieces[1, i] = new Pawn();

            //Bottom Row 1
            board.pieces[7, 0] = new Rook();
            board.pieces[7, 1] = new Knight();
            board.pieces[7, 2] = new Bishop();
            board.pieces[7, 3] = new King();
            board.pieces[7, 4] = new Queen();
            board.pieces[7, 5] = new Bishop();
            board.pieces[7, 6] = new Knight();
            board.pieces[7, 7] = new Rook();

            //Bottom Row 2
            for (int i = 0; i < 8; i++)
                board.pieces[6, i] = new Pawn();



        }
    }
}