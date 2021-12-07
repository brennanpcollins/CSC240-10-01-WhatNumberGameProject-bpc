
namespace CSC240_10_01_WhatNumberGameProject_bpc
{
    partial class GameProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameProject));
            this.UxGuessTitleLabel = new System.Windows.Forms.Label();
            this.UxGuessSubtitleLabel = new System.Windows.Forms.Label();
            this.UxGameCounterTexBox = new System.Windows.Forms.TextBox();
            this.UxHintTextBox = new System.Windows.Forms.TextBox();
            this.UxHintTitleLabel = new System.Windows.Forms.Label();
            this.UxNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.UxGuessingLabel = new System.Windows.Forms.Label();
            this.UxCompareButton = new System.Windows.Forms.Button();
            this.UxStartGameButton = new System.Windows.Forms.Button();
            this.UxWrongCorrectTextBox = new System.Windows.Forms.TextBox();
            this.UxStartOverButton = new System.Windows.Forms.Button();
            this.UxGCounterLabel = new System.Windows.Forms.Label();
            this.UxACounterLabel = new System.Windows.Forms.Label();
            this.UxAttemptCounterTextBox = new System.Windows.Forms.TextBox();
            this.UxResetButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // UxGuessTitleLabel
            // 
            this.UxGuessTitleLabel.AutoSize = true;
            this.UxGuessTitleLabel.BackColor = System.Drawing.Color.Red;
            this.UxGuessTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UxGuessTitleLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGuessTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UxGuessTitleLabel.Image = ((System.Drawing.Image)(resources.GetObject("UxGuessTitleLabel.Image")));
            this.UxGuessTitleLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UxGuessTitleLabel.Location = new System.Drawing.Point(895, 80);
            this.UxGuessTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UxGuessTitleLabel.Name = "UxGuessTitleLabel";
            this.UxGuessTitleLabel.Size = new System.Drawing.Size(861, 98);
            this.UxGuessTitleLabel.TabIndex = 0;
            this.UxGuessTitleLabel.Text = "Guess The Number!";
            // 
            // UxGuessSubtitleLabel
            // 
            this.UxGuessSubtitleLabel.AutoSize = true;
            this.UxGuessSubtitleLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGuessSubtitleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.UxGuessSubtitleLabel.Image = ((System.Drawing.Image)(resources.GetObject("UxGuessSubtitleLabel.Image")));
            this.UxGuessSubtitleLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.UxGuessSubtitleLabel.Location = new System.Drawing.Point(1224, 176);
            this.UxGuessSubtitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UxGuessSubtitleLabel.Name = "UxGuessSubtitleLabel";
            this.UxGuessSubtitleLabel.Size = new System.Drawing.Size(189, 74);
            this.UxGuessSubtitleLabel.TabIndex = 1;
            this.UxGuessSubtitleLabel.Text = "1-10";
            // 
            // UxGameCounterTexBox
            // 
            this.UxGameCounterTexBox.BackColor = System.Drawing.Color.Blue;
            this.UxGameCounterTexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxGameCounterTexBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGameCounterTexBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UxGameCounterTexBox.Location = new System.Drawing.Point(479, 1128);
            this.UxGameCounterTexBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UxGameCounterTexBox.Name = "UxGameCounterTexBox";
            this.UxGameCounterTexBox.Size = new System.Drawing.Size(89, 34);
            this.UxGameCounterTexBox.TabIndex = 2;
            this.UxGameCounterTexBox.TabStop = false;
            // 
            // UxHintTextBox
            // 
            this.UxHintTextBox.BackColor = System.Drawing.Color.Lime;
            this.UxHintTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxHintTextBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxHintTextBox.ForeColor = System.Drawing.Color.Red;
            this.UxHintTextBox.Location = new System.Drawing.Point(2092, 765);
            this.UxHintTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UxHintTextBox.Multiline = true;
            this.UxHintTextBox.Name = "UxHintTextBox";
            this.UxHintTextBox.Size = new System.Drawing.Size(474, 96);
            this.UxHintTextBox.TabIndex = 3;
            // 
            // UxHintTitleLabel
            // 
            this.UxHintTitleLabel.AutoSize = true;
            this.UxHintTitleLabel.BackColor = System.Drawing.Color.Lime;
            this.UxHintTitleLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxHintTitleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.UxHintTitleLabel.Location = new System.Drawing.Point(2265, 728);
            this.UxHintTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UxHintTitleLabel.Name = "UxHintTitleLabel";
            this.UxHintTitleLabel.Size = new System.Drawing.Size(120, 44);
            this.UxHintTitleLabel.TabIndex = 4;
            this.UxHintTitleLabel.Text = "Hint:";
            // 
            // UxNumberInputTextBox
            // 
            this.UxNumberInputTextBox.BackColor = System.Drawing.Color.Black;
            this.UxNumberInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxNumberInputTextBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxNumberInputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UxNumberInputTextBox.Location = new System.Drawing.Point(1291, 733);
            this.UxNumberInputTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UxNumberInputTextBox.Multiline = true;
            this.UxNumberInputTextBox.Name = "UxNumberInputTextBox";
            this.UxNumberInputTextBox.Size = new System.Drawing.Size(58, 46);
            this.UxNumberInputTextBox.TabIndex = 1;
            this.UxNumberInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UxGuessingLabel
            // 
            this.UxGuessingLabel.AutoSize = true;
            this.UxGuessingLabel.BackColor = System.Drawing.Color.Transparent;
            this.UxGuessingLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGuessingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UxGuessingLabel.Location = new System.Drawing.Point(1109, 728);
            this.UxGuessingLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UxGuessingLabel.Name = "UxGuessingLabel";
            this.UxGuessingLabel.Size = new System.Drawing.Size(171, 51);
            this.UxGuessingLabel.TabIndex = 6;
            this.UxGuessingLabel.Text = "Guess:";
            // 
            // UxCompareButton
            // 
            this.UxCompareButton.BackColor = System.Drawing.Color.Lime;
            this.UxCompareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UxCompareButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxCompareButton.ForeColor = System.Drawing.Color.Yellow;
            this.UxCompareButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UxCompareButton.Location = new System.Drawing.Point(1533, 678);
            this.UxCompareButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UxCompareButton.Name = "UxCompareButton";
            this.UxCompareButton.Size = new System.Drawing.Size(266, 102);
            this.UxCompareButton.TabIndex = 7;
            this.UxCompareButton.Text = "Compare";
            this.UxCompareButton.UseVisualStyleBackColor = false;
            this.UxCompareButton.Click += new System.EventHandler(this.UxCompareButton_Click);
            // 
            // UxStartGameButton
            // 
            this.UxStartGameButton.BackColor = System.Drawing.Color.Aqua;
            this.UxStartGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UxStartGameButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxStartGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UxStartGameButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UxStartGameButton.Location = new System.Drawing.Point(1145, 415);
            this.UxStartGameButton.Name = "UxStartGameButton";
            this.UxStartGameButton.Size = new System.Drawing.Size(350, 202);
            this.UxStartGameButton.TabIndex = 8;
            this.UxStartGameButton.Text = "Start Game";
            this.UxStartGameButton.UseVisualStyleBackColor = false;
            this.UxStartGameButton.Click += new System.EventHandler(this.UxStartGameButton_Click);
            // 
            // UxWrongCorrectTextBox
            // 
            this.UxWrongCorrectTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UxWrongCorrectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxWrongCorrectTextBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxWrongCorrectTextBox.ForeColor = System.Drawing.Color.Aqua;
            this.UxWrongCorrectTextBox.Location = new System.Drawing.Point(1109, 1154);
            this.UxWrongCorrectTextBox.Multiline = true;
            this.UxWrongCorrectTextBox.Name = "UxWrongCorrectTextBox";
            this.UxWrongCorrectTextBox.Size = new System.Drawing.Size(419, 85);
            this.UxWrongCorrectTextBox.TabIndex = 9;
            // 
            // UxStartOverButton
            // 
            this.UxStartOverButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UxStartOverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UxStartOverButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxStartOverButton.ForeColor = System.Drawing.Color.Aqua;
            this.UxStartOverButton.Location = new System.Drawing.Point(1145, 1233);
            this.UxStartOverButton.Name = "UxStartOverButton";
            this.UxStartOverButton.Size = new System.Drawing.Size(350, 159);
            this.UxStartOverButton.TabIndex = 10;
            this.UxStartOverButton.Text = "New Game";
            this.UxStartOverButton.UseVisualStyleBackColor = false;
            this.UxStartOverButton.Visible = false;
            this.UxStartOverButton.Click += new System.EventHandler(this.UxStartOverButton_Click);
            // 
            // UxGCounterLabel
            // 
            this.UxGCounterLabel.AutoSize = true;
            this.UxGCounterLabel.BackColor = System.Drawing.Color.Blue;
            this.UxGCounterLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGCounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UxGCounterLabel.Location = new System.Drawing.Point(38, 1120);
            this.UxGCounterLabel.Name = "UxGCounterLabel";
            this.UxGCounterLabel.Size = new System.Drawing.Size(447, 51);
            this.UxGCounterLabel.TabIndex = 11;
            this.UxGCounterLabel.Text = "Number of Games:";
            // 
            // UxACounterLabel
            // 
            this.UxACounterLabel.AutoSize = true;
            this.UxACounterLabel.BackColor = System.Drawing.Color.Blue;
            this.UxACounterLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxACounterLabel.ForeColor = System.Drawing.Color.Red;
            this.UxACounterLabel.Location = new System.Drawing.Point(38, 1233);
            this.UxACounterLabel.Name = "UxACounterLabel";
            this.UxACounterLabel.Size = new System.Drawing.Size(492, 49);
            this.UxACounterLabel.TabIndex = 12;
            this.UxACounterLabel.Text = "Number of Attempts:";
            // 
            // UxAttemptCounterTextBox
            // 
            this.UxAttemptCounterTextBox.BackColor = System.Drawing.Color.Blue;
            this.UxAttemptCounterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxAttemptCounterTextBox.ForeColor = System.Drawing.Color.Red;
            this.UxAttemptCounterTextBox.Location = new System.Drawing.Point(526, 1238);
            this.UxAttemptCounterTextBox.Name = "UxAttemptCounterTextBox";
            this.UxAttemptCounterTextBox.Size = new System.Drawing.Size(88, 37);
            this.UxAttemptCounterTextBox.TabIndex = 13;
            this.UxAttemptCounterTextBox.TabStop = false;
            // 
            // UxResetButton
            // 
            this.UxResetButton.BackColor = System.Drawing.Color.Blue;
            this.UxResetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UxResetButton.BackgroundImage")));
            this.UxResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UxResetButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxResetButton.ForeColor = System.Drawing.Color.White;
            this.UxResetButton.Location = new System.Drawing.Point(2167, 1206);
            this.UxResetButton.Name = "UxResetButton";
            this.UxResetButton.Size = new System.Drawing.Size(442, 254);
            this.UxResetButton.TabIndex = 15;
            this.UxResetButton.Text = "Start Over! Reset Board.";
            this.UxResetButton.UseVisualStyleBackColor = false;
            this.UxResetButton.Click += new System.EventHandler(this.UxResetButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // GameProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2638, 1507);
            this.Controls.Add(this.UxHintTextBox);
            this.Controls.Add(this.UxAttemptCounterTextBox);
            this.Controls.Add(this.UxGameCounterTexBox);
            this.Controls.Add(this.UxResetButton);
            this.Controls.Add(this.UxACounterLabel);
            this.Controls.Add(this.UxGCounterLabel);
            this.Controls.Add(this.UxStartOverButton);
            this.Controls.Add(this.UxWrongCorrectTextBox);
            this.Controls.Add(this.UxStartGameButton);
            this.Controls.Add(this.UxCompareButton);
            this.Controls.Add(this.UxGuessingLabel);
            this.Controls.Add(this.UxNumberInputTextBox);
            this.Controls.Add(this.UxHintTitleLabel);
            this.Controls.Add(this.UxGuessSubtitleLabel);
            this.Controls.Add(this.UxGuessTitleLabel);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GameProject";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxGuessTitleLabel;
        private System.Windows.Forms.Label UxGuessSubtitleLabel;
        private System.Windows.Forms.TextBox UxGameCounterTexBox;
        private System.Windows.Forms.TextBox UxHintTextBox;
        private System.Windows.Forms.Label UxHintTitleLabel;
        private System.Windows.Forms.TextBox UxNumberInputTextBox;
        private System.Windows.Forms.Label UxGuessingLabel;
        private System.Windows.Forms.Button UxCompareButton;
        private System.Windows.Forms.Button UxStartGameButton;
        private System.Windows.Forms.TextBox UxWrongCorrectTextBox;
        private System.Windows.Forms.Button UxStartOverButton;
        private System.Windows.Forms.Label UxGCounterLabel;
        private System.Windows.Forms.Label UxACounterLabel;
        private System.Windows.Forms.TextBox UxAttemptCounterTextBox;
        private System.Windows.Forms.Button UxResetButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

