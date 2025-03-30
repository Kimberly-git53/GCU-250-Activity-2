using ChessBoardModel;
using System.Security.Cryptography.X509Certificates;

namespace ChessBoardConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print a welcome message
            Console.WriteLine("Hello, chess players!");
            // Create a new board
            Board board = new Board(8);
            PrintBoard(board);

            // Ask the user for the row and column number to place the piece
            Console.WriteLine("Enter a row number (0-7) for the piece: ");
            // Validate the user input
            int row = ValidateInput(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter a column number (0-7) for the piece: ");
            // Validate the user input
            int column = ValidateInput(int.Parse(Console.ReadLine()));
            // Ask the user for the piece they would like to place
            Console.WriteLine("What type of piece do you want to place on the board? (Knight, Rook, Bishop, Queen, King, Pawn) ");
            string piece = Console.ReadLine();

            //Use the board class to set the piece and mark the legal moves
            board.MarkNextLegalMoves(board.TheGrid[row, column], piece);
            // Print the board
            PrintBoard(board);

        }

        // Print the board
        private static void PrintBoard(Board board)
        {
            // Print column headers
            PrintColumnHeaders(board.Size);

            // Print the board rows 
            for (int row = 0; row < board.Size; row++)
            {
                PrintRowBorder(board.Size);   // Top border of the row
                PrintRowContents(board, row); // Contents of the row
            }

            // Print the bottom border of the board
            PrintRowBorder(board.Size);
        }
        // Helper methods to print the board columns
        private static void PrintColumnHeaders(int size)
        {
            Console.Write("   "); // Space for row numbers
            for (int col = 0; col < size; col++)
            {
                Console.Write($" {col}  "); // Column numbers
            }
            Console.WriteLine();
        }
        // Helper methods to print the top and bottom border of the board
        private static void PrintRowBorder(int size)
        {
            Console.Write("   "); // Space for row numbers
            for (int col = 0; col < size; col++)
            {
                Console.Write("+---"); // Top of each cell
            }
            Console.WriteLine("+");
        }
        // Print the contents of the board rows
        private static void PrintRowContents(Board board, int row)
        {
            // Row number
            Console.Write($" {row} ");
            // Print the contents of each cell
            for (int col = 0; col < board.Size; col++)
            {
                Console.Write("|");
                var cell = board.TheGrid[row, col];
                // If the cell is a legal move, print a "+"
                if (cell.IsLegalNextMove)
                {
                    Console.Write(" + ");
                }
                // If the cell is occupied, print the piece
                else if (!string.IsNullOrEmpty(cell.IsCurrentlyOccupied))
                {
                    Console.Write($" {cell.IsCurrentlyOccupied} ");
                }
                // Otherwise, print empty space
                else
                {
                    Console.Write("   ");
                }
            }
            Console.WriteLine("|"); // End of the row
        }


        // Method validating user input
        private static int ValidateInput(int input)
        {
            // While the input is not between 0 and 7, ask the user to enter a valid number
            while (input < 0 || input > 7)
            {
                // Print an error message
                Console.WriteLine("Invalid input. Please enter a number between 0 and 7.");
                // Read the input again
                input = int.Parse(Console.ReadLine());
            }
            // Return the valid input
            return input;
        }

    }
}
