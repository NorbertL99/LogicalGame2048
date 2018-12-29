// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                // References
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Classes;                                                                            // Allow to use program classes
using System.IO;                                                                                // Allow to work on files

namespace _2048.Classes
{
    class AppFileManagament
    {
        AppFieldsManagament fieldsManagament = new AppFieldsManagament();                       // Create new object of AppFieldsManagament
        AppScoresManagament scoresManagament = new AppScoresManagament();                       // Create new object of AppScoresManagament

        public AppFileManagament()                                                              // Constructor, empty
        {

        }
        public void makeSave(int[,] gameBoard)                                                  // This method is used to make game save
        {
            File.Delete("../../Files/Saves/save.txt");                                          // Remove file with saves
            StreamWriter streamWriter = File.CreateText("../../Files/Saves/save.txt");          // Create stream to new created file with saves
            for (int i = 0; i < 4; i++)                                                         // This loop doing for every column in table
            {
                for(int j = 0; j < 4; j++)                                                      // This loop doing for every line in table
                {
                    streamWriter.WriteLine(gameBoard[i, j]);                                    // Writeing gameBoard[i,j] to file
                }
            }
            streamWriter.WriteLine(scoresManagament.returnScores());                            // Writeing scores on las index
            streamWriter.Close();                                                               // Closeing file
        }
        public int[,] loadSave()                                                                // This method is used to load game save
        {
            int[,] gameBoard = new int[4, 4];                                                   // This 2D board will store the map from file
            StreamReader streamReader = new StreamReader("../../Files/Saves/save.txt");         // Create StreamReader to file with saved game
            for (int i = 0; i < 4; i++)                                                         // This loop doing for every column in table
            {
                for (int j = 0; j < 4; j++)                                                     // This loop doing for every line in table
                {
                    gameBoard[i, j] = Convert.ToInt32(streamReader.ReadLine());                 // Seting valu of gameBoard i,j with readed line
                }
            }
            scoresManagament.setScoresWithValue(Convert.ToInt32(streamReader.ReadLine()));      // Seting scores value
            streamReader.Close();                                                               // Closeing file
            return gameBoard;                                                                   // Returning loaded game board
        }
        public void resetScore()                                                                // This method is used to reset scores
        {
            File.Delete("../../Files/topscores.txt");                                           // Removed topscores file
            StreamWriter streamWriter = File.CreateText("../../Files/topscores.txt");           // Create stream to new created file with topscores
            for(int i = 0; i < 10; i++)                                                         // This loop doing 10 times to wrote 10 lines
            {
                streamWriter.WriteLine("0");                                                    // Write line with 0 text
            }
            streamWriter.Close();                                                               // Close stream
        }
        public string getScores()                                                               // This method is used to get scores from file
        {
            string[] table = new string[10];                                                    // Create new table of strings
            StreamReader streamReader = new StreamReader("../../Files/topscores.txt");          // Create stream to topscores file
            for(int i = 0; i < 10; i++)                                                         // This loop doing 10 times, foreach line in file
            {
                table[i] = streamReader.ReadLine();                                             // Write table i value as a line from file
            }
            streamReader.Close();                                                               // Closeing stream
            return "1. " + table[0] + " \n" +                                                   // Returne score from file
                   "2. " + table[1] + " \n" +                                                   // Returne score from file
                   "3. " + table[2] + " \n" +                                                   // Returne score from file
                   "4. " + table[3] + " \n" +                                                   // Returne score from file
                   "5. " + table[4] + " \n" +                                                   // Returne score from file
                   "6. " + table[5] + " \n" +                                                   // Returne score from file
                   "7. " + table[6] + " \n" +                                                   // Returne score from file
                   "8. " + table[7] + " \n" +                                                   // Returne score from file
                   "9. " + table[8] + " \n" +                                                   // Returne score from file
                   "10. " + table[9] + " \n";                                                   // Returne score from file
        }
        public void clearSave()                                                                 // This method is used to clear game save
        {
            File.Delete("../../Files/Saves/save.txt");                                          // Remove file with saves
            StreamWriter streamWriter = File.CreateText("../../Files/Saves/save.txt");          // Create stream to new created file with saves
            for(int i = 0; i < 15; i++)                                                         // This loop doing 15 times
            {
                streamWriter.WriteLine("0");                                                    // Insert 0 into save file
            }
            streamWriter.WriteLine("2");                                                        // Insert 2 into save file on last index to dont leave board empty
            streamWriter.WriteLine("0");                                                        // Last index where are scores as 0
            streamWriter.Close();                                                               // Closeing stream
        }
        public int[] getTopTen()                                                                // This method is used to get top scores from file
        {
            int[] topScores = new int[10];                                                      // This table store top scores from file
            StreamReader streamReader = new StreamReader("../../Files/topscores.txt");          // Create stream to new created file with topscores
            for(int i = 0; i < 10; i++)                                                         // This loop doing 10 times
            {
                topScores[i] = Convert.ToInt32(streamReader.ReadLine());                        // Set top scores i with value from file on each line
            }
            streamReader.Close();                                                               // Closeing stream
            return topScores;                                                                   // Returning topScores
        }
        public void saveTopTen(int[] topScores)                                                 // This method is used to save top scores in file
        {
            File.Delete("../../Files/topscores.txt");                                           // Removed topscores file
            StreamWriter streamWriter = File.CreateText("../../Files/topscores.txt");           // Create stream to new created file with topscores
            for (int i = 10; i > -1; i--)                                                       // This loop doing 10 times to write 10 lines
            {
                streamWriter.WriteLine(topScores[i]);                                           // Write line with topScore index
            }
            streamWriter.Close();                                                               // Closeing stream
        }
    }
}
