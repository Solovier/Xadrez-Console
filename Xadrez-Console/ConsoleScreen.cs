﻿using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;
using ChessGame;

namespace Xadrez_Console
{
    public class ConsoleScreen
    {
        public static void PrintChessBoard(ChessBoard chessBoard)
        {
            for(int row = 0; row<chessBoard.Rows; row++)
            {
                Console.Write($"{8 - row} ");
                for(int column=0; column<chessBoard.Columns; column++)
                {
                    PrintChessman(chessBoard.ChessPiece(row, column));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void PrintChessBoard(ChessBoard chessBoard, bool[,] possiblePositions)
        {
            ConsoleColor standardBackground = Console.BackgroundColor;
            ConsoleColor markBackground = ConsoleColor.DarkGray;

            for (int row = 0; row < chessBoard.Rows; row++)
            {
                Console.Write($"{8 - row} ");
                for (int column = 0; column < chessBoard.Columns; column++)
                {
                    if(possiblePositions[row, column])
                    {
                        Console.BackgroundColor = markBackground;
                    }
                    else
                    {
                        Console.BackgroundColor = standardBackground;
                    }
                    PrintChessman(chessBoard.ChessPiece(row, column));
                    Console.BackgroundColor = standardBackground;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static ChessBoardPositioning ReadChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse($"{s[1]}");
            return new ChessBoardPositioning(column, row);
        }

        public static void PrintChessman(Chessman chessman)
        {
            if(chessman == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (chessman.PieceColor == Color.White)
                {
                    Console.Write(chessman);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(chessman);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
