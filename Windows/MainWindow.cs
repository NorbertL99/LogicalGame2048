// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                    // References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048.Classes;                                                                                // This namespace allow to use program classes

namespace _2048
{
    public partial class MainWindow : Form
    {
        AppFieldsManagament fieldsManagament = new AppFieldsManagament();                           // Create new object of AppFieldsManagament
        AppFieldsColorManagament colorManagament = new AppFieldsColorManagament();                  // Create new object of AppFieldsColorManagament
        AppScoresManagament scoresManagament = new AppScoresManagament();                           // Create new object of AppScoresManagament
        AppInformationsManagament informationsManagament = new AppInformationsManagament();         // Create new object of AppInformationsManagament
        AppFileManagament fileManagament = new AppFileManagament();                                 // Create new object of AppFileManagament

        public MainWindow()                                                                         // This method run when window open
        {
            InitializeComponent();                                                                  // Initialize components
            fieldsManagament.initializeMap();                                                       // Initialize map
            refreshLabels();                                                                        // Refreshing labels
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)                              // This method run when some button on keyboard clicked
        {
            switch(e.KeyCode)                                                                       // Switch on e.KeyCode
            {
                case Keys.Up:                                                                       // If keyCode is up arrow
                    fieldsManagament.moveFieldsUp();                                                // Run moveFieldsUp method from AppFieldsManagament class
                    refreshLabels();                                                                // Run refresh labels method
                    break;
                case Keys.Down:                                                                     // If keyCode is down arrow
                    fieldsManagament.moveFieldsDown();                                              // Run moveFieldsDown method from AppFieldsManagament class
                    refreshLabels();                                                                // Run refresh labels method
                    break;
                case Keys.Right:                                                                    // If keyCode is right arrow
                    fieldsManagament.moveFieldsRight();                                             // Run moveFieldsRight method from AppFieldsManagament class
                    refreshLabels();                                                                // Run refresh labels method
                    break;
                case Keys.Left:                                                                     // If keyCode is left arrow
                    fieldsManagament.moveFieldsLeft();                                              // Run moveFieldsLeft method from AppFieldsManagament class
                    refreshLabels();                                                                // Run refresh labels method
                    break;
            }
            if(fieldsManagament.checkForPossibleMove() == 0)                                        // If there is no more possible move
            {
                MessageBox.Show("You lost, there is no more possible move ! \n" +                   // Inform user about lose
                "Your score: " + scoresManagament.returnScores(),                                   // Inform about scores
                "You lost",                                                                         // Title
                MessageBoxButtons.OK, MessageBoxIcon.Information);                                  // Set buttons and icon for message box
                startNewGame();                                                                     // Run startNewGame method
            }
        }
        private void refreshLabels()                                                                // This method is used to refresh labels
        {
            int[,] gameBoard = fieldsManagament.getGameBoard();                                     // Create new table with store gameBoard from Fields Managament
            number1.Text = gameBoard[0, 0].ToString();                                              // Refresh number label with number from table on specific index
            number2.Text = gameBoard[0, 1].ToString();                                              // Refresh number label with number from table on specific index
            number3.Text = gameBoard[0, 2].ToString();                                              // Refresh number label with number from table on specific index
            number4.Text = gameBoard[0, 3].ToString();                                              // Refresh number label with number from table on specific index
            number5.Text = gameBoard[1, 0].ToString();                                              // Refresh number label with number from table on specific index
            number6.Text = gameBoard[1, 1].ToString();                                              // Refresh number label with number from table on specific index
            number7.Text = gameBoard[1, 2].ToString();                                              // Refresh number label with number from table on specific index
            number8.Text = gameBoard[1, 3].ToString();                                              // Refresh number label with number from table on specific index
            number9.Text = gameBoard[2, 0].ToString();                                              // Refresh number label with number from table on specific index
            number10.Text = gameBoard[2, 1].ToString();                                             // Refresh number label with number from table on specific index
            number11.Text = gameBoard[2, 2].ToString();                                             // Refresh number label with number from table on specific index
            number12.Text = gameBoard[2, 3].ToString();                                             // Refresh number label with number from table on specific index
            number13.Text = gameBoard[3, 0].ToString();                                             // Refresh number label with number from table on specific index
            number14.Text = gameBoard[3, 1].ToString();                                             // Refresh number label with number from table on specific index
            number15.Text = gameBoard[3, 2].ToString();                                             // Refresh number label with number from table on specific index
            number16.Text = gameBoard[3, 3].ToString();                                             // Refresh number label with number from table on specific index
            pointsLabel.Text = scoresManagament.returnScores().ToString();                          // Refrehs scores with scores returned by method from scoresManagament
            field1.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number1.Text));     // Update field color
            field2.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number2.Text));     // Update field color
            field3.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number3.Text));     // Update field color
            field4.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number4.Text));     // Update field color
            field5.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number5.Text));     // Update field color
            field6.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number6.Text));     // Update field color
            field7.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number7.Text));     // Update field color
            field8.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number8.Text));     // Update field color
            field9.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number9.Text));     // Update field color
            field10.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number10.Text));   // Update field color
            field11.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number11.Text));   // Update field color
            field12.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number12.Text));   // Update field color
            field13.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number13.Text));   // Update field color
            field14.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number14.Text));   // Update field color
            field15.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number15.Text));   // Update field color
            field16.BackColor = colorManagament.getColorForValue(Convert.ToInt32(number16.Text));   // Update field color
            number1.BackColor = field1.BackColor;                                                   // Label back color same as field color
            number2.BackColor = field2.BackColor;                                                   // Label back color same as field color
            number3.BackColor = field3.BackColor;                                                   // Label back color same as field color
            number4.BackColor = field4.BackColor;                                                   // Label back color same as field color
            number5.BackColor = field5.BackColor;                                                   // Label back color same as field color
            number6.BackColor = field6.BackColor;                                                   // Label back color same as field color
            number7.BackColor = field7.BackColor;                                                   // Label back color same as field color
            number8.BackColor = field8.BackColor;                                                   // Label back color same as field color
            number9.BackColor = field9.BackColor;                                                   // Label back color same as field color
            number10.BackColor = field10.BackColor;                                                 // Label back color same as field color
            number11.BackColor = field11.BackColor;                                                 // Label back color same as field color
            number12.BackColor = field12.BackColor;                                                 // Label back color same as field color
            number13.BackColor = field13.BackColor;                                                 // Label back color same as field color
            number14.BackColor = field14.BackColor;                                                 // Label back color same as field color
            number15.BackColor = field15.BackColor;                                                 // Label back color same as field color
            number16.BackColor = field16.BackColor;                                                 // Label back color same as field color
        }

        #region Buttons click reaction
        private void newGame_Click(object sender, EventArgs e)                                      // This method run when newGame_Click
        {
            if(MessageBox.Show("Are you sure you want to start new game ?",                         // Asking user about he is sure of restart game
                "New game", MessageBoxButtons.YesNo) == DialogResult.Yes)                           // If result of answer is yes
            {
                startNewGame();                                                                     // Run startNewGaem method
            }
        }
        private void saveGame_Click(object sender, EventArgs e)                                     // This method run when saveGame_Click
        {
            if (MessageBox.Show("Are you sure you want to save game ? \n" +                         // Asking user about he is sure of saveing games
                "It will delete your previous save !",                                              // Inform user about what will happend
                "Save game", MessageBoxButtons.YesNo) == DialogResult.Yes)                          // If result of answer is yes
            {
                fileManagament.makeSave();                                                          // Run make save method
                MessageBox.Show("Game saved properly !", "Save",                                    // Inform user abot properly operation
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                              // Set buttons and icon of message box
            }
        }
        private void loadGame_Click(object sender, EventArgs e)                                     // This method run when loadGame_Click
        {
            if (MessageBox.Show("Are you sure you want to load game ? \n" +                         // Asking user about he is sure of saveing games
                "It will restart your current game !",                                              // Inform user about what will happend
                "Load game", MessageBoxButtons.YesNo) == DialogResult.Yes)                          // If result of answer is yes
            {
                fileManagament.loadSave();                                                          // Run load save method
                MessageBox.Show("Game loaded properly !", "Save",                                   // Inform user abot properly operation
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                              // Set buttons and icon of message box
            }
        }
        private void seeScores_Click(object sender, EventArgs e)                                    // This method run when seeScores_Click
        {
            MessageBox.Show(fileManagament.getScores(), "TOP 10 Scores",                            // Show user top 10 scores 
                MessageBoxButtons.OK, MessageBoxIcon.Information);                                  // Set buttons and icon of message box
        }
        private void resetScores_Click(object sender, EventArgs e)                                  // This method run when resetScores_Click
        {
            if (MessageBox.Show("Are you sure you want to reset your scores ? \n" +                 // Asking user about he is sure of saveing games
                "It remove all scores that were ever saved !",                                      // Inform user about what will happend
                "Reset scores", MessageBoxButtons.YesNo) == DialogResult.Yes)                       // If result of answer is yes
            {
                fileManagament.resetScore();                                                        // Run reset scores method
                MessageBox.Show("TOP 10 Scores removed properly !", "Save",                         // Inform user abot properly operation
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                              // Set buttons and icon of message box
            }
        }
        private void seeInstruction_Click(object sender, EventArgs e)                               // This method run when seeInstruction_Click
        {
            MessageBox.Show(informationsManagament.gameInstruction(), "Instruction",                // Give user game instruction
                MessageBoxButtons.OK, MessageBoxIcon.Information);                                  // Set buttons and icon for message box
        }
        private void seeAuthor_Click(object sender, EventArgs e)                                    // This method run when seeAuthor_Click
        {
            MessageBox.Show(informationsManagament.authorInformation(), "About author",             // Give information of author for user
                MessageBoxButtons.OK, MessageBoxIcon.Information);                                  // Set buttons and icon for message box
        }
        private void undoMove_Click(object sender, EventArgs e)                                     // This method run when undoMove_Click
        {
            fieldsManagament.undoMove();                                                            // Run undoMove method from fieldsManagament
            refreshLabels();                                                                        // Run refreshLabels methods
        }
        #endregion
        private void startNewGame()                                                                 // This method is used to start new game
        {
            fieldsManagament.resetFields();                                                         // Run resetFields method 
            scoresManagament.resetScores();                                                         // Run resetScores method
            fieldsManagament.initializeMap();                                                       // Run initializeMap method
            refreshLabels();                                                                        // Run refresh board method
        }
    }
}
