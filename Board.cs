using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        // Properties
        public int Size { get; set; }
        // Create a 2D array of cells
        public Cell[,] TheGrid { get; set; }
        // Constructor
        // Create a new board with a given size
        public Board(int s)
        {
            Size = s;
            TheGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j] = new Cell(i, j);
                }
            }
        }
        // Method to clear the board
        public void ClearBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j].IsCurrentlyOccupied = "";
                    TheGrid[i, j].IsLegalNextMove = false;
                }
            }
        }

        public void MarkNextLegalMoves(Cell targetCell, string chessPiece)
        {
            // Method to mark the legal moves for a given piece
            ClearBoard();
            switch (chessPiece)
            {
                case "Knight":
                    targetCell.IsCurrentlyOccupied = "N";
                    // up 2 right 1
                    TheGrid[targetCell.Row + 2, targetCell.Column + 1].IsLegalNextMove = true;
                    // up 2 left 1
                    TheGrid[targetCell.Row + 2, targetCell.Column - 1].IsLegalNextMove = true;
                    // down 2 right 1
                    TheGrid[targetCell.Row - 2, targetCell.Column + 1].IsLegalNextMove = true;
                    // down 2 left 1
                    TheGrid[targetCell.Row - 2, targetCell.Column - 1].IsLegalNextMove = true;
                    // up 1 right 2
                    TheGrid[targetCell.Row + 1, targetCell.Column + 2].IsLegalNextMove = true;
                    // up 1 left 2
                    TheGrid[targetCell.Row + 1, targetCell.Column - 2].IsLegalNextMove = true;
                    // down 1 right 2
                    TheGrid[targetCell.Row - 1, targetCell.Column + 2].IsLegalNextMove = true;
                    // down 1 left 2
                    TheGrid[targetCell.Row - 1, targetCell.Column - 2].IsLegalNextMove = true;
                    break;

                case "Rook":
                    targetCell.IsCurrentlyOccupied = "R";
                    // up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column].IsLegalNextMove = true;
                    // down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column].IsLegalNextMove = true;
                    // up 2
                    TheGrid[targetCell.Row + 2, targetCell.Column].IsLegalNextMove = true;
                    // down 2
                    TheGrid[targetCell.Row - 2, targetCell.Column].IsLegalNextMove = true;
                    // up 3
                    TheGrid[targetCell.Row + 3, targetCell.Column].IsLegalNextMove = true;
                    // down 3
                    TheGrid[targetCell.Row - 3, targetCell.Column].IsLegalNextMove = true;
                    // up 4
                    TheGrid[targetCell.Row + 4, targetCell.Column].IsLegalNextMove = true;
                    // down 4
                    TheGrid[targetCell.Row - 4, targetCell.Column].IsLegalNextMove = true;
                    // up 5
                    TheGrid[targetCell.Row + 5, targetCell.Column].IsLegalNextMove = true;
                    // down 5
                    TheGrid[targetCell.Row - 5, targetCell.Column].IsLegalNextMove = true;
                    // up 6
                    TheGrid[targetCell.Row + 6, targetCell.Column].IsLegalNextMove = true;
                    // down 6
                    TheGrid[targetCell.Row - 6, targetCell.Column].IsLegalNextMove = true;
                    // up 7
                    TheGrid[targetCell.Row + 7, targetCell.Column].IsLegalNextMove = true;
                    // down 7
                    TheGrid[targetCell.Row - 7, targetCell.Column].IsLegalNextMove = true;
                    // up 8
                    TheGrid[targetCell.Row + 8, targetCell.Column].IsLegalNextMove = true;
                    // down 8
                    TheGrid[targetCell.Row - 8, targetCell.Column].IsLegalNextMove = true;
                    // right 1
                    TheGrid[targetCell.Row, targetCell.Column + 1].IsLegalNextMove = true;
                    // left 1
                    TheGrid[targetCell.Row, targetCell.Column - 1].IsLegalNextMove = true;
                    // right 2
                    TheGrid[targetCell.Row, targetCell.Column + 2].IsLegalNextMove = true;
                    // left 2
                    TheGrid[targetCell.Row, targetCell.Column - 2].IsLegalNextMove = true;
                    // right 3
                    TheGrid[targetCell.Row, targetCell.Column + 3].IsLegalNextMove = true;
                    // left 3
                    TheGrid[targetCell.Row, targetCell.Column - 3].IsLegalNextMove = true;
                    // right 4
                    TheGrid[targetCell.Row, targetCell.Column + 4].IsLegalNextMove = true;
                    // left 4
                    TheGrid[targetCell.Row, targetCell.Column - 4].IsLegalNextMove = true;
                    // right 5
                    TheGrid[targetCell.Row, targetCell.Column + 5].IsLegalNextMove = true;
                    // left 5
                    TheGrid[targetCell.Row, targetCell.Column - 5].IsLegalNextMove = true;
                    // right 6
                    TheGrid[targetCell.Row, targetCell.Column + 6].IsLegalNextMove = true;
                    // left 6
                    TheGrid[targetCell.Row, targetCell.Column - 6].IsLegalNextMove = true;
                    // right 7
                    TheGrid[targetCell.Row, targetCell.Column + 7].IsLegalNextMove = true;
                    // left 7
                    TheGrid[targetCell.Row, targetCell.Column - 7].IsLegalNextMove = true;
                    // right 8
                    TheGrid[targetCell.Row, targetCell.Column + 8].IsLegalNextMove = true;
                    // left 8
                    TheGrid[targetCell.Row, targetCell.Column - 8].IsLegalNextMove = true;
                    break;

                case "Bishop":
                    targetCell.IsCurrentlyOccupied = "B";
                    // right diagonal up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column + 1].IsLegalNextMove = true;
                    // right diagonal down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column + 1].IsLegalNextMove = true;
                    // right diagonal up 2
                    TheGrid[targetCell.Row + 2, targetCell.Column + 2].IsLegalNextMove = true;
                    // right diagonal down 2
                    TheGrid[targetCell.Row - 2, targetCell.Column + 2].IsLegalNextMove = true;
                    // right diagonal up 3
                    TheGrid[targetCell.Row + 3, targetCell.Column + 3].IsLegalNextMove = true;
                    // right diagonal down 3
                    TheGrid[targetCell.Row - 3, targetCell.Column + 3].IsLegalNextMove = true;
                    // right diagonal up 4
                    TheGrid[targetCell.Row + 4, targetCell.Column + 4].IsLegalNextMove = true;
                    // right diagonal down 4
                    TheGrid[targetCell.Row - 4, targetCell.Column + 4].IsLegalNextMove = true;
                    // right diagonal up 5
                    TheGrid[targetCell.Row + 5, targetCell.Column + 5].IsLegalNextMove = true;
                    // right diagonal down 5
                    TheGrid[targetCell.Row - 5, targetCell.Column + 5].IsLegalNextMove = true;
                    // right diagonal up 6
                    TheGrid[targetCell.Row + 6, targetCell.Column + 6].IsLegalNextMove = true;
                    // right diagonal down 6
                    TheGrid[targetCell.Row - 6, targetCell.Column + 6].IsLegalNextMove = true;
                    // right diagonal up 7
                    TheGrid[targetCell.Row + 7, targetCell.Column + 7].IsLegalNextMove = true;
                    // right diagonal down 7
                    TheGrid[targetCell.Row - 7, targetCell.Column + 7].IsLegalNextMove = true;
                    // right diagonal up 8
                    TheGrid[targetCell.Row + 8, targetCell.Column + 8].IsLegalNextMove = true;
                    // right diagonal down 8
                    TheGrid[targetCell.Row - 8, targetCell.Column + 8].IsLegalNextMove = true;
                    // left diagonal up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column - 1].IsLegalNextMove = true;
                    // left diagonal down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column - 1].IsLegalNextMove = true;
                    // left diagonal up 2
                    TheGrid[targetCell.Row + 2, targetCell.Column - 2].IsLegalNextMove = true;
                    // left diagonal down 2
                    TheGrid[targetCell.Row - 2, targetCell.Column - 2].IsLegalNextMove = true;
                    // left diagonal up 3
                    TheGrid[targetCell.Row + 3, targetCell.Column - 3].IsLegalNextMove = true;
                    // left diagonal down 3
                    TheGrid[targetCell.Row - 3, targetCell.Column - 3].IsLegalNextMove = true;
                    // left diagonal up 4
                    TheGrid[targetCell.Row + 4, targetCell.Column - 4].IsLegalNextMove = true;
                    // left diagonal down 4
                    TheGrid[targetCell.Row - 4, targetCell.Column - 4].IsLegalNextMove = true;
                    // left diagonal up 5
                    TheGrid[targetCell.Row + 5, targetCell.Column - 5].IsLegalNextMove = true;
                    // left diagonal down 5
                    TheGrid[targetCell.Row - 5, targetCell.Column - 5].IsLegalNextMove = true;
                    // left diagonal up 6
                    TheGrid[targetCell.Row + 6, targetCell.Column - 6].IsLegalNextMove = true;
                    // left diagonal down 6
                    TheGrid[targetCell.Row - 6, targetCell.Column - 6].IsLegalNextMove = true;
                    // left diagonal up 7
                    TheGrid[targetCell.Row + 7, targetCell.Column - 7].IsLegalNextMove = true;
                    // left diagonal down 7
                    TheGrid[targetCell.Row - 7, targetCell.Column - 7].IsLegalNextMove = true;
                    // left diagonal up 8
                    TheGrid[targetCell.Row + 8, targetCell.Column - 8].IsLegalNextMove = true;
                    // left diagonal down 8
                    TheGrid[targetCell.Row - 8, targetCell.Column - 8].IsLegalNextMove = true;
                    break;

                case "Queen":
                    targetCell.IsCurrentlyOccupied = "Q";
                    // up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column].IsLegalNextMove = true;
                    // down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column].IsLegalNextMove = true;
                    // up 2
                    TheGrid[targetCell.Row + 2, targetCell.Column].IsLegalNextMove = true;
                    // down 2
                    TheGrid[targetCell.Row - 2, targetCell.Column].IsLegalNextMove = true;
                    // up 3
                    TheGrid[targetCell.Row + 3, targetCell.Column].IsLegalNextMove = true;
                    // down 3
                    TheGrid[targetCell.Row - 3, targetCell.Column].IsLegalNextMove = true;
                    // up 4
                    TheGrid[targetCell.Row + 4, targetCell.Column].IsLegalNextMove = true;
                    // down 4
                    TheGrid[targetCell.Row - 4, targetCell.Column].IsLegalNextMove = true;
                    // up 5
                    TheGrid[targetCell.Row + 5, targetCell.Column].IsLegalNextMove = true;
                    // down 5
                    TheGrid[targetCell.Row - 5, targetCell.Column].IsLegalNextMove = true;
                    // up 6
                    TheGrid[targetCell.Row + 6, targetCell.Column].IsLegalNextMove = true;
                    // down 6
                    TheGrid[targetCell.Row - 6, targetCell.Column].IsLegalNextMove = true;
                    // up 7
                    TheGrid[targetCell.Row + 7, targetCell.Column].IsLegalNextMove = true;
                    // down 7
                    TheGrid[targetCell.Row - 7, targetCell.Column].IsLegalNextMove = true;
                    // up 8
                    TheGrid[targetCell.Row + 8, targetCell.Column].IsLegalNextMove = true;
                    // down 8
                    TheGrid[targetCell.Row - 8, targetCell.Column].IsLegalNextMove = true;
                    // right 1
                    TheGrid[targetCell.Row, targetCell.Column + 1].IsLegalNextMove = true;
                    // left 1
                    TheGrid[targetCell.Row, targetCell.Column - 1].IsLegalNextMove = true;
                    // right 2
                    TheGrid[targetCell.Row, targetCell.Column + 2].IsLegalNextMove = true;
                    // left 2
                    TheGrid[targetCell.Row, targetCell.Column - 2].IsLegalNextMove = true;
                    // right 3
                    TheGrid[targetCell.Row, targetCell.Column + 3].IsLegalNextMove = true;
                    // left 3
                    TheGrid[targetCell.Row, targetCell.Column - 3].IsLegalNextMove = true;
                    // right 4
                    TheGrid[targetCell.Row, targetCell.Column + 4].IsLegalNextMove = true;
                    // left 4
                    TheGrid[targetCell.Row, targetCell.Column - 4].IsLegalNextMove = true;
                    // right 5
                    TheGrid[targetCell.Row, targetCell.Column + 5].IsLegalNextMove = true;
                    // left 5
                    TheGrid[targetCell.Row, targetCell.Column - 5].IsLegalNextMove = true;
                    // right 6
                    TheGrid[targetCell.Row, targetCell.Column + 6].IsLegalNextMove = true;
                    // left 6
                    TheGrid[targetCell.Row, targetCell.Column - 6].IsLegalNextMove = true;
                    // right 7
                    TheGrid[targetCell.Row, targetCell.Column + 7].IsLegalNextMove = true;
                    // left 7
                    TheGrid[targetCell.Row, targetCell.Column - 7].IsLegalNextMove = true;
                    // right 8
                    TheGrid[targetCell.Row, targetCell.Column + 8].IsLegalNextMove = true;
                    // left 8
                    TheGrid[targetCell.Row, targetCell.Column - 8].IsLegalNextMove = true;
                    // right diagonal up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column + 1].IsLegalNextMove = true;
                    // right diagonal down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column + 1].IsLegalNextMove = true;
                    // right diagonal up 2
                    TheGrid[targetCell.Row + 2, targetCell.Column + 2].IsLegalNextMove = true;
                    // right diagonal down 2
                    TheGrid[targetCell.Row - 2, targetCell.Column + 2].IsLegalNextMove = true;
                    // right diagonal up 3
                    TheGrid[targetCell.Row + 3, targetCell.Column + 3].IsLegalNextMove = true;
                    // right diagonal down 3
                    TheGrid[targetCell.Row - 3, targetCell.Column + 3].IsLegalNextMove = true;
                    // right diagonal up 4
                    TheGrid[targetCell.Row + 4, targetCell.Column + 4].IsLegalNextMove = true;
                    // right diagonal down 4
                    TheGrid[targetCell.Row - 4, targetCell.Column + 4].IsLegalNextMove = true;
                    // right diagonal up 5
                    TheGrid[targetCell.Row + 5, targetCell.Column + 5].IsLegalNextMove = true;
                    // right diagonal down 5
                    TheGrid[targetCell.Row - 5, targetCell.Column + 5].IsLegalNextMove = true;
                    // right diagonal up 6
                    TheGrid[targetCell.Row + 6, targetCell.Column + 6].IsLegalNextMove = true;
                    // right diagonal down 6
                    TheGrid[targetCell.Row - 6, targetCell.Column + 6].IsLegalNextMove = true;
                    // right diagonal up 7
                    TheGrid[targetCell.Row + 7, targetCell.Column + 7].IsLegalNextMove = true;
                    // right diagonal down 7
                    TheGrid[targetCell.Row - 7, targetCell.Column + 7].IsLegalNextMove = true;
                    // right diagonal up 8
                    TheGrid[targetCell.Row + 8, targetCell.Column + 8].IsLegalNextMove = true;
                    // right diagonal down 8
                    TheGrid[targetCell.Row - 8, targetCell.Column + 8].IsLegalNextMove = true;
                    // left diagonal up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column - 1].IsLegalNextMove = true;
                    // left diagonal down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column - 1].IsLegalNextMove = true;
                    // left diagonal up 2
                    TheGrid[targetCell.Row + 2, targetCell.Column - 2].IsLegalNextMove = true;
                    // left diagonal down 2
                    TheGrid[targetCell.Row - 2, targetCell.Column - 2].IsLegalNextMove = true;
                    // left diagonal up 3
                    TheGrid[targetCell.Row + 3, targetCell.Column - 3].IsLegalNextMove = true;
                    // left diagonal down 3
                    TheGrid[targetCell.Row - 3, targetCell.Column - 3].IsLegalNextMove = true;
                    // left diagonal up 4
                    TheGrid[targetCell.Row + 4, targetCell.Column - 4].IsLegalNextMove = true;
                    // left diagonal down 4
                    TheGrid[targetCell.Row - 4, targetCell.Column - 4].IsLegalNextMove = true;
                    // left diagonal up 5
                    TheGrid[targetCell.Row + 5, targetCell.Column - 5].IsLegalNextMove = true;
                    // left diagonal down 5
                    TheGrid[targetCell.Row - 5, targetCell.Column - 5].IsLegalNextMove = true;
                    // left diagonal up 6
                    TheGrid[targetCell.Row + 6, targetCell.Column - 6].IsLegalNextMove = true;
                    // left diagonal down 6
                    TheGrid[targetCell.Row - 6, targetCell.Column - 6].IsLegalNextMove = true;
                    // left diagonal up 7
                    TheGrid[targetCell.Row + 7, targetCell.Column - 7].IsLegalNextMove = true;
                    // left diagonal down 7
                    TheGrid[targetCell.Row - 7, targetCell.Column - 7].IsLegalNextMove = true;
                    // left diagonal up 8
                    TheGrid[targetCell.Row + 8, targetCell.Column - 8].IsLegalNextMove = true;
                    // left diagonal down 8
                    TheGrid[targetCell.Row - 8, targetCell.Column - 8].IsLegalNextMove = true;
                    break;

                case "King":
                    targetCell.IsCurrentlyOccupied = "K";
                    // up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column].IsLegalNextMove = true;
                    // down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column].IsLegalNextMove = true;
                    // right 1
                    TheGrid[targetCell.Row, targetCell.Column + 1].IsLegalNextMove = true;
                    // left 1
                    TheGrid[targetCell.Row, targetCell.Column - 1].IsLegalNextMove = true;
                    // right diagonal up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column + 1].IsLegalNextMove = true;
                    // right diagonal down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column + 1].IsLegalNextMove = true;
                    // left diagonal up 1
                    TheGrid[targetCell.Row + 1, targetCell.Column - 1].IsLegalNextMove = true;
                    // left diagonal down 1
                    TheGrid[targetCell.Row - 1, targetCell.Column - 1].IsLegalNextMove = true;
                    break;
            
            }
        }

        public bool IsOnTheBoard(int row, int col)
        {
            return false;
        }

    }
}
