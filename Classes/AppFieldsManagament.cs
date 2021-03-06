﻿// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                    // References 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Classes;                                                                                // This namespace allow to use program classes

namespace _2048.Classes
{
    class AppFieldsManagament
    {
        #region Variables and objects
        int[,] fieldsTable = new int[4, 4];                                                         // This table store game board
        int[,] fieldsTableCopy;                                                                     // This variable store copy of fieldsTable created before move
        List<int> emptyFields = new List<int>();                                                    // This list store empty fields on game board
        AppScoresManagament scoresManagament = new AppScoresManagament();                           // Create new object of AppScoresManagament
        #endregion
        #region Core
        #region Moveing fields
        /* Algorithm info
         * -------------------------------------------------------
         * Algorith of it checking every possible combination
         * If combination is correct doing specific instruction
         * For moveFieldsDown checking every possible combintation
         * from down to up. For moveFieldsUp checking every
         * possible combination from up to down. For moveFieldsLeft
         * checking every possible combination from left to right.
         * For moveFieldsRight checking every possible combination
         * from right to left.
         * 
         * Possible combiantions in good orded 
         * -------------------------------------------------------
         * First is same like secound. Secound same like third.
         * Third same like last. First is 0. Secound is 0. Third
         * is 0. Everything else waht should be done is in code.
        */
        public void moveFieldsDown()                                                                // This method is used to move fields down
        {
            fieldsTableCopy = (int[,])fieldsTable.Clone();                                          // Create copy of fieldsTable         
            for ( int i = 0; i < 4; i++)                                                            // This loop doing every think inside 4 times
            {
                if (fieldsTable[3, i] == fieldsTable[2, i])                                         // If 3,i = 2,i then
                {
                    fieldsTable[3, i] = fieldsTable[3, i] + fieldsTable[2, i];                      // 3,i = 3,i + 2,i
                    scoresManagament.addScores(fieldsTable[3, i]);                                  // Adding value to scores
                    fieldsTable[2, i] = 0;                                                          // 2,i = 0
                }
                if (fieldsTable[2, i] == fieldsTable[1, i])                                         // If 2,i = 1,i then
                {
                    fieldsTable[2, i] = fieldsTable[2, i] + fieldsTable[1, i];                      // 2,i = 2,i + 1,i
                    scoresManagament.addScores(fieldsTable[2, i]);                                  // Adding value to scores
                    fieldsTable[1, i] = 0;                                                          // 1,i = 0
                }
                if (fieldsTable[1, i] == fieldsTable[0, i])                                         // If 1,i = 0,i then
                {
                    fieldsTable[1, i] = fieldsTable[1, i] + fieldsTable[0, i];                      // 1,i = 1,i + 0,i
                    scoresManagament.addScores(fieldsTable[1, i]);                                  // Adding value to scores
                    fieldsTable[0, i] = 0;                                                          // 0,i = 0
                }
                if (fieldsTable[3, i] == 0)                                                         // If 3,i = 0 then
                {
                    if (fieldsTable[2, i] == 0 && fieldsTable[1, i] == 0)                           // If 2,i = 0 and 1,i = 0 then
                    {
                        fieldsTable[3, i] = fieldsTable[0, i];                                      // 3,i = 0,i
                        fieldsTable[0, i] = 0;                                                      // 0,i = 0
                    }
                    else if (fieldsTable[2, i] == 0)                                                // Else if 2,i = 0
                    {
                        fieldsTable[3, i] = fieldsTable[1, i];                                      // 3,i = 1,i
                        fieldsTable[2, i] = fieldsTable[0, i];                                      // 2,i = 0,i
                        fieldsTable[1, i] = 0;                                                      // 1,i = 0
                        fieldsTable[0, i] = 0;                                                      // 0,i = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[3, i] = fieldsTable[2, i];                                      // 3,i = 2,i
                        fieldsTable[2, i] = fieldsTable[1, i];                                      // 2,i = 1,i
                        fieldsTable[1, i] = fieldsTable[0, i];                                      // 1,i = 0,i
                        fieldsTable[0, i] = 0;                                                      // 0,i = 0
                    }
                }
                if (fieldsTable[2, i] == 0)                                                         // If 2,i = 0 then
                {
                    if (fieldsTable[3, i] == fieldsTable[1, i])                                     // If 3,i = 1,i then
                    {
                        fieldsTable[3, i] = fieldsTable[3, i] + fieldsTable[1, i];                  // 3,i = 3,i + 1,i
                        scoresManagament.addScores(fieldsTable[3, i]);                              // Adding value to scores
                        fieldsTable[1, i] = 0;                                                      // 1,i = 0
                    }
                    else if (fieldsTable[1, i] == 0 && fieldsTable[0, i] == fieldsTable[3, i])      // Else if 1,i = 0 and 0,i = 3,i then
                    {
                        fieldsTable[3, i] = fieldsTable[3, i] + fieldsTable[0, i];                  // 3,i = 3,i + 0,i
                        scoresManagament.addScores(fieldsTable[3, i]);                              // Adding value to scores
                        fieldsTable[0, i] = 0;                                                      // 0,i = 0
                    }
                    else if ( fieldsTable[1, i] == 0 )                                              // Else if 1,i = 0
                    {
                        fieldsTable[2, i] = fieldsTable[0, i];                                      // 2,i = 0,i
                        fieldsTable[0, i] = 0;                                                      // 0,i = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[2, i] = fieldsTable[1, i];                                      // 2,i = 1,i
                        fieldsTable[1, i] = fieldsTable[0, i];                                      // 1,i = 0,i
                        fieldsTable[0, i] = 0;                                                      // 0,i = 0
                    }
                }
                if (fieldsTable[1, i] == 0)                                                         // If 1,i = 0 then
                {
                    if (fieldsTable[2, i] == fieldsTable[0, i])                                     // If 2,i = 0,i then
                    {
                        fieldsTable[2, i] = fieldsTable[2, i] + fieldsTable[0, i];                  // 2,i = 2,i + 0,1
                        scoresManagament.addScores(fieldsTable[2, i]);                              // Adding value to scores
                        fieldsTable[0, i] = 0;                                                      // 0,i = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[1, i] = fieldsTable[0, i];                                      // 1,i = 0,i
                        fieldsTable[0, i] = 0;                                                      // 0,1 = 0
                    }
                }
            }
            compareGameBoard();                                                                     // Run compareGameBoard methid
        }
        public void moveFieldsUp()                                                                  // This method is used to move fields up
        {
            fieldsTableCopy = (int[,])fieldsTable.Clone();                                          // Create copy of fieldsTable 
            for(int i = 0; i < 4; i++)                                                              // This loop doing every think inside 4 times
            {
                if(fieldsTable[0,i] == fieldsTable[1,i])                                            // If 0,i = 1,i then
                {
                    fieldsTable[0, i] = fieldsTable[0, i] + fieldsTable[1, i];                      // 0,i = 0,i + 1,i
                    scoresManagament.addScores(fieldsTable[0, i]);                                  // Adding value to scores
                    fieldsTable[1, i] = 0;                                                          // 1,i = 0
                }
                if (fieldsTable[1, i] == fieldsTable[2, i])                                         // If 1,i = 2,i then
                {
                    fieldsTable[1, i] = fieldsTable[1, i] + fieldsTable[2, i];                      // 1,i = 1,i + 2,i
                    scoresManagament.addScores(fieldsTable[1, i]);                                  // Adding value to scores
                    fieldsTable[2, i] = 0;                                                          // 2,i = 0
                }
                if (fieldsTable[2, i] == fieldsTable[3, i])                                         // If 2,i = 3,i then
                {
                    fieldsTable[2, i] = fieldsTable[2, i] + fieldsTable[3, i];                      // 2,i = 2,i + 3,i
                    scoresManagament.addScores(fieldsTable[2, i]);                                  // Adding value to scores
                    fieldsTable[3, i] = 0;                                                          // 3,i = 0
                }
                if(fieldsTable[0,i] == 0)                                                           // If 0,i = 0 then
                {
                    if(fieldsTable[1,i] == 0 && fieldsTable[2,i] == 0)                              // If 1,i = 0 and 2,i = o then
                    {
                        fieldsTable[0, i] = fieldsTable[3, i];                                      // 0,i = 3,i
                        fieldsTable[3, i] = 0;                                                      // 3,i = 0
                    }
                    else if(fieldsTable[1,i] == 0)                                                  // Else if 1,i = 0 then
                    {
                        fieldsTable[0, i] = fieldsTable[2, i];                                      // 0,i = 2,i
                        fieldsTable[1, i] = fieldsTable[3, i];                                      // 1,i = 3,i
                        fieldsTable[2, i] = 0;                                                      // 2,i = 0
                        fieldsTable[3, i] = 0;                                                      // 3,i = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[0, i] = fieldsTable[1, i];                                      // 0,i = 1,i
                        fieldsTable[1, i] = fieldsTable[2, i];                                      // 1,i = 2,i
                        fieldsTable[2, i] = fieldsTable[3, i];                                      // 2,i = 3,i
                        fieldsTable[3, i] = 0;                                                      // 3,i = 0
                    }
                }
                if (fieldsTable[1, i] == 0)                                                         // If 1,i = 0 then
                {
                    if(fieldsTable[0,i] == fieldsTable[2,i])                                        // If 0,i = 2,i then
                    {
                        fieldsTable[0, i] = fieldsTable[0, i] + fieldsTable[2, i];                  // 0,i = 0,i + 2,i
                        scoresManagament.addScores(fieldsTable[0, i]);                              // Adding value to scores
                        fieldsTable[2, i] = 0;                                                      // 2,i = 0
                    }
                    else if(fieldsTable[2,i] == 0 && fieldsTable[0,i] == fieldsTable[3,i])          // Else if 2,i = 0 and 0,i = 3,i
                    {
                        fieldsTable[0, i] = fieldsTable[0, i] + fieldsTable[3, i];                  // 0,i = 0,i + 3,i
                        scoresManagament.addScores(fieldsTable[0, i]);                              // Adding value to scores
                        fieldsTable[3, i] = 0;                                                      // 3,i = 0
                    }   
                    else if(fieldsTable[2,i] == 0)                                                  // Else if 2,i = 0 then
                    {
                        fieldsTable[1, i] = fieldsTable[3, i];                                      // 1,i = 3,i
                        fieldsTable[3, i] = 0;                                                      // 3,i = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[1, i] = fieldsTable[2, i];                                      // 1,i = 2,i
                        fieldsTable[2, i] = fieldsTable[3, i];                                      // 2,i = 3,i
                        fieldsTable[3, i] = 0;                                                      // 3,i = 0
                    }
                }
                if (fieldsTable[2, i] == 0)                                                         // If 2,i = 0 then
                {
                    if(fieldsTable[1,i] == fieldsTable[3,i])                                        // If 1,i = 3,i then
                    {
                        fieldsTable[1, i] = fieldsTable[1, i] + fieldsTable[3, i];                  // 1,i = 1,i + 3,i
                        scoresManagament.addScores(fieldsTable[1, i]);                              // Adding value to scores
                        fieldsTable[3, i] = 0;                                                      // 3,i = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[2, i] = fieldsTable[3, i];                                      // 2,i = 3,i
                        fieldsTable[3, i] = 0;                                                      // 3,i = 0
                    }
                }
            }
            compareGameBoard();                                                                     // Run compareGameBoard methid
        }
        public void moveFieldsRight()                                                               // This method is used to move fields right
        {
            fieldsTableCopy = (int[,])fieldsTable.Clone();                                          // Create copy of fieldsTable 
            for(int i = 0; i < 4; i++)                                                              // This loop doing every think inside 4 times
            {
                if (fieldsTable[i, 3] == fieldsTable[i, 2])                                         // If i,3 = i,2 then
                {
                    fieldsTable[i, 3] = fieldsTable[i, 3] + fieldsTable[i, 2];                      // i,3 = i,3 + i,2
                    scoresManagament.addScores(fieldsTable[i,3]);                                   // Adding value to scores
                    fieldsTable[i, 2] = 0;                                                          // i,2 = 0
                }
                if (fieldsTable[i, 2] == fieldsTable[i, 1])                                         // If i,2 = i,1
                {
                    fieldsTable[i, 2] = fieldsTable[i, 2] + fieldsTable[i, 1];                      // i,2 = i,2 + i,1
                    scoresManagament.addScores(fieldsTable[i, 2]);                                  // Adding value to scores
                    fieldsTable[i, 1] = 0;                                                          // i,1 = 0
                }
                if (fieldsTable[i, 1] == fieldsTable[i, 0])                                         // If i,1 = i,0
                {
                    fieldsTable[i, 1] = fieldsTable[i, 1] + fieldsTable[i, 0];                      // i,1 = i,1 + i,0
                    scoresManagament.addScores(fieldsTable[i, 1]);                                  // Adding value to scores
                    fieldsTable[i, 0] = 0;                                                          // i,0 = 0
                }
                if (fieldsTable[i, 3] == 0)                                                         // If i,3 = 0 then
                {
                    if (fieldsTable[i, 2] == 0 && fieldsTable[i, 1] == 0)                           // If i,2 = 0 and i,1 = 0 then
                    {
                        fieldsTable[i, 3] = fieldsTable[i, 0];                                      // i,3 = i,0
                        fieldsTable[i, 0] = 0;                                                      // i,0 = 0
                    }
                    else if (fieldsTable[i, 2] == 0)                                                // Else if i,2 = 0 then
                    {
                        fieldsTable[i, 3] = fieldsTable[i, 1];                                      // i,3 = i,1
                        fieldsTable[i, 2] = fieldsTable[i, 0];                                      // i,2 = i,0
                        fieldsTable[i, 1] = 0;                                                      // i,1 = 0
                        fieldsTable[i, 0] = 0;                                                      // i,0 = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[i, 3] = fieldsTable[i, 2];                                      // i,3 = i,2
                        fieldsTable[i, 2] = fieldsTable[i, 1];                                      // i,2 = i,1
                        fieldsTable[i, 1] = fieldsTable[i, 0];                                      // i,1 = i,0    
                        fieldsTable[i, 0] = 0;                                                      // i,0 = 0
                    }
                }
                if (fieldsTable[i, 2] == 0)                                                         // If i,2 = 0 then
                {
                    if(fieldsTable[i,3] == fieldsTable[i,1])                                        // If i,3 = i,1 then
                    {
                        fieldsTable[i, 3] = fieldsTable[i, 3] + fieldsTable[i, 1];                  // i,3 = i,3 + i,1
                        scoresManagament.addScores(fieldsTable[i, 3]);                              // Adding value to scores
                        fieldsTable[i, 1] = 0;                                                      // i,1 = 0
                    }
                    else if(fieldsTable[i,1] == 0 && fieldsTable[i,0] == fieldsTable[i,3])          // Else if i,1 = 0 and i,0 = i,3 then
                    {
                        fieldsTable[i, 3] = fieldsTable[i, 3] + fieldsTable[i, 0];                  // i,3 = i,3 + i,0
                        scoresManagament.addScores(fieldsTable[i, 3]);                              // Adding value to scores
                        fieldsTable[i, 0] = 0;                                                      // i,0 = 0
                    }
                    else if(fieldsTable[i,1] == 0)                                                  // Else if i,1 = 0 then
                    {
                        fieldsTable[i, 2] = fieldsTable[i, 0];                                      // i,2 = i,0
                        fieldsTable[i, 0] = 0;                                                      // i,0 = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[i, 2] = fieldsTable[i, 1];                                      // i,2 = i,1
                        fieldsTable[i, 1] = fieldsTable[i, 0];                                      // i,1 = i,0
                        fieldsTable[i, 0] = 0;                                                      // i,0 = 0
                    }
                }
                if (fieldsTable[i, 1] == 0)                                                         // If i,1 = 0 then
                {
                    if(fieldsTable[i,2] == fieldsTable[i,0])                                        // If i,2 = i,0 then
                    {
                        fieldsTable[i, 2] = fieldsTable[i, 2] + fieldsTable[i, 0];                  // i,2 = i,2 + i,0
                        scoresManagament.addScores(fieldsTable[i, 2]);                              // Adding value to scores
                        fieldsTable[i, 0] = 0;                                                      // i,0 = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[i, 1] = fieldsTable[i, 0];                                      // i,1 = i,0
                        fieldsTable[i, 0] = 0;                                                      // i,0 = 0
                    }
                }
            }
            compareGameBoard();                                                                     // Run compareGameBoard methid
        }
        public void moveFieldsLeft()                                                                // This method is used to move fields left
        {
            // TODO REPEAR IT
            fieldsTableCopy = (int[,])fieldsTable.Clone();                                          // Create copy of fieldsTable 
            for (int i = 0; i < 4; i++)                                                             // This loop doing every think inside 4 times
            {
                if (fieldsTable[i, 0] == fieldsTable[i, 1])                                         // If i,0 = i,1 then
                {
                    fieldsTable[i, 0] = fieldsTable[i, 0] + fieldsTable[i, 1];                      // i,0 = i,0 + i,1
                    scoresManagament.addScores(fieldsTable[i, 0]);                                  // Adding value to scores
                    fieldsTable[i, 1] = 0;                                                          // i,1 = 0
                }
                if (fieldsTable[i, 1] == fieldsTable[i, 2])                                         // If i,1 = i,2
                {
                    fieldsTable[i, 1] = fieldsTable[i, 1] + fieldsTable[i, 2];                      // i,1 = i,1 + i,2
                    scoresManagament.addScores(fieldsTable[i, 1]);                                  // Adding value to scores
                    fieldsTable[i, 2] = 0;                                                          // i,2 = 0
                }
                if (fieldsTable[i, 2] == fieldsTable[i, 3])                                         // If i,2 = i,3
                {
                    fieldsTable[i, 2] = fieldsTable[i, 2] + fieldsTable[i, 3];                      // i,2 = i,2 + i,3
                    scoresManagament.addScores(fieldsTable[i, 2]);                                  // Adding value to scores
                    fieldsTable[i, 3] = 0;                                                          // i,3 = 0
                }
                if (fieldsTable[i, 0] == 0)                                                         // If i,0 = 0 then
                {
                    if (fieldsTable[i, 1] == 0 && fieldsTable[i, 2] == 0)                           // If i,1 = 0 and i,2 = 0 then
                    {
                        fieldsTable[i, 0] = fieldsTable[i, 3];                                      // i,0 = i,3
                        fieldsTable[i, 3] = 0;                                                      // i,3 = 0
                    }
                    else if (fieldsTable[i, 1] == 0)                                                // Else if i,1 = 0 then
                    {
                        fieldsTable[i, 0] = fieldsTable[i, 2];                                      // i,0 = i,2
                        fieldsTable[i, 1] = fieldsTable[i, 3];                                      // i,1 = i,3
                        fieldsTable[i, 2] = 0;                                                      // i,2 = 0
                        fieldsTable[i, 3] = 0;                                                      // i,3 = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[i, 0] = fieldsTable[i, 1];                                      // i,0 = i,1
                        fieldsTable[i, 1] = fieldsTable[i, 2];                                      // i,1 = i,2
                        fieldsTable[i, 2] = fieldsTable[i, 3];                                      // i,2 = i,3    
                        fieldsTable[i, 3] = 0;                                                      // i,3 = 0
                    }
                }
                if (fieldsTable[i, 1] == 0)                                                         // If i,1 = 0 then
                {
                    if (fieldsTable[i, 0] == fieldsTable[i, 2])                                     // If i,0 = i,2 then
                    {
                        fieldsTable[i, 0] = fieldsTable[i, 0] + fieldsTable[i, 2];                  // i,0 = i,0 + i,2
                        scoresManagament.addScores(fieldsTable[i, 0]);                              // Adding value to scores
                        fieldsTable[i, 2] = 0;                                                      // i,2 = 0
                    }
                    else if (fieldsTable[i, 2] == 0 && fieldsTable[i, 0] == fieldsTable[i, 3])      // Else if i,2 = 0 and i,0 = i,3 then
                    {
                        fieldsTable[i, 0] = fieldsTable[i, 0] + fieldsTable[i, 3];                  // i,0 = i,0 + i,3
                        scoresManagament.addScores(fieldsTable[i, 0]);                              // Adding value to scores
                        fieldsTable[i, 3] = 0;                                                      // i,3 = 0
                    }
                    else if (fieldsTable[i, 2] == 0)                                                // Else if i,2 = 0 then
                    {
                        fieldsTable[i, 1] = fieldsTable[i, 3];                                      // i,1 = i,3
                        fieldsTable[i, 3] = 0;                                                      // i,3 = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[i, 1] = fieldsTable[i, 2];                                      // i,1 = i,2
                        fieldsTable[i, 2] = fieldsTable[i, 3];                                      // i,2 = i,3
                        fieldsTable[i, 3] = 0;                                                      // i,3 = 0
                    }
                }
                if (fieldsTable[i, 2] == 0)                                                         // If i,2 = 0 then
                {
                    if (fieldsTable[i, 1] == fieldsTable[i, 3])                                     // If i,1 = i,3 then
                    {
                        fieldsTable[i, 1] = fieldsTable[i, 1] + fieldsTable[i, 3];                  // i,1 = i,1 + i,3
                        scoresManagament.addScores(fieldsTable[i, 1]);                              // Adding value to scores
                        fieldsTable[i, 3] = 0;                                                      // i,3 = 0
                    }
                    else                                                                            // Else
                    {
                        fieldsTable[i, 2] = fieldsTable[i, 3];                                      // i,2 = i,3
                        fieldsTable[i, 3] = 0;                                                      // i,3 = 0
                    }
                }
            }
            compareGameBoard();                                                                     // Run compareGameBoard methid
        }
        #endregion
        private void setRandom()                                                                    // This method is used to get random value
        {
            Random random = new Random();                                                           // Create new object of Random class
            setEmptyFields();                                                                       // Run setEmptyFields method
            int index = random.Next(emptyFields.Count);                                             // Set index value as a random value from emptyFields list element
            if(random.Next(0,100) > 80)                                                             // If random value from 0 to 100 is higher than 80
            {
                insertRandom(index, 4);                                                             // Run insertRandom with given parameters index and 4
            }
            else                                                                                    // Else
            {
                insertRandom(index, 2);                                                             // Run insertRandom with given parameters index and 2
            }
        }
        private void setEmptyFields()                                                               // This method is used to set empty fields
        {
            emptyFields.Clear();                                                                    // Clearing list
            if (fieldsTable[0, 0] == 0) emptyFields.Add(0);                                         // If 0,0 = 0 insert 0 to list
            if (fieldsTable[0, 1] == 0) emptyFields.Add(1);                                         // If 0,1 = 0 insert 1 to list
            if (fieldsTable[0, 2] == 0) emptyFields.Add(2);                                         // If 0,2 = 0 insert 2 to list
            if (fieldsTable[0, 3] == 0) emptyFields.Add(3);                                         // If 0,3 = 0 insert 3 to list
            if (fieldsTable[1, 0] == 0) emptyFields.Add(4);                                         // If 1,0 = 0 insert 4 to list
            if (fieldsTable[1, 1] == 0) emptyFields.Add(5);                                         // If 1,1 = 0 insert 5 to list
            if (fieldsTable[1, 2] == 0) emptyFields.Add(6);                                         // If 1,2 = 0 insert 6 to list
            if (fieldsTable[1, 3] == 0) emptyFields.Add(7);                                         // If 1,3 = 0 insert 7 to list
            if (fieldsTable[2, 0] == 0) emptyFields.Add(8);                                         // If 2,0 = 0 insert 8 to list
            if (fieldsTable[2, 1] == 0) emptyFields.Add(9);                                         // If 2,1 = 0 insert 9 to list
            if (fieldsTable[2, 2] == 0) emptyFields.Add(10);                                        // If 2,2 = 0 insert 10 to list
            if (fieldsTable[2, 3] == 0) emptyFields.Add(11);                                        // If 2,3 = 0 insert 11 to list
            if (fieldsTable[3, 0] == 0) emptyFields.Add(12);                                        // If 3,0 = 0 insert 12 to list
            if (fieldsTable[3, 1] == 0) emptyFields.Add(13);                                        // If 3,1 = 0 insert 13 to list
            if (fieldsTable[3, 2] == 0) emptyFields.Add(14);                                        // If 3,2 = 0 insert 14 to list
            if (fieldsTable[3, 3] == 0) emptyFields.Add(15);                                        // If 3,3 = 0 insert 15 to list
        }
        private void insertRandom(int index, int value)                                             // This method is used to insert random value into random table place
        {
            if (emptyFields[index] == 0) fieldsTable[0, 0] = value;                                 // If value from emptyFields on index is 0, then fieldsTable 0,0 = value
            if (emptyFields[index] == 1) fieldsTable[0, 1] = value;                                 // If value from emptyFields on index is 1, then fieldsTable 0,1 = value
            if (emptyFields[index] == 2) fieldsTable[0, 2] = value;                                 // If value from emptyFields on index is 2, then fieldsTable 0,2 = value
            if (emptyFields[index] == 3) fieldsTable[0, 3] = value;                                 // If value from emptyFields on index is 3, then fieldsTable 0,3 = value
            if (emptyFields[index] == 4) fieldsTable[1, 0] = value;                                 // If value from emptyFields on index is 4, then fieldsTable 1,0 = value
            if (emptyFields[index] == 5) fieldsTable[1, 1] = value;                                 // If value from emptyFields on index is 5, then fieldsTable 1,1 = value
            if (emptyFields[index] == 6) fieldsTable[1, 2] = value;                                 // If value from emptyFields on index is 6, then fieldsTable 1,2 = value
            if (emptyFields[index] == 7) fieldsTable[1, 3] = value;                                 // If value from emptyFields on index is 7, then fieldsTable 1,3 = value
            if (emptyFields[index] == 8) fieldsTable[2, 0] = value;                                 // If value from emptyFields on index is 8, then fieldsTable 2,0 = value
            if (emptyFields[index] == 9) fieldsTable[2, 1] = value;                                 // If value from emptyFields on index is 9, then fieldsTable 2,1 = value
            if (emptyFields[index] == 10) fieldsTable[2, 2] = value;                                // If value from emptyFields on index is 10, then fieldsTable 2,2 = value
            if (emptyFields[index] == 11) fieldsTable[2, 3] = value;                                // If value from emptyFields on index is 11, then fieldsTable 2,3 = value
            if (emptyFields[index] == 12) fieldsTable[3, 0] = value;                                // If value from emptyFields on index is 12, then fieldsTable 3,0 = value
            if (emptyFields[index] == 13) fieldsTable[3, 1] = value;                                // If value from emptyFields on index is 13, then fieldsTable 3,1 = value
            if (emptyFields[index] == 14) fieldsTable[3, 2] = value;                                // If value from emptyFields on index is 14, then fieldsTable 3,2 = value
            if (emptyFields[index] == 15) fieldsTable[3, 3] = value;                                // If value from emptyFields on index is 15, then fieldsTable 3,3 = value
        }
        private void compareGameBoard()                                                             // This method is used to check about diffrence on game board
        {
            for(int i = 0; i < 4; i++)                                                              // This loop doing 4 times, for each column
            {
                for(int j = 0; j < 4; j++)                                                          // This loop doing 4 times, for each line
                {
                    if(fieldsTableCopy[i,j] != fieldsTable[i,j])                                    // If copy i,j is not equal original i,j
                    {
                        setRandom();                                                                // Run set random method
                        return;                                                                     // Return 
                    }
                }
            }
        }
        #endregion
        public AppFieldsManagament()                                                                // Constructor, empty
        {

        }
        public int[,] getGameBoard()                                                                // This method is used to return fieldsTable
        {
            return fieldsTable;                                                                     // Return fieldsTable
        }
        public void initializeMap()                                                                 // This method is used to initialize map in main window
        {
            setRandom();                                                                            // Run setRandom method
        }
        public void undoMove()                                                                      // This method is used to undo last move
        {
            fieldsTable = fieldsTableCopy;                                                          // Seting fieldsTable with fieldsTableCopy
        }
        public void resetFields()                                                                   // This method is used to reset fields
        {
            for (int i = 0; i < 4; i++)                                                             // This loop doing 4 times for every column in tables
            {
                for(int j = 0; j < 4; j++)                                                          // This loop doing 4 times for every line in tables
                {
                    fieldsTable[i, j] = 0;                                                          // Set value in fieldsTable i,j as 0
                    fieldsTableCopy[i, j] = 0;                                                      // Set value in fieldsTableCopy i,j as 0
                }
            }
        }
        public void setFieldsTableValue(int[,] value)                                               // This method is used to set fields table with specific value
        {
            fieldsTable = value;                                                                    // Set fieldsTable as value
        }
        public int checkForPossibleMove()                                                           // This method check that user had any possible move
        {
            for (int i = 0; i < 4; i++)                                                             // This loop doing for every column
            {
                for (int j = 0; j < 4; j++)                                                         // This loop doing for every line
                {
                    if (fieldsTable[i, j] == 0) return 1;                                           // If fieldsTable i,j = 0, return 1
                }
            }
            for (int i = 0; i < 3; i++)                                                             // This loop doing for every column - 1
            {
                for(int j = 0; j < 3; j++)                                                          // This loop doing for every line - 1
                {
                    if (fieldsTable[i, j + 1] == fieldsTable[i, j] ||                               // If condition is true
                       fieldsTable[i + 1, j] == fieldsTable[i, j]) return 1;                        // Returne 1
                }
            }
            if (fieldsTable[3, 0] == fieldsTable[3, 1] ||                                           // If condition is true
               fieldsTable[3, 1] == fieldsTable[3, 2] ||                                            // If condition is true
               fieldsTable[3, 2] == fieldsTable[3, 3] ||                                            // If condition is true
               fieldsTable[0, 3] == fieldsTable[1, 3] ||                                            // If condition is true
               fieldsTable[1, 3] == fieldsTable[2, 3] ||                                            // If condition is true
               fieldsTable[2, 3] == fieldsTable[3, 3]) return 1;                                    // If condition is true, return 1
            return 0;                                                                               // If there is no condition with true, return 0
        }
    }
}
