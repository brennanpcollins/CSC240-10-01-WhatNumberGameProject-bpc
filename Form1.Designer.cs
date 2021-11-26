
namespace CSC240_10_01_WhatNumberGameProject_bpc
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // UxGuessTitleLabel
            // 
            this.UxGuessTitleLabel.AutoSize = true;
            this.UxGuessTitleLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGuessTitleLabel.Location = new System.Drawing.Point(985, 83);
            this.UxGuessTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UxGuessTitleLabel.Name = "UxGuessTitleLabel";
            this.UxGuessTitleLabel.Size = new System.Drawing.Size(602, 69);
            this.UxGuessTitleLabel.TabIndex = 0;
            this.UxGuessTitleLabel.Text = "Guess The Number!";
            this.UxGuessTitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UxGuessSubtitleLabel
            // 
            this.UxGuessSubtitleLabel.AutoSize = true;
            this.UxGuessSubtitleLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGuessSubtitleLabel.Location = new System.Drawing.Point(1215, 176);
            this.UxGuessSubtitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UxGuessSubtitleLabel.Name = "UxGuessSubtitleLabel";
            this.UxGuessSubtitleLabel.Size = new System.Drawing.Size(154, 60);
            this.UxGuessSubtitleLabel.TabIndex = 1;
            this.UxGuessSubtitleLabel.Text = "1-10";
            // 
            // UxGameCounterTexBox
            // 
            this.UxGameCounterTexBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGameCounterTexBox.Location = new System.Drawing.Point(493, 1125);
            this.UxGameCounterTexBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UxGameCounterTexBox.Name = "UxGameCounterTexBox";
            this.UxGameCounterTexBox.Size = new System.Drawing.Size(89, 41);
            this.UxGameCounterTexBox.TabIndex = 2;
            // 
            // UxHintTextBox
            // 
            this.UxHintTextBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxHintTextBox.Location = new System.Drawing.Point(2059, 757);
            this.UxHintTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UxHintTextBox.Multiline = true;
            this.UxHintTextBox.Name = "UxHintTextBox";
            this.UxHintTextBox.Size = new System.Drawing.Size(552, 208);
            this.UxHintTextBox.TabIndex = 3;
            // 
            // UxHintTitleLabel
            // 
            this.UxHintTitleLabel.AutoSize = true;
            this.UxHintTitleLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxHintTitleLabel.Location = new System.Drawing.Point(2263, 709);
            this.UxHintTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UxHintTitleLabel.Name = "UxHintTitleLabel";
            this.UxHintTitleLabel.Size = new System.Drawing.Size(120, 44);
            this.UxHintTitleLabel.TabIndex = 4;
            this.UxHintTitleLabel.Text = "Hint:";
            // 
            // UxNumberInputTextBox
            // 
            this.UxNumberInputTextBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxNumberInputTextBox.Location = new System.Drawing.Point(1124, 680);
            this.UxNumberInputTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UxNumberInputTextBox.Multiline = true;
            this.UxNumberInputTextBox.Name = "UxNumberInputTextBox";
            this.UxNumberInputTextBox.Size = new System.Drawing.Size(351, 101);
            this.UxNumberInputTextBox.TabIndex = 5;
            this.UxNumberInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UxGuessingLabel
            // 
            this.UxGuessingLabel.AutoSize = true;
            this.UxGuessingLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGuessingLabel.Location = new System.Drawing.Point(967, 709);
            this.UxGuessingLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UxGuessingLabel.Name = "UxGuessingLabel";
            this.UxGuessingLabel.Size = new System.Drawing.Size(147, 44);
            this.UxGuessingLabel.TabIndex = 6;
            this.UxGuessingLabel.Text = "Guess:";
            // 
            // UxCompareButton
            // 
            this.UxCompareButton.Location = new System.Drawing.Point(1533, 679);
            this.UxCompareButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UxCompareButton.Name = "UxCompareButton";
            this.UxCompareButton.Size = new System.Drawing.Size(266, 102);
            this.UxCompareButton.TabIndex = 7;
            this.UxCompareButton.Text = "Compare";
            this.UxCompareButton.UseVisualStyleBackColor = true;
            // 
            // UxStartGameButton
            // 
            this.UxStartGameButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxStartGameButton.Location = new System.Drawing.Point(1124, 384);
            this.UxStartGameButton.Name = "UxStartGameButton";
            this.UxStartGameButton.Size = new System.Drawing.Size(351, 202);
            this.UxStartGameButton.TabIndex = 8;
            this.UxStartGameButton.Text = "Start Game";
            this.UxStartGameButton.UseVisualStyleBackColor = true;
            // 
            // UxWrongCorrectTextBox
            // 
            this.UxWrongCorrectTextBox.Location = new System.Drawing.Point(1088, 882);
            this.UxWrongCorrectTextBox.Multiline = true;
            this.UxWrongCorrectTextBox.Name = "UxWrongCorrectTextBox";
            this.UxWrongCorrectTextBox.Size = new System.Drawing.Size(420, 279);
            this.UxWrongCorrectTextBox.TabIndex = 9;
            // 
            // UxStartOverButton
            // 
            this.UxStartOverButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxStartOverButton.Location = new System.Drawing.Point(1124, 1296);
            this.UxStartOverButton.Name = "UxStartOverButton";
            this.UxStartOverButton.Size = new System.Drawing.Size(351, 159);
            this.UxStartOverButton.TabIndex = 10;
            this.UxStartOverButton.Text = "Start Over";
            this.UxStartOverButton.UseVisualStyleBackColor = true;
            this.UxStartOverButton.Visible = false;
            // 
            // UxGCounterLabel
            // 
            this.UxGCounterLabel.AutoSize = true;
            this.UxGCounterLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxGCounterLabel.Location = new System.Drawing.Point(38, 1120);
            this.UxGCounterLabel.Name = "UxGCounterLabel";
            this.UxGCounterLabel.Size = new System.Drawing.Size(447, 51);
            this.UxGCounterLabel.TabIndex = 11;
            this.UxGCounterLabel.Text = "Number of Games:";
            // 
            // UxACounterLabel
            // 
            this.UxACounterLabel.AutoSize = true;
            this.UxACounterLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxACounterLabel.Location = new System.Drawing.Point(38, 1233);
            this.UxACounterLabel.Name = "UxACounterLabel";
            this.UxACounterLabel.Size = new System.Drawing.Size(492, 49);
            this.UxACounterLabel.TabIndex = 12;
            this.UxACounterLabel.Text = "Number of Attempts:";
            // 
            // UxAttemptCounterTextBox
            // 
            this.UxAttemptCounterTextBox.Location = new System.Drawing.Point(536, 1235);
            this.UxAttemptCounterTextBox.Name = "UxAttemptCounterTextBox";
            this.UxAttemptCounterTextBox.Size = new System.Drawing.Size(88, 44);
            this.UxAttemptCounterTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2705, 1501);
            this.Controls.Add(this.UxAttemptCounterTextBox);
            this.Controls.Add(this.UxACounterLabel);
            this.Controls.Add(this.UxGCounterLabel);
            this.Controls.Add(this.UxStartOverButton);
            this.Controls.Add(this.UxWrongCorrectTextBox);
            this.Controls.Add(this.UxStartGameButton);
            this.Controls.Add(this.UxCompareButton);
            this.Controls.Add(this.UxGuessingLabel);
            this.Controls.Add(this.UxNumberInputTextBox);
            this.Controls.Add(this.UxHintTitleLabel);
            this.Controls.Add(this.UxHintTextBox);
            this.Controls.Add(this.UxGameCounterTexBox);
            this.Controls.Add(this.UxGuessSubtitleLabel);
            this.Controls.Add(this.UxGuessTitleLabel);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

