using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Cell
    {
        // Properties
        public int Row { get; set; }
        public int Column { get; set; }
        public string IsCurrentlyOccupied { get; set; }
        public bool IsLegalNextMove { get; set; }

        // Constructor
        public Cell(int row, int column)
        {
            // Initialize the properties
            // Each cell has a row and column
            Row = row;
            Column = column;
            //Default values
            // Cells are not occupied nor is it legal to move next to them
            IsCurrentlyOccupied = string.Empty;
            IsLegalNextMove = false;
        }
    }
}
