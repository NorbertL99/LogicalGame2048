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

namespace _2048.Classes
{
    class AppScoresManagament
    {
        static int score = 0;                                           // This variable store scores
        public AppScoresManagament()                                    // Constructor, empty
        {

        }
        public int returnScores()                                       // This method is used to return scores
        {
            return score;
        }
        public void addScores(int value)                                // This method is used to add scores to scores
        {
            score = score + value;
        }
    }
}
