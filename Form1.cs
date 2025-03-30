using ChessBoardModel;

namespace ChessBoardGUIApp
{
    public partial class frmChessBoard : Form
    {
        public Board myBoard = new Board(8);
        public Button[,] buttons = new Button[8, 8];
        public frmChessBoard()
        {
            InitializeComponent();
            SetupButton();
        }
        // Populate the panel with buttons in a grid. (8x8)
        private void SetupButton()
        {
            // Calculate the button size. Panel width / 8 = size of one button
            int buttonSize = panelChessBoard.Width / myBoard.Size;
            // Force the panel to be square
            panelChessBoard.Height = panelChessBoard.Width;
            // Create the buttons
            for (int col = 0; col < myBoard.Size; col++)
            {
                for (int row = 0; row < myBoard.Size; row++)
                {
                    // Dynamically create the button and place it on the panel
                    buttons[row, col] = new Button();
                    // button is square
                    buttons[row, col].Width = buttonSize;
                    buttons[row, col].Height = buttonSize;
                    // Left = left side of button. Each button is buttonsSize wide
                    buttons[row, col].Left = row * buttonSize;
                    buttons[row, col].Top = col * buttonSize;
                    // Attach an event to the button 
                    buttons[row, col].Click += GridButtons_Click; // mannually add this event handler to the buttons
                    // The tag property can store an object. We will use it to store the row and column of the button
                    buttons[row, col].Tag = new Point(row, col);

                    // Set the face of the button to be the coordinates 
                    buttons[row, col].Text = row + " , " + col;
                    // Add the button to the panel
                    panelChessBoard.Controls.Add(buttons[row, col]);
                }
            }
        }
        // Global variable for the selected piece
        private string selecetedPiece;

        // ComboBox1 SelectedIndexChanged event
        private void comboPieceNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecetedPiece = comboPieceNames.SelectedItem.ToString();
        }

        // GridButtons_Click method
        private void GridButtons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Point p = (Point)b.Tag;
            int row = p.X;
            int col = p.Y;


            MessageBox.Show("You clicked on row " + row + " and column " + col);


            myBoard.MarkNextLegalMoves(myBoard.TheGrid[row, col], selecetedPiece);
            UpdateButttonFaces(myBoard);
        }
        // Updating button cells with the piece name and legal moves
        private void UpdateButttonFaces(Board myBoard)
        {
            //Map N to Knight. K to King. Q to Queen. B to Bishop. R to Rook. P to Pawn
            var pieceMap = new Dictionary<string, string>
            {
                {"N", "Knight"},
                {"K", "King"},
                {"Q", "Queen"},
                {"B", "Bishop"},
                {"R", "Rook"},
                {"P", "Pawn"}
            };
            // for loop to update the button text
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    // Enable only the legal moves (prevents out of bounds click actions
                    buttons[i, j].Enabled = myBoard.TheGrid[i, j].IsLegalNextMove;
                    // Clear the button text
                    buttons[i, j].Text = " ";
                    // If the cell is a legal move, set the button text to "Legal Move"
                    if (myBoard.TheGrid[i, j].IsLegalNextMove)
                        buttons[i, j].Text = "Legal Move";
                    // If the cell is occupied, set the button text to the piece name
                    if (myBoard.TheGrid[i, j].IsCurrentlyOccupied != "")

                        // map the occupied by letter to the name
                        // Example: N to Knight
                        buttons[i, j].Text = pieceMap[myBoard.TheGrid[i, j].IsCurrentlyOccupied];

                    // Color sets for button themes
                    // 2d array of colors
                    Color[,] colorThemes = { {  ColorTranslator.FromHtml("#000943"), ColorTranslator.FromHtml("#6f2a9b"),
                    ColorTranslator.FromHtml("#694d00"), ColorTranslator.FromHtml("#bf406c") },
                        { ColorTranslator.FromHtml("#886897"), ColorTranslator.FromHtml("#779768"),
                        ColorTranslator.FromHtml("#54aba6"), ColorTranslator.FromHtml("#ab5459") }, {ColorTranslator.FromHtml("#dcc523"),
                            ColorTranslator.FromHtml("#97dc23"), ColorTranslator.FromHtml("#dc6823"), ColorTranslator.FromHtml("#e9167e")}
                        };

                    
                    Color color1 = colorThemes[0, 0];
                    Color color2 = colorThemes[0, 1];
                    Color color3 = colorThemes[0, 2];
                    Color color4 = colorThemes[0, 3]; 


                    if (radioButton1.Checked)
                    {
                        color1 = colorThemes[0, 0];
                        color2 = colorThemes[0, 1];
                        color3 = colorThemes[0, 2];
                        color4 = colorThemes[0, 3];

                    }
                    else if (radioButton2.Checked)
                    {
                        color1 = colorThemes[1, 0];
                        color2 = colorThemes[1, 1];
                        color3 = colorThemes[1, 2];
                        color4 = colorThemes[1, 3];

                    }
                    else if (radioButton3.Checked)
                    {
                        color1 = colorThemes[2, 0];
                        color2 = colorThemes[2, 1];
                        color3 = colorThemes[2, 2];
                        color4 = colorThemes[2, 3];

                    }

                    // checkerboard pattern the mod operator % returns the remainder of division. 5 % 2 = 1. 6 % 2 = 0
                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = color1;
                    else
                        buttons[i, j].BackColor = color2;

                    // highlight the legal moves
                    if (myBoard.TheGrid[i, j].IsLegalNextMove)
                        buttons[i, j].BackColor = color3;
                    if (myBoard.TheGrid[i, j].IsCurrentlyOccupied != "")
                        buttons[i, j].BackColor = color4;




                }
            }
        }
    }
}
