using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_WPF;

namespace Chess_Logic.Pieces
{
    internal class Pawn : Piece
    {
        // возможность первого хода на две клетки
        public bool IsFirstMove { get; private set; } = true;

        public Pawn(Color color, int row, int col) : base(color, row, col)
        {
            Name = "Pawn";
        }

        //проверка хода
        public override bool IsValidMove(int targetRow, int targetCol, Piece[,] board)
        {
            //направление движения
            int direction = PieceColor == Color.White ? 1 : -1;

            int startRow = PieceColor == Color.White ? 1 : 6;

            //первый ход на 2 клетки


            //движение вперед на 1
            if(targetCol == Position.Col && targetRow == Position.Row + direction)
            {
                if (board[targetRow, targetCol] == null)
                {
                    return true;
                } 
            }
            //съедение другой фигуры


            return false;
        }
        //выполнение хода
        public new void Move(int targetRow, int targetCol)
        {
            base.Move(targetRow, targetCol);
            IsFirstMove = false;
        }
    }
}
