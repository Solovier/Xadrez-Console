﻿using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace ChessGame
{
    public class King : Chessman {

        public King(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }

        public override string ToString()
        {
            return $"R";
        }

        private bool CanMove(Position position)
        {
            Chessman chessman = Board.ChessPiece(position);
            return chessman == null || chessman.PieceColor != PieceColor;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] chessmanPossibleMoves = new bool[Board.Rows, Board.Columns];

            Position movementPosition = new Position(0, 0);

            movementPosition.SetValues(PiecePosition.Row - 1, PiecePosition.Column);
            if(Board.ValidatePosition(movementPosition) && CanMove(movementPosition))
            {
                chessmanPossibleMoves[movementPosition.Row, movementPosition.Column] = true;
            }

            movementPosition.SetValues(PiecePosition.Row - 1, PiecePosition.Column + 1);
            if (Board.ValidatePosition(movementPosition) && CanMove(movementPosition))
            {
                chessmanPossibleMoves[movementPosition.Row, movementPosition.Column] = true;
            }

            movementPosition.SetValues(PiecePosition.Row + 1, PiecePosition.Column + 1);
            if (Board.ValidatePosition(movementPosition) && CanMove(movementPosition))
            {
                chessmanPossibleMoves[movementPosition.Row, movementPosition.Column] = true;
            }

            movementPosition.SetValues(PiecePosition.Row + 1, PiecePosition.Column);
            if (Board.ValidatePosition(movementPosition) && CanMove(movementPosition))
            {
                chessmanPossibleMoves[movementPosition.Row, movementPosition.Column] = true;
            }

            movementPosition.SetValues(PiecePosition.Row + 1, PiecePosition.Column - 1);
            if (Board.ValidatePosition(movementPosition) && CanMove(movementPosition))
            {
                chessmanPossibleMoves[movementPosition.Row, movementPosition.Column] = true;
            }

            movementPosition.SetValues(PiecePosition.Row, PiecePosition.Column - 1);
            if (Board.ValidatePosition(movementPosition) && CanMove(movementPosition))
            {
                chessmanPossibleMoves[movementPosition.Row, movementPosition.Column] = true;
            }

            movementPosition.SetValues(PiecePosition.Row - 1, PiecePosition.Column - 1);
            if (Board.ValidatePosition(movementPosition) && CanMove(movementPosition))
            {
                chessmanPossibleMoves[movementPosition.Row, movementPosition.Column] = true;
            }

            return chessmanPossibleMoves;
        }

    }
}
