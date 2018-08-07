﻿using System;
using Tabuleiro;
using ChessGame;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessBoard chessBoard = new ChessBoard(8, 8);

                chessBoard.PrintChessPiece(new Tower(chessBoard, Color.Black), new Position(0, 0));
                chessBoard.PrintChessPiece(new Tower(chessBoard, Color.Black), new Position(1, 3));
                chessBoard.PrintChessPiece(new King(chessBoard, Color.Black), new Position(2, 4));

                chessBoard.PrintChessPiece(new Tower(chessBoard, Color.White), new Position(5, 3));
                chessBoard.PrintChessPiece(new King(chessBoard, Color.White), new Position(4, 4));

                ConsoleScreen.PrintChessBoard(chessBoard);
            }
            catch(ChessBoardException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
