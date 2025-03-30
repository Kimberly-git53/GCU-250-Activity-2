namespace ChessBoardGUIApp
{
    partial class frmChessBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPieceName = new Label();
            comboPieceNames = new ComboBox();
            panelChessBoard = new Panel();
            groupboxColorTheme = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupboxColorTheme.SuspendLayout();
            SuspendLayout();
            // 
            // lblPieceName
            // 
            lblPieceName.AutoSize = true;
            lblPieceName.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPieceName.ForeColor = Color.FromArgb(0, 64, 0);
            lblPieceName.Location = new Point(587, 18);
            lblPieceName.Margin = new Padding(5, 0, 5, 0);
            lblPieceName.Name = "lblPieceName";
            lblPieceName.Size = new Size(538, 28);
            lblPieceName.TabIndex = 0;
            lblPieceName.Text = "Choose a chess piece you would like to play";
            // 
            // comboPieceNames
            // 
            comboPieceNames.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPieceNames.FormattingEnabled = true;
            comboPieceNames.Items.AddRange(new object[] { "Bishop", "King", "Knight", "Queen", "Rook", "Pawn" });
            comboPieceNames.Location = new Point(686, 50);
            comboPieceNames.Margin = new Padding(5, 4, 5, 4);
            comboPieceNames.Name = "comboPieceNames";
            comboPieceNames.Size = new Size(300, 32);
            comboPieceNames.TabIndex = 1;
            comboPieceNames.SelectionChangeCommitted += comboPieceNames_SelectedIndexChanged;
            // 
            // panelChessBoard
            // 
            panelChessBoard.Font = new Font("Bookman Old Style", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelChessBoard.Location = new Point(32, 29);
            panelChessBoard.Margin = new Padding(2);
            panelChessBoard.Name = "panelChessBoard";
            panelChessBoard.Size = new Size(500, 500);
            panelChessBoard.TabIndex = 2;
            // 
            // groupboxColorTheme
            // 
            groupboxColorTheme.Controls.Add(radioButton3);
            groupboxColorTheme.Controls.Add(radioButton2);
            groupboxColorTheme.Controls.Add(radioButton1);
            groupboxColorTheme.ForeColor = Color.DarkSlateGray;
            groupboxColorTheme.Location = new Point(637, 163);
            groupboxColorTheme.Name = "groupboxColorTheme";
            groupboxColorTheme.Size = new Size(410, 275);
            groupboxColorTheme.TabIndex = 3;
            groupboxColorTheme.TabStop = false;
            groupboxColorTheme.Text = "Color Theme";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(40, 153);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(96, 28);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Bright";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(38, 101);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 28);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Warm";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(40, 51);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 28);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Dark";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmChessBoard
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1172, 540);
            Controls.Add(groupboxColorTheme);
            Controls.Add(lblPieceName);
            Controls.Add(panelChessBoard);
            Controls.Add(comboPieceNames);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmChessBoard";
            Text = "Chess Board";
            groupboxColorTheme.ResumeLayout(false);
            groupboxColorTheme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPieceName;
        private ComboBox comboPieceNames;
        private Panel panelChessBoard;
        private GroupBox groupboxColorTheme;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
