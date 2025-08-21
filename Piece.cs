using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_WPF
{
    public abstract class Piece
    {
        public enum Color
        {
            White,
            Black
        }

        public Color PieceColor { get; set; }
        public (int Row, int Col) Position { get; set; }
        public string Name { get; protected set; }

        public Piece(Color color, int row, int col)
        {
            PieceColor = color;
            Position = (row, col);
        }

        // проверка допустимых ходов
        public abstract bool IsValidMove(int targetRow, int targetCol, Piece[,] board);

        // ход
        public void Move(int targetRow, int targetCol)
        {
            Position = (targetRow, targetCol);
        }

        public override string ToString()
        {
            return $"{PieceColor} {Name}";
        }
    }

}