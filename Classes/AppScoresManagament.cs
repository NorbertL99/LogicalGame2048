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
        int[] topScores = new int[11];
        static int score = 0;                                           // This variable store scores
        public AppScoresManagament()                                    // Constructor, empty
        {

        }
        public int returnScores()                                       // This method is used to return scores
        {
            return score;                                               // Returning score
        }
        public void addScores(int value)                                // This method is used to add scores to scores
        {
            score = score + value;                                      // Score = score + value
        }
        public void resetScores()                                       // This method is used to reset scores
        {
            score = 0;                                                  // Set value of score as 0
        }
        public void setScoresWithValue(int value)                       // This method is used to set scores with specific value
        {
            score = value;                                              // Set score value as value
        }
        public int[] sortArray(int[] array, int score)                  // This method is used to sort array of current best scores and new score
        {
            for(int i = 0; i < 10; i++)                                 // This loop doing 10 times
            {
                topScores[i] = array[i];                                // Seting topScore i with array i value
            }
            topScores[10] = score;                                      // As last index set a score value
            Array.Sort(topScores);                                      // Sort topScores array
            return topScores;                                           // Return topScores array
        }
    }
}
