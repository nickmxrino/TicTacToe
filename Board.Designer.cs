namespace TicTacToe
{
    partial class Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MiddleField = new System.Windows.Forms.Button();
            this.RightField = new System.Windows.Forms.Button();
            this.TopField = new System.Windows.Forms.Button();
            this.TopRightField = new System.Windows.Forms.Button();
            this.TopLeftField = new System.Windows.Forms.Button();
            this.LeftField = new System.Windows.Forms.Button();
            this.BottomRightField = new System.Windows.Forms.Button();
            this.BottomField = new System.Windows.Forms.Button();
            this.BottomLeftField = new System.Windows.Forms.Button();
            this.PlayerScore = new System.Windows.Forms.TextBox();
            this.PlayerDisplay = new System.Windows.Forms.TextBox();
            this.ComputerScore = new System.Windows.Forms.TextBox();
            this.ComputerDisplay = new System.Windows.Forms.TextBox();
            this.ResultDisplay = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MiddleField
            // 
            this.MiddleField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MiddleField.FlatAppearance.BorderSize = 0;
            this.MiddleField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiddleField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleField.Location = new System.Drawing.Point(250, 209);
            this.MiddleField.Name = "MiddleField";
            this.MiddleField.Size = new System.Drawing.Size(60, 60);
            this.MiddleField.TabIndex = 0;
            this.MiddleField.UseVisualStyleBackColor = false;
            this.MiddleField.Click += new System.EventHandler(this.MiddleField_Click);
            // 
            // RightField
            // 
            this.RightField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.RightField.FlatAppearance.BorderSize = 0;
            this.RightField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightField.Location = new System.Drawing.Point(316, 209);
            this.RightField.Name = "RightField";
            this.RightField.Size = new System.Drawing.Size(60, 60);
            this.RightField.TabIndex = 1;
            this.RightField.UseVisualStyleBackColor = false;
            this.RightField.Click += new System.EventHandler(this.RightField_Click);
            // 
            // TopField
            // 
            this.TopField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TopField.FlatAppearance.BorderSize = 0;
            this.TopField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopField.Location = new System.Drawing.Point(250, 143);
            this.TopField.Name = "TopField";
            this.TopField.Size = new System.Drawing.Size(60, 60);
            this.TopField.TabIndex = 2;
            this.TopField.UseVisualStyleBackColor = false;
            this.TopField.Click += new System.EventHandler(this.TopField_Click);
            // 
            // TopRightField
            // 
            this.TopRightField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TopRightField.FlatAppearance.BorderSize = 0;
            this.TopRightField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopRightField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRightField.Location = new System.Drawing.Point(316, 143);
            this.TopRightField.Name = "TopRightField";
            this.TopRightField.Size = new System.Drawing.Size(60, 60);
            this.TopRightField.TabIndex = 3;
            this.TopRightField.UseVisualStyleBackColor = false;
            this.TopRightField.Click += new System.EventHandler(this.TopRightField_Click);
            // 
            // TopLeftField
            // 
            this.TopLeftField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TopLeftField.FlatAppearance.BorderSize = 0;
            this.TopLeftField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopLeftField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLeftField.Location = new System.Drawing.Point(184, 143);
            this.TopLeftField.Name = "TopLeftField";
            this.TopLeftField.Size = new System.Drawing.Size(60, 60);
            this.TopLeftField.TabIndex = 4;
            this.TopLeftField.Text = " ";
            this.TopLeftField.UseVisualStyleBackColor = false;
            this.TopLeftField.Click += new System.EventHandler(this.TopLeftField_Click);
            // 
            // LeftField
            // 
            this.LeftField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LeftField.FlatAppearance.BorderSize = 0;
            this.LeftField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftField.Location = new System.Drawing.Point(184, 209);
            this.LeftField.Name = "LeftField";
            this.LeftField.Size = new System.Drawing.Size(60, 60);
            this.LeftField.TabIndex = 5;
            this.LeftField.UseVisualStyleBackColor = false;
            this.LeftField.Click += new System.EventHandler(this.LeftField_Click);
            // 
            // BottomRightField
            // 
            this.BottomRightField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BottomRightField.FlatAppearance.BorderSize = 0;
            this.BottomRightField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomRightField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomRightField.Location = new System.Drawing.Point(316, 275);
            this.BottomRightField.Name = "BottomRightField";
            this.BottomRightField.Size = new System.Drawing.Size(60, 60);
            this.BottomRightField.TabIndex = 6;
            this.BottomRightField.UseVisualStyleBackColor = false;
            this.BottomRightField.Click += new System.EventHandler(this.BottomRightField_Click);
            // 
            // BottomField
            // 
            this.BottomField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BottomField.FlatAppearance.BorderSize = 0;
            this.BottomField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomField.Location = new System.Drawing.Point(250, 275);
            this.BottomField.Name = "BottomField";
            this.BottomField.Size = new System.Drawing.Size(60, 60);
            this.BottomField.TabIndex = 7;
            this.BottomField.UseVisualStyleBackColor = false;
            this.BottomField.Click += new System.EventHandler(this.BottomField_Click);
            // 
            // BottomLeftField
            // 
            this.BottomLeftField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BottomLeftField.FlatAppearance.BorderSize = 0;
            this.BottomLeftField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomLeftField.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLeftField.Location = new System.Drawing.Point(184, 275);
            this.BottomLeftField.Name = "BottomLeftField";
            this.BottomLeftField.Size = new System.Drawing.Size(60, 60);
            this.BottomLeftField.TabIndex = 8;
            this.BottomLeftField.UseVisualStyleBackColor = false;
            this.BottomLeftField.Click += new System.EventHandler(this.BottomLeftField_Click);
            // 
            // PlayerScore
            // 
            this.PlayerScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerScore.Location = new System.Drawing.Point(165, 394);
            this.PlayerScore.Multiline = true;
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(40, 40);
            this.PlayerScore.TabIndex = 9;
            this.PlayerScore.TextChanged += new System.EventHandler(this.PlayerScore_TextChanged);
            // 
            // PlayerDisplay
            // 
            this.PlayerDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.PlayerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerDisplay.Font = new System.Drawing.Font("Borda 8", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerDisplay.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.PlayerDisplay.Location = new System.Drawing.Point(156, 371);
            this.PlayerDisplay.Name = "PlayerDisplay";
            this.PlayerDisplay.ReadOnly = true;
            this.PlayerDisplay.Size = new System.Drawing.Size(59, 17);
            this.PlayerDisplay.TabIndex = 10;
            this.PlayerDisplay.Text = "PLAYER";
            this.PlayerDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComputerScore
            // 
            this.ComputerScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ComputerScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComputerScore.Location = new System.Drawing.Point(356, 394);
            this.ComputerScore.Multiline = true;
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(40, 40);
            this.ComputerScore.TabIndex = 11;
            // 
            // ComputerDisplay
            // 
            this.ComputerDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ComputerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComputerDisplay.Font = new System.Drawing.Font("Borda 8", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerDisplay.ForeColor = System.Drawing.Color.IndianRed;
            this.ComputerDisplay.Location = new System.Drawing.Point(335, 371);
            this.ComputerDisplay.Name = "ComputerDisplay";
            this.ComputerDisplay.ReadOnly = true;
            this.ComputerDisplay.Size = new System.Drawing.Size(79, 17);
            this.ComputerDisplay.TabIndex = 12;
            this.ComputerDisplay.Text = "COMPUTER";
            this.ComputerDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultDisplay
            // 
            this.ResultDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ResultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDisplay.Font = new System.Drawing.Font("Borda 8", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultDisplay.Location = new System.Drawing.Point(228, 394);
            this.ResultDisplay.Name = "ResultDisplay";
            this.ResultDisplay.ReadOnly = true;
            this.ResultDisplay.Size = new System.Drawing.Size(105, 25);
            this.ResultDisplay.TabIndex = 13;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Font = new System.Drawing.Font("Rust", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.Crimson;
            this.Display.Location = new System.Drawing.Point(206, 90);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(148, 27);
            this.Display.TabIndex = 14;
            this.Display.Text = "Tic-Tac-Toe";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(561, 479);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ResultDisplay);
            this.Controls.Add(this.ComputerDisplay);
            this.Controls.Add(this.ComputerScore);
            this.Controls.Add(this.PlayerDisplay);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.BottomLeftField);
            this.Controls.Add(this.BottomField);
            this.Controls.Add(this.BottomRightField);
            this.Controls.Add(this.LeftField);
            this.Controls.Add(this.TopLeftField);
            this.Controls.Add(this.TopRightField);
            this.Controls.Add(this.TopField);
            this.Controls.Add(this.RightField);
            this.Controls.Add(this.MiddleField);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Board";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Board_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MiddleField;
        private System.Windows.Forms.Button RightField;
        private System.Windows.Forms.Button TopField;
        private System.Windows.Forms.Button TopRightField;
        private System.Windows.Forms.Button TopLeftField;
        private System.Windows.Forms.Button LeftField;
        private System.Windows.Forms.Button BottomRightField;
        private System.Windows.Forms.Button BottomField;
        private System.Windows.Forms.Button BottomLeftField;
        private System.Windows.Forms.TextBox PlayerScore;
        private System.Windows.Forms.TextBox PlayerDisplay;
        private System.Windows.Forms.TextBox ComputerScore;
        private System.Windows.Forms.TextBox ComputerDisplay;
        private System.Windows.Forms.TextBox ResultDisplay;
        private System.Windows.Forms.TextBox Display;
    }
}

