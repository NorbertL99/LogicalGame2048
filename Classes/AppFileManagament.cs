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
using _2048.Classes;                                                                    // Allow to use program classes
using System.IO;                                                                        // Allow to work on files

namespace _2048.Classes
{
    class AppFileManagament
    {
        AppFieldsManagament fieldsManagament = new AppFieldsManagament();               // Create new object of AppFieldsManagament
        AppScoresManagament scoresManagament = new AppScoresManagament();               // Create new object of AppScoresManagament

        public AppFileManagament()                                                      // Constructor, empty
        {

        }
        public void makeSave()                                                          // This method is used to make game save
        {
            
        }
        public void loadSave()                                                          // This method is used to load game save
        {

        }
        public void resetScore()                                                        // This method is used to reset scores
        {
            File.Delete("../../Files/topscores.txt");                                   // Removed topscores file
            StreamWriter streamWriter = File.CreateText("../../Files/topscores.txt");   // Create stream to new created file with topscores
            for(int i = 0; i < 10; i++)                                                 // This loop doing 10 times to wrote 10 lines
            {
                streamWriter.WriteLine("0");                                            // Write line with 0 text
            }
            streamWriter.Close();                                                       // Close stream
        }
        public string getScores()                                                       // This method is used to get scores from file
        {
            string[] table = new string[10];                                            // Create new table of strings
            StreamReader streamReader = new StreamReader("../../Files/topscores.txt");  // Create stream to topscores file
            for(int i = 0; i < 10; i++)                                                 // This loop doing 10 times, foreach line in file
            {
                table[i] = streamReader.ReadLine();                                     // Write table i value as a line from file
            }
            streamReader.Close();                                                       // Closeing stream
            return "1. " + table[0] + " \n" +                                           // Returne score from file
                   "2. " + table[1] + " \n" +                                           // Returne score from file
                   "3. " + table[2] + " \n" +                                           // Returne score from file
                   "4. " + table[3] + " \n" +                                           // Returne score from file
                   "5. " + table[4] + " \n" +                                           // Returne score from file
                   "6. " + table[5] + " \n" +                                           // Returne score from file
                   "7. " + table[6] + " \n" +                                           // Returne score from file
                   "8. " + table[7] + " \n" +                                           // Returne score from file
                   "9. " + table[8] + " \n" +                                           // Returne score from file
                   "10. " + table[9] + " \n";                                           // Returne score from file
        }
    }
}
