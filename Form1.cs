using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_10_01_WhatNumberGameProject_bpc
{
    public partial class GameProject : Form
    {
            
            int randomN;
            int input;
            int games = 0;
            int attempt = 0;
            Random randomNu = new Random();
            


        public GameProject()
        {
            InitializeComponent();   
        }

        private void UxStartGameButton_Click(object sender, EventArgs e)
        {   
            randomN = randomNu.Next(1, 10);
        }


        private void UxCompareButton_Click(object sender, EventArgs e)
        {
            UxAttemptCounterTextBox.Visible = true;
            UxGameCounterTexBox.Visible = true;
            UxHintTextBox.Visible = true;
            UxWrongCorrectTextBox.Visible = true;
            input = Convert.ToInt32(UxNumberInputTextBox.Text);
            attempt += 1;
            UxAttemptCounterTextBox.Text = attempt.ToString();
            if (input == randomN)
            {
                UxWrongCorrectTextBox.Text = "Correct!";
                UxStartOverButton.Visible = true;
                UxStartGameButton.Visible = false;
                UxCompareButton.Enabled = false;
                UxHintTextBox.Text = null;
            }
            else
            {   
                    UxWrongCorrectTextBox.Text = "Wrong! Look at the hints.";
                    if (input > randomN)
                {
                    UxHintTextBox.Text = "Guess a little lower.";
                }
                    else
                {
                    UxHintTextBox.Text = "Guess a little higher.";
                }
             
            }
        }

        private void GameProject_Load(object sender, EventArgs e)
        {

        }

        private void UxStartOverButton_Click(object sender, EventArgs e)
        {
            
            attempt = 0;
            UxAttemptCounterTextBox.Text = attempt.ToString();
            randomN = randomNu.Next(1, 10);
            games += 1;
            UxGameCounterTexBox.Text = games.ToString();
            UxNumberInputTextBox.Text = null;
            UxCompareButton.Enabled = true;
            UxStartOverButton.Visible = false;
            UxHintTextBox.Text = null;
            UxWrongCorrectTextBox.Text = null;
            UxWrongCorrectTextBox.Visible = false;
            UxHintTextBox.Visible = false;
            UxAttemptCounterTextBox.Visible = false;
        }

        private void UxResetButton_Click(object sender, EventArgs e)
        {
            UxStartOverButton.Visible = false;
            UxStartGameButton.Visible = true;
            UxCompareButton.Enabled = true;
            UxAttemptCounterTextBox.Text = attempt.ToString();
            attempt = 0;
            games = 0;
            UxGameCounterTexBox.Text = games.ToString();
            UxNumberInputTextBox.Text = null;
            UxHintTextBox.Text = null;
            UxWrongCorrectTextBox.Text = null;
            UxWrongCorrectTextBox.Visible = false;
            UxHintTextBox.Visible = false;
            UxAttemptCounterTextBox.Visible = false;
            UxGameCounterTexBox.Visible = false;
        }
    }
}
